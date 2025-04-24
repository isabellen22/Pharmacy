using Pharmacy.Classes;
using System;
using System.Collections.Generic;

using System.Data;

using System.Windows.Forms;

namespace Pharmacy.Forms
{
    public partial class frmClients : Form
    {
        bool isClientSelectedByDoubleClick = false;
        bool enableFiltering = true;

        private DataTable dtClients;
        private DataTable dtCountries;

        public frmClients()
        {
            InitializeComponent();
            
            dgvClients.AutoGenerateColumns = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void lblCountyID_Click(object sender, EventArgs e)
        {

        }
        private void frmClients_Load(object sender, EventArgs e)
        {
            LoadClientsWithCountryNames();
            this.Text = "Clients";
            cmbCountry.DataSource = dtCountries;
            cmbCountry.DisplayMember = "CountryName";
            cmbCountry.ValueMember = "CountryID";

            cmbCountry.SelectedIndex = 0;

            UpdateClientCount();
        }
       
        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCountry.SelectedIndex == 0 )
                return;
            if (!enableFiltering)
            {
                return;
            }

            if (cmbCountry.SelectedValue != null)
            {
                int selectedCountryId;

                if (cmbCountry.SelectedValue is DataRowView drv)
                {
                  
                    selectedCountryId = Convert.ToInt32(drv["CountryID"]); 
                }
                else
                {
                  
                    try
                    {
                        selectedCountryId = Convert.ToInt32(cmbCountry.SelectedValue);
                    }
                    catch
                    {
                       
                        return;
                    }
                }

                if (dgvClients.DataSource is DataTable dt)
                {
                    DataView dv = dt.DefaultView;

                
                    if (selectedCountryId == 0)
                    {
                        dv.RowFilter = "";
                    }
                    else
                    {
                        dv.RowFilter = $"CountryID = {selectedCountryId}";
                    }

                    dgvClients.DataSource = dv.ToTable();
                }
            }
        }


        private void txtClientFirstName_TextChanged(object sender, EventArgs e)
        {
            if (!enableFiltering)
            {
                return;
            }
            string searchText = txtClientFirstName.Text.Trim().ToLower();
            if (dgvClients.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"ClientFirstName LIKE '%{searchText}%'";
                dgvClients.DataSource = dv.ToTable();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string clientFirstName = txtClientFirstName.Text.Trim();
                string clientLastName = txtClientLastName.Text.Trim();
                string clientAddress = txtClientAddress.Text.Trim();
                string clientContactNB = txtClientContactNB.Text.Trim();
                int countryID = Convert.ToInt32(cmbCountry.SelectedValue);  
                // Check if any required fields are empty
                if (string.IsNullOrEmpty(clientFirstName) || string.IsNullOrEmpty(clientLastName) ||
                    string.IsNullOrEmpty(clientAddress) || string.IsNullOrEmpty(clientContactNB) || countryID == 0)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Client newClient = new Client(0, clientFirstName, clientLastName, clientAddress, clientContactNB, countryID);
                newClient.INSERT();
                LoadClientsWithCountryNames();
                UpdateClientCount();

                txtClientFirstName.Clear();
                txtClientLastName.Clear();
                txtClientAddress.Clear();
                txtClientContactNB.Clear();
                cmbCountry.SelectedIndex = 0;


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

                if (!isClientSelectedByDoubleClick || string.IsNullOrEmpty(txtClientFirstName.Text.Trim()) || string.IsNullOrEmpty(txtClientLastName.Text.Trim()))
                    return;

                if (dgvClients.CurrentRow == null || dgvClients.CurrentRow.IsNewRow)
                    return;

                string clientFirstName = txtClientFirstName.Text.Trim();
                string clientLastName = txtClientLastName.Text.Trim();
                string clientAddress = txtClientAddress.Text.Trim();
                string clientContactNB = txtClientContactNB.Text.Trim();
                int countryID = Convert.ToInt32(cmbCountry.SelectedValue);



                int clientId = Convert.ToInt32(dgvClients.CurrentRow.Cells["ClientID"].Value);


                Client clientToDelete = new Client(clientId); 
                clientToDelete.DELETE();

                LoadClientsWithCountryNames();
                UpdateClientCount();
                txtClientFirstName.Clear();
                    txtClientLastName.Clear();
                    txtClientAddress.Clear();
                    txtClientContactNB.Clear();
                    cmbCountry.SelectedIndex = 0;  

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnAdd.Enabled = true;

                    isClientSelectedByDoubleClick = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string clientFirstName = dgvClients.Rows[e.RowIndex].Cells["ClientFirstName"].Value?.ToString();
                string clientLastName = dgvClients.Rows[e.RowIndex].Cells["ClientLastName"].Value?.ToString();
                string clientAddress = dgvClients.Rows[e.RowIndex].Cells["ClientAddress"].Value?.ToString();
                string clientContactNB = dgvClients.Rows[e.RowIndex].Cells["ClientContactNB"].Value?.ToString();
                int countryID = Convert.ToInt32(dgvClients.Rows[e.RowIndex].Cells["CountryID"].Value); // If this column exists

                if (!string.IsNullOrEmpty(clientFirstName) && !string.IsNullOrEmpty(clientLastName))
                {
                    txtClientFirstName.Text = clientFirstName;
                    txtClientLastName.Text = clientLastName;
                    txtClientAddress.Text = clientAddress;
                    txtClientContactNB.Text = clientContactNB;
                    cmbCountry.SelectedValue = countryID;

                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnAdd.Enabled = false;

                    isClientSelectedByDoubleClick = true;
                    enableFiltering = false;
                }
            }
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                enableFiltering = true;
                if (!isClientSelectedByDoubleClick )
                    return;
                // Check if a client is selected in the grid
                if (dgvClients.CurrentRow == null || dgvClients.CurrentRow.IsNewRow)
                    return;

                // Get values from text fields
                string clientFirstName = txtClientFirstName.Text.Trim();
                string clientLastName = txtClientLastName.Text.Trim();
                string clientAddress = txtClientAddress.Text.Trim();
                string clientContactNB = txtClientContactNB.Text.Trim();
                int countryID = Convert.ToInt32(cmbCountry.SelectedValue);

                // Check if any required fields are empty
                if (string.IsNullOrEmpty(clientFirstName) || string.IsNullOrEmpty(clientLastName) ||
                    string.IsNullOrEmpty(clientAddress) || string.IsNullOrEmpty(clientContactNB) || countryID == 0)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int clientId = Convert.ToInt32(dgvClients.CurrentRow.Cells["ClientID"].Value);
                Client clientToUpdate = new Client(clientId, clientFirstName, clientLastName, clientAddress, clientContactNB, countryID);
                clientToUpdate.UPDATE();

                LoadClientsWithCountryNames();
                    
                txtClientFirstName.Clear();
                txtClientLastName.Clear();
                txtClientAddress.Clear();
                txtClientContactNB.Clear();
                cmbCountry.SelectedIndex = 0;

                 btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnAdd.Enabled = true;
                isClientSelectedByDoubleClick = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            LoadClientsWithCountryNames();

            txtClientFirstName.Clear();
            txtClientLastName.Clear();
            txtClientAddress.Clear();
            txtClientContactNB.Clear();
            cmbCountry.SelectedIndex = 0;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;

            isClientSelectedByDoubleClick = false;
            enableFiltering = true;
        }

