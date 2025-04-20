using Pharmacy.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
    public partial class frmUsers : Form
    {
        bool isUserSelectedByDoubleClick = false;
        bool enableFiltering = true;
        private int selectedID = -1;

        public frmUsers()
        {
            InitializeComponent();
            dgvUsers.AutoGenerateColumns = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            Role roles = new Role();
            DataTable rolesTable = roles.SELECT();
            cmbRole.DataSource = rolesTable;
            cmbRole.DisplayMember = "RoleName";
            cmbRole.ValueMember = "RoleID";

            UsersPasswords load = new UsersPasswords();
            DataTable usersTable = load.SELECT();

            if (!usersTable.Columns.Contains("RoleName"))
                usersTable.Columns.Add("RoleName", typeof(string));

            foreach (DataRow row in usersTable.Rows)
            {
                int roleId = Convert.ToInt32(row["RoleID"]);
                DataRow[] match = rolesTable.Select($"RoleID = {roleId}");
                if (match.Length > 0)
                    row["RoleName"] = match[0]["RoleName"].ToString();
            }

            dgvUsers.DataSource = usersTable;
            cmbRole.SelectedIndex = 0;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (!enableFiltering) return;
            string searchText = txtUserName.Text.Trim().ToLower();
            if (dgvUsers.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"UserName LIKE '%{searchText}%'";
                dgvUsers.DataSource = dv.ToTable();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!enableFiltering) return;
            string searchText = txtEmail.Text.Trim().ToLower();
            if (dgvUsers.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"Email LIKE '%{searchText}%'";
                dgvUsers.DataSource = dv.ToTable();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();
                int roleID = Convert.ToInt32(cmbRole.SelectedValue);

                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(password) || roleID == 0)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UsersPasswords newUser = new UsersPasswords(0, userName, email, password, roleID);
                DataTable insertedTable = newUser.INSERT();

                if (!insertedTable.Columns.Contains("RoleName"))
                    insertedTable.Columns.Add("RoleName", typeof(string));

                foreach (DataRow row in insertedTable.Rows)
                {
                    int id = Convert.ToInt32(row["RoleID"]);
                    DataRow[] match = ((DataTable)cmbRole.DataSource).Select($"RoleID = {id}");
                    if (match.Length > 0)
                        row["RoleName"] = match[0]["RoleName"].ToString();
                }

                dgvUsers.DataSource = insertedTable;
                txtUserName.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
                cmbRole.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                enableFiltering = true;

                var confirm = MessageBox.Show(
                    "Are you sure you want to delete this user?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm != DialogResult.Yes)
                    return;

                if (!isUserSelectedByDoubleClick || selectedID == -1)
                {
                    MessageBox.Show("No user selected to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UsersPasswords userToDelete = new UsersPasswords(selectedID);
                DataTable deletedTable = userToDelete.DELETE();

                if (!deletedTable.Columns.Contains("RoleName"))
                    deletedTable.Columns.Add("RoleName", typeof(string));

                foreach (DataRow row in deletedTable.Rows)
                {
                    int id = Convert.ToInt32(row["RoleID"]);
                    DataRow[] match = ((DataTable)cmbRole.DataSource).Select($"RoleID = {id}");
                    if (match.Length > 0)
                        row["RoleName"] = match[0]["RoleName"].ToString();
                }

                dgvUsers.DataSource = deletedTable;

                txtUserName.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
                cmbRole.SelectedIndex = 0;

                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnAdd.Enabled = true;
                isUserSelectedByDoubleClick = false;
                selectedID = -1;
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("This user is still referenced in other records and cannot be deleted.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


      
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                enableFiltering = true;
                if (!isUserSelectedByDoubleClick || selectedID == -1)
                    return;

                string userName = txtUserName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();
                int roleID = Convert.ToInt32(cmbRole.SelectedValue);

                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || roleID == 0)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UsersPasswords userToUpdate = new UsersPasswords(selectedID, userName, email, password, roleID);
                DataTable updatedTable = userToUpdate.UPDATE();

                if (!updatedTable.Columns.Contains("RoleName"))
                    updatedTable.Columns.Add("RoleName", typeof(string));

                foreach (DataRow row in updatedTable.Rows)
                {
                    int id = Convert.ToInt32(row["RoleID"]);
                    DataRow[] match = ((DataTable)cmbRole.DataSource).Select($"RoleID = {id}");
                    if (match.Length > 0)
                        row["RoleName"] = match[0]["RoleName"].ToString();
                }

                dgvUsers.DataSource = updatedTable;
                txtUserName.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
                cmbRole.SelectedIndex = 0;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnAdd.Enabled = true;
                isUserSelectedByDoubleClick = false;
                selectedID = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UsersPasswords user = new UsersPasswords();
            DataTable refreshedTable = user.SELECT();

            if (!refreshedTable.Columns.Contains("RoleName"))
                refreshedTable.Columns.Add("RoleName", typeof(string));

            foreach (DataRow row in refreshedTable.Rows)
            {
                int id = Convert.ToInt32(row["RoleID"]);
                DataRow[] match = ((DataTable)cmbRole.DataSource).Select($"RoleID = {id}");
                if (match.Length > 0)
                    row["RoleName"] = match[0]["RoleName"].ToString();
            }

            dgvUsers.DataSource = refreshedTable;
            txtUserName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = 0;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
            isUserSelectedByDoubleClick = false;
            selectedID = -1;
            enableFiltering = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedID = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["UserID"].Value);
                string userName = dgvUsers.Rows[e.RowIndex].Cells["UserName"].Value?.ToString();
                string email = dgvUsers.Rows[e.RowIndex].Cells["Email"].Value?.ToString();
                string password = dgvUsers.Rows[e.RowIndex].Cells["Password"].Value?.ToString();
                int roleID = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["RoleID"].Value);

                if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(email))
                {
                    txtUserName.Text = userName;
                    txtEmail.Text = email;
                    txtPassword.Text = password;
                    cmbRole.SelectedValue = roleID;

                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnAdd.Enabled = false;

                    isUserSelectedByDoubleClick = true;
                    enableFiltering = false;
                }
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedIndex == 0 || !enableFiltering)
                return;

            if (cmbRole.SelectedValue != null)
            {
                int selectedRoleId;

                if (cmbRole.SelectedValue is DataRowView drv)
                {
                    selectedRoleId = Convert.ToInt32(drv["RoleID"]);
                }
                else if (!int.TryParse(cmbRole.SelectedValue.ToString(), out selectedRoleId))
                {
                    return;
                }

                if (dgvUsers.DataSource is DataTable dt)
                {
                    DataView dv = dt.DefaultView;
                    dv.RowFilter = selectedRoleId == 0 ? "" : $"RoleID = {selectedRoleId}";
                    dgvUsers.DataSource = dv.ToTable();
                }
            }
        }
    }
}