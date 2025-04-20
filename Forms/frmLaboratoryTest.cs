using Pharmacy.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
    public partial class frmLaboratoryTest : Form
    {
        private int selectedID = 0;

        public frmLaboratoryTest()
        {
            InitializeComponent();
            dgvTests.AutoGenerateColumns = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void frmLaboratoryTest_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            LaboratoryTest test = new LaboratoryTest(0, "", "", 0, 0, 0, 0);
            dgvTests.DataSource = test.SELECT();
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtDesc.Clear();
            txtPrice.Clear();
            txtMin.Clear();
            txtMax.Clear();
            txtUnit.Clear();

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
            if (!ValidateInputs()) return;

            LaboratoryTest test = new LaboratoryTest(
                0,
                txtName.Text.Trim(),
                txtDesc.Text.Trim(),
                decimal.Parse(txtPrice.Text),
                decimal.Parse(txtMin.Text),
                decimal.Parse(txtMax.Text),
                int.Parse(txtUnit.Text)
            );

            test.INSERT();
            LoadData();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedID == 0) return;

            try
            {
                LaboratoryTest test = new LaboratoryTest(selectedID, "", "", 0, 0, 0, 0);
                test.DELETE();
                LoadData();
                ClearInputs();
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("This test is currently in use and cannot be deleted.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedID == 0 || !ValidateInputs()) return;

            LaboratoryTest test = new LaboratoryTest(
                selectedID,
                txtName.Text.Trim(),
                txtDesc.Text.Trim(),
                decimal.Parse(txtPrice.Text),
                decimal.Parse(txtMin.Text),
                decimal.Parse(txtMax.Text),
                int.Parse(txtUnit.Text)
            );

            test.UPDATE();
            LoadData();
            ClearInputs();
        }

        private void dgvTests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTests.Rows[e.RowIndex].Cells["LabTestID"].Value != null)
            {
                DataGridViewRow row = dgvTests.Rows[e.RowIndex];

                selectedID = Convert.ToInt32(row.Cells["LabTestID"].Value);
                txtName.Text = row.Cells["LabTestName"].Value?.ToString();
                txtDesc.Text = row.Cells["LabTestDescription"].Value?.ToString();
                txtPrice.Text = row.Cells["LabTestPrice"].Value?.ToString();
                txtMin.Text = row.Cells["MinHealthyRange"].Value?.ToString();
                txtMax.Text = row.Cells["MaxHealthyRange"].Value?.ToString();
                txtUnit.Text = row.Cells["UnitID"].Value?.ToString();

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtMin.Text) ||
                string.IsNullOrWhiteSpace(txtMax.Text) ||
                string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out _) ||
                !decimal.TryParse(txtMin.Text, out _) ||
                !decimal.TryParse(txtMax.Text, out _) ||
                !int.TryParse(txtUnit.Text, out _))
            {
                MessageBox.Show("Invalid numeric values detected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void frmLaboratoryTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
