using Pharmacy.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
    public partial class frmCurrency : Form
    {
        private int selectedID = 0;

        public frmCurrency()
        {
            InitializeComponent();
            dgvCurrency.AutoGenerateColumns = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void frmCurrency_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            Currency currency = new Currency(0, "", "", 0, DateTime.Now);
            dgvCurrency.DataSource = currency.SELECT();
        }

        private void ClearInputs()
        {
            txtCode.Clear();
            txtName.Clear();
            txtRate.Clear();
            dtpRateDate.Value = DateTime.Today;

            selectedID = 0;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtRate.Text))
            {
                MessageBox.Show("All fields are required.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtRate.Text.Trim(), out decimal rate))
            {
                MessageBox.Show("Currency Rate must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Currency currency = new Currency(0, txtCode.Text.Trim(), txtName.Text.Trim(), rate, dtpRateDate.Value, 0);

            currency.INSERT();
            LoadData();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedID == 0) return;

            try
            {
                Currency currency = new Currency(selectedID, "", "", 0, DateTime.Today, 0);
                currency.DELETE();
                LoadData();
                ClearInputs();
            }
            catch (SqlException ex) when (ex.Number == 547) // FK violation
            {
                MessageBox.Show(
                    "This currency is currently in use and cannot be deleted.\n\n" +
                    "Please remove any related entries (e.g., employee promotions or transactions) before trying again.",
                    "Delete Blocked",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unexpected error:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedID == 0 ||
                string.IsNullOrWhiteSpace(txtCode.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtRate.Text))
            {
                MessageBox.Show("All fields are required.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtRate.Text.Trim(), out decimal rate))
            {
                MessageBox.Show("Currency Rate must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Currency currency = new Currency(selectedID, txtCode.Text.Trim(), txtName.Text.Trim(), rate, dtpRateDate.Value, 0);

            currency.UPDATE();
            LoadData();
            ClearInputs();
        }

        private void dgvCurrency_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCurrency.Rows[e.RowIndex].Cells["CurrencyID"].Value != null)
            {
                DataGridViewRow row = dgvCurrency.Rows[e.RowIndex];

                selectedID = Convert.ToInt32(row.Cells["CurrencyID"].Value);
                txtCode.Text = row.Cells["CurrencyCode"].Value?.ToString();
                txtName.Text = row.Cells["CurrencyName"].Value?.ToString();
                txtRate.Text = row.Cells["CurrencyRate"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["CurrencyRateDate"].Value?.ToString(), out DateTime parsedDate))
                    dtpRateDate.Value = parsedDate;
                else
                    dtpRateDate.Value = DateTime.Today;

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void frmCurrency_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
