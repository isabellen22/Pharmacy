using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Pharmacy.Classes;

namespace Pharmacy.Forms
{
    public partial class frmLaboratory : Form
    {
        private int selectedLabID = -1;
        private bool isRowSelectedByDoubleClick = false;
        private bool enableFiltering = true;

        public frmLaboratory()
        {
            InitializeComponent();

            dgvLaboratory.AutoGenerateColumns = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void frmLaboratory_Load(object sender, EventArgs e)
        {
            LoadLaboratories();
        }

        private void LoadLaboratories()
        {
            
            try
            {
                Laboratory lab = new Laboratory(0, "", "", "", "");
                DataTable dt = lab.SELECT();

                

                dgvLaboratory.AutoGenerateColumns = false;
                dgvLaboratory.DataSource = dt;

                dgvLaboratory.Columns["LaboratoryID"].DataPropertyName = "LaboratoryID";
                dgvLaboratory.Columns["LabName"].DataPropertyName = "LabName";
                dgvLaboratory.Columns["LabLocation"].DataPropertyName = "LabLocation";
                dgvLaboratory.Columns["LabContact"].DataPropertyName = "LabContactNB";
                dgvLaboratory.Columns["LabEmail"].DataPropertyName = "LabEmail";

                dgvLaboratory.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load laboratories.\n" + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtLocation.Clear();
            txtContact.Clear();
            txtEmail.Clear();

            selectedLabID = -1;
            isRowSelectedByDoubleClick = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || txtLocation.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in at least Lab Name and Location.");
                return;
            }

            Laboratory lab = new Laboratory(0, txtName.Text.Trim(), txtLocation.Text.Trim(), txtContact.Text.Trim(), txtEmail.Text.Trim());
            lab.INSERT();

            LoadLaboratories();
            ClearForm();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedLabID == -1)
            {
                MessageBox.Show("Please select a lab to update.");
                return;
            }

            Laboratory lab = new Laboratory(selectedLabID, txtName.Text.Trim(), txtLocation.Text.Trim(), txtContact.Text.Trim(), txtEmail.Text.Trim());
            lab.UPDATE();

            LoadLaboratories();
            ClearForm();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedLabID == -1)
            {
                MessageBox.Show("Please select a lab to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this lab?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    Laboratory lab = new Laboratory(selectedLabID, "", "", "", "");
                    lab.DELETE();

                    LoadLaboratories();
                    ClearForm();
                }
                catch (SqlException ex) when (ex.Message.Contains("REFERENCE constraint"))
                {
                    MessageBox.Show("This lab is assigned to other records. Cannot delete.", "Delete Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error: " + ex.Message);
                }

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnAdd.Enabled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLaboratories();
            ClearForm();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
            selectedLabID = -1;
            enableFiltering = true;
        }

       

        private void dgvLaboratory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvLaboratory.Rows[e.RowIndex];

            try
            {
                selectedLabID = Convert.ToInt32(row.Cells["LaboratoryID"].Value);
            }
            catch
            {
                MessageBox.Show("Could not retrieve Lab ID.");
                return;
            }

            txtName.Text = row.Cells["LabName"].Value?.ToString();
            txtLocation.Text = row.Cells["LabLocation"].Value?.ToString();
            txtContact.Text = row.Cells["LabContact"].Value?.ToString();
            txtEmail.Text = row.Cells["LabEmail"].Value?.ToString();

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

    }
}
