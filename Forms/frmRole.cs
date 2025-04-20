using System;
using System.Data;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
    public partial class frmRole : Form
    {
        private bool isRoleSelectedByDoubleClick = false;
        private bool enablefiltering = true;

        public frmRole()
        {
            InitializeComponent();
            dgvRole.AutoGenerateColumns = false;
            btnDeleteRole.Enabled = false;
            btnUpdateRole.Enabled = false;
        }

        private void frmRole_Load(object sender, EventArgs e)
        {
            Classes.Role load = new Classes.Role();
            dgvRole.DataSource = load.SELECT();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            try
            {
                string roleName = txtRoleName.Text.Trim();

                if (string.IsNullOrEmpty(roleName))
                    return;

                Classes.Role newRole = new Classes.Role(0, roleName);
                dgvRole.DataSource = newRole.INSERT();

                txtRoleName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRoleName_TextChanged(object sender, EventArgs e)
        {
            if (!enablefiltering) return;

            string searchText = txtRoleName.Text.Trim().ToLower();
            if (dgvRole.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"RoleName LIKE '%{searchText}%'";
                dgvRole.DataSource = dv.ToTable();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvRole_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string roleName = dgvRole.Rows[e.RowIndex].Cells[0].Value?.ToString();

                if (!string.IsNullOrEmpty(roleName))
                {
                    txtRoleName.Text = roleName;
                    btnUpdateRole.Enabled = true;
                    btnDeleteRole.Enabled = true;
                    isRoleSelectedByDoubleClick = true;
                    enablefiltering = false;
                }
            }
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            enablefiltering = true;
            if (!isRoleSelectedByDoubleClick || string.IsNullOrEmpty(txtRoleName.Text.Trim()))
                return;

            if (dgvRole.CurrentRow == null || dgvRole.CurrentRow.IsNewRow)
                return;

            string roleName = txtRoleName.Text.Trim();

            if (string.IsNullOrEmpty(roleName))
                return;

            int roleId = Convert.ToInt32(dgvRole.CurrentRow.Cells["RoleID"].Value);
            Classes.Role roleToDelete = new Classes.Role(roleId);
            dgvRole.DataSource = roleToDelete.DELETE();

            txtRoleName.Clear();
            btnDeleteRole.Enabled = false;
            btnUpdateRole.Enabled = false;
            btnAddRole.Enabled = true;
            isRoleSelectedByDoubleClick = false;
        }

        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            enablefiltering = true;
            if (!isRoleSelectedByDoubleClick || string.IsNullOrEmpty(txtRoleName.Text.Trim()))
                return;

            if (dgvRole.CurrentRow == null || dgvRole.CurrentRow.IsNewRow)
                return;

            string roleName = txtRoleName.Text.Trim();
            if (string.IsNullOrEmpty(roleName))
                return;

            int roleId = Convert.ToInt32(dgvRole.CurrentRow.Cells["RoleID"].Value);
            Classes.Role roleToUpdate = new Classes.Role(roleId, roleName);
            dgvRole.DataSource = roleToUpdate.UPDATE();

            txtRoleName.Clear();
            btnDeleteRole.Enabled = false;
            btnUpdateRole.Enabled = false;
            btnAddRole.Enabled = true;
            isRoleSelectedByDoubleClick = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Classes.Role load = new Classes.Role();
            dgvRole.DataSource = load.SELECT();

            txtRoleName.Clear();
            btnDeleteRole.Enabled = false;
            btnUpdateRole.Enabled = false;
            btnAddRole.Enabled = true;
            isRoleSelectedByDoubleClick = false;
            enablefiltering = true;
        }

      

        private void dgvRole_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Check if the clicked cell is within the "RoleName" column
                string roleName = dgvRole.Rows[e.RowIndex].Cells[0].Value?.ToString();
                // string screenURL = dgvRole.Rows[e.RowIndex].Cells[1].Value?.ToString();

                if (!string.IsNullOrEmpty(roleName))
                {


                    txtRoleName.Text = roleName;

                    btnUpdateRole.Enabled = true;
                    btnDeleteRole.Enabled = true;
                    btnAddRole.Enabled = false;

                    isRoleSelectedByDoubleClick = true;

                    enablefiltering = false;
                }
            }
        }
    }
}
