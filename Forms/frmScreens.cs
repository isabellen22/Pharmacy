using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
    public partial class frmScreens : Form
    {

        bool isScreenSelectedByDoubleClick = false;
        bool enablefiltering = true;

        public frmScreens()
        {
            InitializeComponent();
            dgvScreens.AutoGenerateColumns = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string screenName = txtScreenName.Text.Trim(); // Get the role name from the text box
                string screenURL = txtScreenURL.Text.Trim();

                if (string.IsNullOrEmpty(screenName) || string.IsNullOrEmpty(screenURL))
                    return;


                Classes.Screen newScreen = new Classes.Screen(0, screenName, screenURL);
                dgvScreens.DataSource = newScreen.INSERT();


                txtScreenName.Clear();
                txtScreenURL.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmScreens_Load(object sender, EventArgs e)
        {
            Classes.Screen load = new Classes.Screen();
            dgvScreens.DataSource = load.SELECT();



        }

        private void dgvScreens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dgvScreens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Check if the clicked cell is within the "RoleName" column
                string screenName = dgvScreens.Rows[e.RowIndex].Cells[0].Value?.ToString();
                string screenURL = dgvScreens.Rows[e.RowIndex].Cells[1].Value?.ToString();

                if (!string.IsNullOrEmpty(screenName) && !string.IsNullOrEmpty(screenURL))
                {


                    txtScreenName.Text = screenName;
                    txtScreenURL.Text = screenURL;

                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnAdd.Enabled = false;

                    isScreenSelectedByDoubleClick = true;

                    enablefiltering = false;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            enablefiltering = true;
            if (!isScreenSelectedByDoubleClick || string.IsNullOrEmpty(txtScreenName.Text.Trim()) || string.IsNullOrEmpty(txtScreenURL.Text.Trim()))
                return;

            if (dgvScreens.CurrentRow == null || dgvScreens.CurrentRow.IsNewRow)
                return;



            string screenName = txtScreenName.Text.Trim(); // Get the role name from the text box
            string screenURL = txtScreenURL.Text.Trim();

            if (string.IsNullOrEmpty(screenName) || string.IsNullOrEmpty(screenURL))
                return;

            // Get RoleID directly from the selected row
            int screenId = Convert.ToInt32(dgvScreens.CurrentRow.Cells["ScreenID"].Value);

            // Delete the role
            Classes.Screen screenToDelete = new Classes.Screen(screenId);
            dgvScreens.DataSource = screenToDelete.DELETE();


            txtScreenName.Clear();
            txtScreenURL.Clear();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;


            isScreenSelectedByDoubleClick = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            enablefiltering = true;
            if (!isScreenSelectedByDoubleClick || string.IsNullOrEmpty(txtScreenName.Text.Trim()) || string.IsNullOrEmpty(txtScreenURL.Text.Trim()))
                return;

            if (dgvScreens.CurrentRow == null || dgvScreens.CurrentRow.IsNewRow)
                return;



            string screenName = txtScreenName.Text.Trim(); // Get the role name from the text box
            string screenURL = txtScreenURL.Text.Trim();

            if (string.IsNullOrEmpty(screenName) || string.IsNullOrEmpty(screenURL))
                return;

            int screenId = Convert.ToInt32(dgvScreens.CurrentRow.Cells["ScreenID"].Value);

            Classes.Screen screenToUpdate = new Classes.Screen(screenId, screenName, screenURL);
            dgvScreens.DataSource = screenToUpdate.UPDATE();  // This is your method that should handle updating the DB

            txtScreenName.Clear();
            txtScreenURL.Clear();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
            isScreenSelectedByDoubleClick = false;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Classes.Screen load = new Classes.Screen();
            dgvScreens.DataSource = load.SELECT();

            txtScreenName.Clear();
            txtScreenURL.Clear();

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;

            isScreenSelectedByDoubleClick = false;
            enablefiltering = true;

        }

        private void txtScreenName_TextChanged(object sender, EventArgs e)
        {
            if (!enablefiltering)
            {
                return;
            }

            string searchText = txtScreenName.Text.Trim().ToLower();
            if (dgvScreens.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;

                dv.RowFilter = $"ScreenName LIKE '%{searchText}%'";

                dgvScreens.DataSource = dv.ToTable();
            }

        }

        private void txtScreenURL_TextChanged(object sender, EventArgs e)
        {
            if (!enablefiltering)
            {
                return;
            }

            string searchText = txtScreenURL.Text.Trim().ToLower();

            // If the DataSource is a DataTable, use a DataView to filter the DataTable
            if (dgvScreens.DataSource is DataTable dt)
            {
                // Create a DataView to filter the DataTable
                DataView dv = dt.DefaultView;

                // Apply the filter condition
                dv.RowFilter = $"ScreenURL LIKE '%{searchText}%'";

                // Set the DataView as the DataSource of the DataGridView
                dgvScreens.DataSource = dv.ToTable();
            }
        }


        // formin vra gokhe design ge pana, properties, key, keydown 
        //private void frmScreens_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
        //    {
        //        this.SelectNextControl((Control)sender, true, true, true, true);
        //    }
        //}

    }
}
