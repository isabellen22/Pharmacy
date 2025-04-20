using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Pharmacy.Classes;
using Pharmacy.Classes.UsefullClasses;

namespace Pharmacy.Forms
{
    public partial class frmWarehouse : Form
    {
        private int selectedID = -1;
        private bool isSelectedByDoubleClick = false;

        public frmWarehouse()
        {
            InitializeComponent();
            dgvWarehouse.AutoGenerateColumns = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void frmWarehouse_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            Warehouse w = new Warehouse(0, "", "", "", LoggedUser.UserID);
            dgvWarehouse.DataSource = w.SELECT();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtLocation.Text) ||
                string.IsNullOrWhiteSpace(txtSpace.Text))
            {
                MessageBox.Show("Please fill all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Warehouse w = new Warehouse(0, txtName.Text, txtLocation.Text, txtSpace.Text, LoggedUser.UserID);
            dgvWarehouse.DataSource = w.INSERT();
            ResetForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!isSelectedByDoubleClick || selectedID <= 0)
                return;

            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtLocation.Text) ||
                string.IsNullOrWhiteSpace(txtSpace.Text))
            {
                MessageBox.Show("Please fill all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Warehouse w = new Warehouse(selectedID, txtName.Text, txtLocation.Text, txtSpace.Text, LoggedUser.UserID);
            dgvWarehouse.DataSource = w.UPDATE();
            ResetForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!isSelectedByDoubleClick || selectedID <= 0)
                return;

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this warehouse?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                Warehouse warehouse = new Warehouse(selectedID, "", "", "", LoggedUser.UserID);
                dgvWarehouse.DataSource = warehouse.DELETE();
                ResetForm();
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                // SQL error 547 = foreign key conflict
                MessageBox.Show(
                    "This warehouse is referenced in other records and cannot be deleted.",
                    "Delete Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unexpected error:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvWarehouse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvWarehouse.Rows[e.RowIndex];

            try
            {
                selectedID = Convert.ToInt32(row.Cells[3].Value); // WarehouseID is hidden column index 3
                txtName.Text = row.Cells[0].Value?.ToString();   // WarehouseName
                txtLocation.Text = row.Cells[1].Value?.ToString(); // WarehouseLocation
                txtSpace.Text = row.Cells[2].Value?.ToString();    // WarehouseSpace

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;
                isSelectedByDoubleClick = true;
            }
            catch
            {
                MessageBox.Show("Unexpected row data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            txtName.Clear();
            txtLocation.Clear();
            txtSpace.Clear();
            selectedID = -1;
            isSelectedByDoubleClick = false;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}
