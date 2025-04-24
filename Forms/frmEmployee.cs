using Pharmacy.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
    public partial class frmEmployee : Form
    {
        private int selectedEmployeeID = -1;
        private bool isSelectedByDoubleClick = false;

        public frmEmployee()
        {
            InitializeComponent();
            dgvEmployee.AutoGenerateColumns = false;
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            try
            {
                DataTable dt = new Employee().SELECT();
                dgvEmployee.DataSource = dt;
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee data.\n" + ex.Message);
            }
        }

        private void ResetForm()
        {
            selectedEmployeeID = -1;
            isSelectedByDoubleClick = false;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            dtpDOB.Value = DateTime.Now;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee
                {
                    EmployeeFirstName = txtFirstName.Text.Trim(),
                    EmployeeLastName = txtLastName.Text.Trim(),
                    EmployeeDOB = dtpDOB.Value,
                    EmployeeContactNB = txtContact.Text.Trim(),
                    EmployeeAddress = txtAddress.Text.Trim()
                };
                emp.INSERT();
                LoadEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee.\n" + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeID == -1 || !isSelectedByDoubleClick) return;

            try
            {
                Employee emp = new Employee
                {
                    EmployeeID = selectedEmployeeID,
                    EmployeeFirstName = txtFirstName.Text.Trim(),
                    EmployeeLastName = txtLastName.Text.Trim(),
                    EmployeeDOB = dtpDOB.Value,
                    EmployeeContactNB = txtContact.Text.Trim(),
                    EmployeeAddress = txtAddress.Text.Trim()
                };
                emp.UPDATE();
                LoadEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee.\n" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeID == -1 || !isSelectedByDoubleClick) return;

            var confirm = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                Employee emp = new Employee { EmployeeID = selectedEmployeeID };
                emp.DELETE();
                LoadEmployees();
            }
            catch (SqlException ex) when (ex.Number == 547) // FK constraint
            {
                MessageBox.Show("Cannot delete this employee because it is linked to other records.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting employee.\n" + ex.Message);
            }
        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];
            selectedEmployeeID = Convert.ToInt32(row.Cells["EmployeeID"].Value);
            txtFirstName.Text = row.Cells["EmployeeFirstName"].Value.ToString();
            txtLastName.Text = row.Cells["EmployeeLastName"].Value.ToString();
            dtpDOB.Value = Convert.ToDateTime(row.Cells["EmployeeDOB"].Value);
            txtContact.Text = row.Cells["EmployeeContact"].Value.ToString();
            txtAddress.Text = row.Cells["EmployeeAddress"].Value.ToString();

            isSelectedByDoubleClick = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }
    }
}