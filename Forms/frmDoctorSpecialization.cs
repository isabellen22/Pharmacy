
using Pharmacy.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
    public partial class frmDoctorSpecialization : Form
    {
        private int selectedID = -1;

        public frmDoctorSpecialization()
        {
            InitializeComponent();
            dgvSpecializations.AutoGenerateColumns = false;
        }

        private void frmDoctorSpecialization_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void frmDoctorSpecialization_FormClosed(object sender, FormClosedEventArgs e)
        {
            ResetSelection();
        }

        private void RefreshData()
        {
            DoctorsSpecialization ds = new DoctorsSpecialization(0, "", "");
            dgvSpecializations.DataSource = ds.SELECT();
            dgvSpecializations.ClearSelection();
            ResetSelection();
        }

        private void ResetSelection()
        {
            selectedID = -1;
            txtName.Clear();
            txtCategory.Clear();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void dgvSpecializations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedID = Convert.ToInt32(dgvSpecializations.Rows[e.RowIndex].Cells["SpecializationID"].Value);
                txtName.Text = dgvSpecializations.Rows[e.RowIndex].Cells["SpecializationName"].Value.ToString();
                txtCategory.Text = dgvSpecializations.Rows[e.RowIndex].Cells["SpecializationCategory"].Value.ToString();

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DoctorsSpecialization ds = new DoctorsSpecialization(0, txtName.Text.Trim(), txtCategory.Text.Trim());
            ds.INSERT();
            RefreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedID == -1) return;
            DoctorsSpecialization ds = new DoctorsSpecialization(selectedID, txtName.Text.Trim(), txtCategory.Text.Trim());
            ds.UPDATE();
            RefreshData();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Please select a specialization to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this specialization?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DoctorsSpecialization specialization = new DoctorsSpecialization(selectedID, "", "");
                    specialization.DELETE();

                    RefreshData();  // Reload DataGridView
                    ResetSelection();            // Clear inputs
                }
                catch (SqlException ex) when (ex.Message.Contains("REFERENCE constraint"))
                {
                    MessageBox.Show("Cannot delete this specialization because it is used by one or more doctors.", "Delete Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
            selectedID = -1;
        }
        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    if (selectedID == -1) return;
        //    DoctorsSpecialization ds = new DoctorsSpecialization(selectedID, "", "");
        //    ds.DELETE();
        //    RefreshData();
        //}

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
