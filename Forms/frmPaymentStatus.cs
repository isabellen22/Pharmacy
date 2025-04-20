
using Pharmacy.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
    public partial class frmPaymentStatus : Form
    {
        private int selectedID = 0;

        public frmPaymentStatus()
        {
            InitializeComponent();
            dgvPaymentStatus.AutoGenerateColumns = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void frmPaymentStatus_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            PaymentStatus status = new PaymentStatus(0, "");
            dgvPaymentStatus.DataSource = status.SELECT();
        }

        private void ClearInputs()
        {
            txtStatus.Clear();
            selectedID = 0;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtStatus.Text.Trim() == "") return;

            PaymentStatus status = new PaymentStatus(0, txtStatus.Text.Trim());
            status.INSERT();
            LoadData();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedID == 0) return;

            try
            {
                PaymentStatus status = new PaymentStatus(selectedID, "");
                status.DELETE();
                LoadData();
                ClearInputs();
            }
            catch (SqlException ex) when (ex.Number == 547) // FK violation
            {
                MessageBox.Show("Cannot delete this status because it is used elsewhere.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedID == 0 || txtStatus.Text.Trim() == "") return;

            PaymentStatus status = new PaymentStatus(selectedID, txtStatus.Text.Trim());
            status.UPDATE();
            LoadData();
            ClearInputs();
        }

        private void dgvPaymentStatus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPaymentStatus.Rows[e.RowIndex];
                selectedID = Convert.ToInt32(row.Cells["PaymentStatusID"].Value);
                txtStatus.Text = row.Cells["PaymentStatus"].Value.ToString();

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void frmPaymentStatus_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