        private void txtClientLastName_TextChanged(object sender, EventArgs e)
        {
            if (!enableFiltering)
            {
                return;
            }
            string searchText = txtClientLastName.Text.Trim().ToLower();
            if (dgvClients.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"ClientLastName LIKE '%{searchText}%'";
                dgvClients.DataSource = dv.ToTable();
            }
        }

        private void txtClientAddress_TextChanged(object sender, EventArgs e)
        {
            if (!enableFiltering)
            {
                return;
            }
            string searchText = txtClientAddress.Text.Trim().ToLower();
            if (dgvClients.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"ClientAddress LIKE '%{searchText}%'";
                dgvClients.DataSource = dv.ToTable();
            }
        }

        private void txtClientContactNB_TextChanged(object sender, EventArgs e)
        {
            if (!enableFiltering)
            {
                return;
            }
            string searchText = txtClientContactNB.Text.Trim().ToLower();
            if (dgvClients.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"ClientContactNB LIKE '%{searchText}%'";
                dgvClients.DataSource = dv.ToTable();
            }
        }
        private void LoadClientsWithCountryNames()
        {
            // Load countries
            Classes.Country countries = new Classes.Country();
            dtCountries = countries.SELECT();

            Dictionary<int, string> countryMap = new Dictionary<int, string>();
            foreach (DataRow row in dtCountries.Rows)
            {
                int id = Convert.ToInt32(row["CountryID"]);
                string name = row["CountryName"].ToString();
                countryMap[id] = name;
            }

            // Load clients
            Classes.Client client = new Classes.Client();
            dtClients = client.SELECT();

            // Add a column for Country name if it doesn't exist
            if (!dtClients.Columns.Contains("Country"))
                dtClients.Columns.Add("Country", typeof(string));

            foreach (DataRow row in dtClients.Rows)
            {
                int countryID = Convert.ToInt32(row["CountryID"]);
                row["Country"] = countryMap.ContainsKey(countryID) ? countryMap[countryID] : "Unknown";
            }

            
            dgvClients.Columns.Clear();

            dgvClients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ClientFirstName",       
                HeaderText = "First Name",
                DataPropertyName = "ClientFirstName"
            });

            dgvClients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ClientLastName",
                HeaderText = "Last Name",
                DataPropertyName = "ClientLastName"
            });

            dgvClients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ClientContactNB",
                HeaderText = "Contact",
                DataPropertyName = "ClientContactNB"
            });

            dgvClients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ClientAddress",
                HeaderText = "Address",
                DataPropertyName = "ClientAddress"
            });

            dgvClients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Country",
                HeaderText = "Country",
                DataPropertyName = "Country"
            });

            dgvClients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CountryID",
                DataPropertyName = "CountryID",
                Visible = false 
            });
            dgvClients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ClientID",             
                DataPropertyName = "ClientID",  
                Visible = false                 
            });

           
            dgvClients.DataSource = dtClients;
        }
        private void lblTotal_Click(object sender, EventArgs e)
        {
        }
        private void UpdateClientCount()
        {
            lblTotal.Text = $"{dgvClients.Rows.Count - (dgvClients.AllowUserToAddRows ? 1 : 0)}";
        }

    }
}
