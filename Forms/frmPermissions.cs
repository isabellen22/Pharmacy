
using Pharmacy.Classes.UsefullClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
    public partial class frmPermissions : Form
    {
        private bool isPermissionSelectedByDoubleClick = false;
        private bool enableFiltering = true;


        public frmPermissions()
        {
            InitializeComponent();
            dgvPermissions.AutoGenerateColumns = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true; 
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedIndex == 0 && cmbScreen.SelectedIndex == 0)
                return;
            FilterPermissions();
        }

        private void frmPermissions_Load(object sender, EventArgs e)
        {


            Classes.Permission load = new Classes.Permission();
            dgvPermissions.DataSource = load.SELECT();


            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectionString.Value))
            {
                string query = "SELECT RoleID, RoleName FROM tblRole";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                conn.Open();
                adapter.Fill(dt);
                conn.Close();

                cmbRole.DataSource = dt;
                cmbRole.DisplayMember = "RoleName";
                cmbRole.ValueMember = "RoleID";
            }



            DataTable dtScreens = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectionString.Value))
            {
                string queryScreens = "SELECT ScreenID, ScreenName FROM tblScreens";
                SqlCommand cmdScreens = new SqlCommand(queryScreens, conn);
                SqlDataAdapter adapterScreens = new SqlDataAdapter(cmdScreens);

                conn.Open();
                adapterScreens.Fill(dtScreens);
                conn.Close();

                cmbScreen.DataSource = dtScreens;
                cmbScreen.DisplayMember = "ScreenName";
                cmbScreen.ValueMember = "ScreenID";
            }

        }

        private void smbScreen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedIndex == 0 && cmbScreen.SelectedIndex == 0)
                return;

            FilterPermissions();
        }



        private void FilterPermissions()
        {
            if (!enableFiltering)
                return;

            try
            {
                // Ensure the DataGridView has a valid DataTable source
                if (dgvPermissions.DataSource is DataTable dt)
                {
                    // Create a DataView from the DataTable
                    DataView dv = dt.DefaultView;

                    // Prepare filter string
                    List<string> filters = new List<string>();

                    // Check Role filter
                    if (cmbRole.SelectedValue != null)
                    {
                        if (int.TryParse(cmbRole.SelectedValue.ToString(), out int roleId))
                        {
                            filters.Add($"RoleID = {roleId}");
                        }
                    }

                    // Check Screen filter
                    if (cmbScreen.SelectedValue != null)
                    {
                        if (int.TryParse(cmbScreen.SelectedValue.ToString(), out int screenId))
                        {
                            filters.Add($"ScreenID = {screenId}");
                        }
                    }


                    // Apply filter
                    dv.RowFilter = filters.Count > 0 ? string.Join(" AND ", filters) : string.Empty;
                    dgvPermissions.DataSource = dv.ToTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering permissions: {ex.Message}", "Filtering Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void dgvPermissions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbCanView_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbCanEdit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbCanAdd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbCanDelete_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!isPermissionSelectedByDoubleClick)
                return;

            if (dgvPermissions.CurrentRow == null || dgvPermissions.CurrentRow.IsNewRow)
                return;

            int roleId = Convert.ToInt32(cmbRole.SelectedValue);
            int screenId = Convert.ToInt32(cmbScreen.SelectedValue);

            Classes.Permission permissionToUpdate = new Classes.Permission(
                roleId,
                screenId,
                Convert.ToByte(cbCanView.Checked),
                  Convert.ToByte(cbCanAdd.Checked),
                  Convert.ToByte(cbCanEdit.Checked),
                 Convert.ToByte(cbCanDelete.Checked)
            );

            dgvPermissions.DataSource = permissionToUpdate.UPDATE();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!isPermissionSelectedByDoubleClick)
                return;

            if (dgvPermissions.CurrentRow == null || dgvPermissions.CurrentRow.IsNewRow)
                return;

            int screenId = Convert.ToInt32(dgvPermissions.CurrentRow.Cells["screenID"].Value);
            int roleId = Convert.ToInt32(dgvPermissions.CurrentRow.Cells["roleID"].Value);

            Classes.Permission permissionToDelete = new Classes.Permission(roleId, screenId);
            dgvPermissions.DataSource = permissionToDelete.DELETE();

            ClearInputs();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRole.SelectedValue == null || cmbScreen.SelectedValue == null)
                    return;

                int roleId = Convert.ToInt32(cmbRole.SelectedValue);
                int screenId = Convert.ToInt32(cmbScreen.SelectedValue);

                Classes.Permission newPermission = new Classes.Permission(
                    roleId,
                    screenId,
                    Convert.ToByte(cbCanView.Checked),
                     Convert.ToByte(cbCanEdit.Checked),
                    Convert.ToByte(cbCanDelete.Checked),
                    Convert.ToByte(cbCanAdd.Checked)

                );

                dgvPermissions.DataSource = newPermission.INSERT();

                // Clear inputs
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            enableFiltering = true;
            dgvPermissions.DataSource = null;
            Classes.Permission load = new Classes.Permission();
            dgvPermissions.DataSource = load.SELECT();

            ClearInputs();
        }

        private void dgvPermissions_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int roleId = Convert.ToInt32(dgvPermissions.Rows[e.RowIndex].Cells["RoleID"].Value);
                int screenId = Convert.ToInt32(dgvPermissions.Rows[e.RowIndex].Cells["ScreenID"].Value);
                bool canView = Convert.ToBoolean(dgvPermissions.Rows[e.RowIndex].Cells["CanView"].Value);
                bool canAdd = Convert.ToBoolean(dgvPermissions.Rows[e.RowIndex].Cells["CanAdd"].Value);
                bool canEdit = Convert.ToBoolean(dgvPermissions.Rows[e.RowIndex].Cells["CanEdit"].Value);
                bool canDelete = Convert.ToBoolean(dgvPermissions.Rows[e.RowIndex].Cells["CanDelete"].Value);

                // Set dropdown selections
                cmbRole.SelectedValue = roleId;
                cmbScreen.SelectedValue = screenId;

                // Set checkboxes
                cbCanView.Checked = canView;
                cbCanAdd.Checked = canAdd;
                cbCanEdit.Checked = canEdit;
                cbCanDelete.Checked = canDelete;

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;

                isPermissionSelectedByDoubleClick = true;
                enableFiltering = false;
            }
        }

        private void ClearInputs()
        {
            cbCanView.Checked = false;
            cbCanAdd.Checked = false;
            cbCanEdit.Checked = false;
            cbCanDelete.Checked = false;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;

            isPermissionSelectedByDoubleClick = false;
            enableFiltering = true;

            cmbRole.SelectedIndex = 0;
            cmbScreen.SelectedIndex = 0;

        }


    }
}
