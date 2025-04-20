using Pharmacy.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
    public partial class frmCountry : Form
    {
        int selectedCountryID = -1;
        bool isCountrySelectedByDoubleClick = false;
        bool enablefiltering = true;
        public frmCountry()
        {
            InitializeComponent(); 

            dgvCountries.AutoGenerateColumns = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void LoadCountries()
        {
            try
            {
                
                Country country = new Country(0, "", "");
                DataTable dt = country.SELECT();

                dgvCountries.AutoGenerateColumns = false;
                dgvCountries.DataSource = dt;

               
                dgvCountries.Columns["CountryID"].DataPropertyName = "CountryID";
                dgvCountries.Columns["CountryName"].DataPropertyName = "CountryName";
                dgvCountries.Columns["CountryCode"].DataPropertyName = "CountryCode";

                dgvCountries.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load countries.\n" + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtCountryName.Clear();
            txtCountryCode.Clear();
            selectedCountryID = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCountryName.Text.Trim() == "" || txtCountryCode.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }

            Country country = new Country(0, txtCountryName.Text.Trim(), txtCountryCode.Text.Trim());
            country.INSERT();
            LoadCountries();
            ClearForm();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            isCountrySelectedByDoubleClick = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCountryID == -1)
            {
                MessageBox.Show("Please select a country to update.");
                return;
            }

            Country country = new Country(selectedCountryID, txtCountryName.Text.Trim(), txtCountryCode.Text.Trim());
            country.UPDATE();
            LoadCountries();
            ClearForm();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            isCountrySelectedByDoubleClick = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCountryID == -1)
            {
                MessageBox.Show("Please select a country to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this country?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Country country = new Country(selectedCountryID, "", "");
                    country.DELETE(); 

                    LoadCountries();
                    ClearForm();
                }
                catch (SqlException ex) when (ex.Message.Contains("REFERENCE constraint"))
                {
                    MessageBox.Show("Cannot delete this country because it is assigned to one or more doctors.", "Delete Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error: " + ex.Message);
                }
            }

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
            isCountrySelectedByDoubleClick = false;
        }

     

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCountries();
            ClearForm();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
            selectedCountryID = -1;
        }

        private void txtCountryName_TextChanged(object sender, EventArgs e)
        {
            if (!enablefiltering) return;

            string searchText = txtCountryName.Text.Trim().ToLower();

            if (dgvCountries.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"CountryName LIKE '%{searchText}%'";
                dgvCountries.DataSource = dv;
            }
            else if (dgvCountries.DataSource is DataView dvExisting)
            {
                dvExisting.RowFilter = $"CountryName LIKE '%{searchText}%'";
                dgvCountries.DataSource = dvExisting;
            }
        }

        private void txtCountryCode_TextChanged(object sender, EventArgs e)
        {
            if (!enablefiltering) return;

            string searchText = txtCountryCode.Text.Trim().ToLower();

            if (dgvCountries.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"CountryCode LIKE '%{searchText}%'";
                dgvCountries.DataSource = dv;
            }
            else if (dgvCountries.DataSource is DataView dvExisting)
            {
                dvExisting.RowFilter = $"CountryCode LIKE '%{searchText}%'";
                dgvCountries.DataSource = dvExisting;
            }
        }


        private void dgvCountries_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvCountries.Rows[e.RowIndex];

            string countryName = row.Cells["CountryName"].Value?.ToString();
            string countryCode = row.Cells["CountryCode"].Value?.ToString();

           
            try
            {
                selectedCountryID = Convert.ToInt32(row.Cells["CountryID"].Value); 
            }
            catch
            {
                MessageBox.Show("Could not retrieve CountryID for selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(countryName))
            {
                txtCountryName.Text = countryName;
                txtCountryCode.Text = countryCode;

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;

                isCountrySelectedByDoubleClick = true;
                enablefiltering = false;
            }
        }
      
        private void frmCountry_Load(object sender, EventArgs e)
        {
            LoadCountries();
        }

        private void frmCountry_FormClosed(object sender, FormClosedEventArgs e)
        {
          //  ((frmMDI)this.MdiParent).UpdateWindowsMenu();
        }
    }
}
