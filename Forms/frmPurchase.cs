using System;
using System.Data;
using System.Windows.Forms;
using Pharmacy.Classes;  // Add the namespace for the Purchase class

namespace Pharmacy.Forms
{
    public partial class frmPurchase : Form
    {
        private Purchase purchase = new Purchase(); // Create instance of the Purchase class

        public frmPurchase()
        {
            InitializeComponent();
            
        }

        // Form Load: Populate ComboBoxes and load initial data
        private void frmPurchase_Load(object sender, EventArgs e)
        {
            BindProductDropdown(); // Bind the dropdown with the product data
            InitializeDataGridView();
        }

        // Load ComboBoxes (Supplier, Currency, Payment Method)
        private void LoadComboBoxes()
        {
            // Example: Populate ComboBoxes from your existing database connection
            DataTable dtSupplier = purchase.SELECT();
            cmbSupplier.DataSource = dtSupplier;
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierID";

            DataTable dtCurrency = purchase.SELECT();
            cmbCurrency.DataSource = dtCurrency;
            cmbCurrency.DisplayMember = "CurrencyName";
            cmbCurrency.ValueMember = "CurrencyID";

            DataTable dtPaymentMethod = purchase.SELECT();
            cmbPaymentMethod.DataSource = dtPaymentMethod;
            cmbPaymentMethod.DisplayMember = "PaymentMethodName";
            cmbPaymentMethod.ValueMember = "PaymentMethodID";
        }

        // Load Purchases into the DataGridView
        private void LoadPurchases()
        {
            DataTable dt = purchase.SELECT();
            dgvProductDetails.DataSource = dt;
            CalculateTotals();
        }

        // Calculate Totals: Quantity, Discount, and Cost
        private void CalculateTotals()
        {
            decimal totalQuantity = 0, totalDiscount = 0, totalCost = 0;

            foreach (DataGridViewRow row in dgvProductDetails.Rows)
            {
                if (row.Cells["Quantity"].Value != null && row.Cells["Price"].Value != null)
                {
                    decimal quantity = Convert.ToDecimal(row.Cells["Quantity"].Value);
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                    decimal discount = Convert.ToDecimal(row.Cells["Discount"].Value);
                    decimal vat = Convert.ToDecimal(row.Cells["VAT"].Value);

                    totalQuantity += quantity;
                    totalDiscount += discount;
                    totalCost += (quantity * price) - discount + (quantity * price * vat);
                }
            }

            TotalQuantityLbl.Text = $"Total Quantity: {totalQuantity}";
            TotalDiscountLbl.Text = $"Total Discount: {totalDiscount}";
            TotalCostLbl.Text = $"Total Cost: {totalCost}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            purchase.SupplierID = Convert.ToInt32(cmbSupplier.SelectedValue);
            purchase.CurrencyID = Convert.ToInt32(cmbCurrency.SelectedValue);
            purchase.PaymentMethodID = Convert.ToInt32(cmbPaymentMethod.SelectedValue);
            purchase.UserID = 1;  // Replace with actual logged-in user ID

            // Pass PurchaseDate from DateTimePicker
            DateTime purchaseDate = dtpPurchaseDate.Value;

            // Call INSERT method with purchaseDate
            purchase.INSERT(purchaseDate);
            MessageBox.Show("Purchase record added successfully!");
            LoadPurchases();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            purchase.PurchaseID = 1;  // Replace with actual PurchaseID
            purchase.SupplierID = Convert.ToInt32(cmbSupplier.SelectedValue);
            purchase.CurrencyID = Convert.ToInt32(cmbCurrency.SelectedValue);
            purchase.PaymentMethodID = Convert.ToInt32(cmbPaymentMethod.SelectedValue);
            purchase.UserID = 1;  // Replace with actual logged-in user ID

            // Pass PurchaseDate from DateTimePicker
            DateTime purchaseDate = dtpPurchaseDate.Value;

            // Call UPDATE method with purchaseDate
            purchase.UPDATE(purchaseDate);
            MessageBox.Show("Purchase record updated successfully!");
            LoadPurchases();
        }

        // Delete Button Logic: Delete the selected purchase record
        private void btnDelete_Click(object sender, EventArgs e)
        {
            purchase.PurchaseID = 1;  // Replace with actual PurchaseID
            purchase.DELETE();
            MessageBox.Show("Purchase record deleted successfully!");
            LoadPurchases();
        }

        // Refresh Button Logic: Reload data
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPurchases();
        }

        // Exit Button Logic: Close the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvProductDetails_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvProductDetails.CurrentCell.ColumnIndex == dgvProductDetails.Columns["ProductDate"].Index ||
                dgvProductDetails.CurrentCell.ColumnIndex == dgvProductDetails.Columns["ExpiryDate"].Index)
            {
                DateTimePicker dateTimePicker = e.Control as DateTimePicker;
                if (dateTimePicker != null)
                {
                    // You can customize the format here
                    dateTimePicker.Format = DateTimePickerFormat.Short; // Short date format (e.g., 4/23/2025)
                }
            }
        }

        private void dgvProductDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvProductDetails.Columns[e.ColumnIndex].Name == "Quantity" ||
                dgvProductDetails.Columns[e.ColumnIndex].Name == "PurchasePrice" ||
                dgvProductDetails.Columns[e.ColumnIndex].Name == "Discount" ||
                dgvProductDetails.Columns[e.ColumnIndex].Name == "VAT")
            {
                // Check if the input is a valid number
                if (!decimal.TryParse(e.FormattedValue.ToString(), out decimal result))
                {
                    // If the input is invalid, display an error message and cancel the edit
                    MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true; // Cancel the edit to prevent invalid input
                }
            }
        }

        private void TotalQuantityLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
