using Pharmacy.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
    public partial class frmSupplier : Form
    {
        int selectedSupplierID = -1;

        public frmSupplier()
        {
            InitializeComponent();
            dgvSupplier.AutoGenerateColumns = false;
            dgvSupplier.AllowUserToResizeColumns = false;
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            dgvSupplier.Columns["colSupplierID"].DataPropertyName = "SupplierID";
            dgvSupplier.Columns["colSupplierName"].DataPropertyName = "SupplierName";
            dgvSupplier.Columns["colSupplierEmail"].DataPropertyName = "SupplierEmail";
            dgvSupplier.Columns["colSupplierContactNB"].DataPropertyName = "SupplierContactNB";
            dgvSupplier.Columns["colCountryName"].DataPropertyName = "CountryName";
            dgvSupplier.Columns["colSupplierID"].Visible = false;
           

            LoadCountries();
            LoadSuppliers();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadCountries()
        {
            try
            {
                cmbCountry.DisplayMember = "CountryName";
                cmbCountry.ValueMember = "CountryID";
                cmbCountry.DataSource = new Country().SELECT();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading countries: {ex.Message}");
            }
        }

        private void LoadSuppliers()
        {
            try
            {
                DataTable supplierTable = new Supplier().SELECT();
                DataTable countryTable = new Country().SELECT();

                // Add CountryName column if it doesn't exist
                if (!supplierTable.Columns.Contains("CountryName"))
                    supplierTable.Columns.Add("CountryName", typeof(string));

                // Fill CountryName column
                foreach (DataRow supplierRow in supplierTable.Rows)
                {
                    int countryID = Convert.ToInt32(supplierRow["CountryID"]);
                    DataRow[] matchingCountries = countryTable.Select("CountryID = " + countryID);

                    if (matchingCountries.Length > 0)
                        supplierRow["CountryName"] = matchingCountries[0]["CountryName"].ToString();
                }

                dgvSupplier.AutoGenerateColumns = false; // if you're customizing columns manually
                dgvSupplier.DataSource = supplierTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            selectedSupplierID = -1;
            txtName.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            cmbCountry.SelectedIndex = -1;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSuppliers();
            ClearForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || cmbCountry.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            Supplier supplier = new Supplier
            {
                SupplierName = txtName.Text.Trim(),
                SupplierEmail = txtEmail.Text.Trim(),
                SupplierContactNB = txtContact.Text.Trim(),
                CountryID = Convert.ToInt32(cmbCountry.SelectedValue)
            };

            supplier.INSERT();
            LoadSuppliers();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSupplierID == -1)
                return;

            Supplier supplier = new Supplier
            {
                SupplierID = selectedSupplierID,
                SupplierName = txtName.Text.Trim(),
                SupplierEmail = txtEmail.Text.Trim(),
                SupplierContactNB = txtContact.Text.Trim(),
                CountryID = Convert.ToInt32(cmbCountry.SelectedValue)
            };

            supplier.UPDATE();
            LoadSuppliers();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSupplierID == -1)
                return;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            Supplier supplier = new Supplier { SupplierID = selectedSupplierID };
            supplier.DELETE();

            LoadSuppliers();
            ClearForm();
        }

        private void dgvSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSupplier.Rows[e.RowIndex];

                selectedSupplierID = Convert.ToInt32(row.Cells["colSupplierID"].Value);
                txtName.Text = row.Cells["colSupplierName"].Value.ToString();
                txtEmail.Text = row.Cells["colSupplierEmail"].Value.ToString();
                txtContact.Text = row.Cells["colSupplierContactNB"].Value.ToString();
                cmbCountry.Text = row.Cells["colCountryName"].Value.ToString();

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }



    }
}
