using System;
using System.Data;
using System.Windows.Forms;
using Pharmacy.Classes;

namespace Pharmacy.Forms
{
    public partial class frmProduct : Form
    {
        private int selectedProductID = -1;

        public frmProduct()
        {
            InitializeComponent();
            dgvProducts.AutoGenerateColumns = false;
            dgvProductDetails.AutoGenerateColumns = false;
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadProducts();
            ClearInputs();
        }

        private void LoadProducts()
        {
            try
            {
                // Step 1: Get raw data
                DataTable original = new Product().SELECT();
                dgvProducts.AllowUserToAddRows = false;

                // Step 2: Clone structure and convert specific columns to bool
                DataTable converted = original.Clone();
                converted.Columns["NeedsRefrigerator"].DataType = typeof(bool);
                converted.Columns["IsPerishable"].DataType = typeof(bool);

                // Step 3: Import rows (auto-converts values like 0/1 into bool)
                foreach (DataRow row in original.Rows)
                    converted.ImportRow(row);

                // Step 4: Bind
                dgvProducts.DataSource = converted;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }
      

        private void LoadProductDetails(int productId)
        {
            try
            {
                //dgvProductDetails.DataSource = ProductDetail.SelectByProductID(productId);
                dgvProductDetails.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product details: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txtProductName.Text = "";
            txtProductGroup.Text = "";
            chkNeedsRefrigerator.Checked = false;
            chkIsPerishable.Checked = false;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            selectedProductID = -1;
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                selectedProductID = Convert.ToInt32(row.Cells["ProductIDCol"].Value);

                txtProductName.Text = row.Cells["ProductNameCol"].Value.ToString();
                txtProductGroup.Text = row.Cells["ProductGroupCol"].Value.ToString();
                chkNeedsRefrigerator.Checked = Convert.ToBoolean(row.Cells["NeedsRefrigeratorCol"].Value);
                chkIsPerishable.Checked = Convert.ToBoolean(row.Cells["IsPerishableCol"].Value);

                LoadProductDetails(selectedProductID);

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product(0, txtProductName.Text.Trim(), chkNeedsRefrigerator.Checked, txtProductGroup.Text.Trim(), chkIsPerishable.Checked);
                product.INSERT();
               
                LoadProducts();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProductID == -1)
            {
                MessageBox.Show("No product selected to update.");
                return;
            }

            try
            {
                Product product = new Product(selectedProductID, txtProductName.Text.Trim(), chkNeedsRefrigerator.Checked, txtProductGroup.Text.Trim(), chkIsPerishable.Checked);
                product.UPDATE();
               
                LoadProducts();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductID == -1)
            {
                MessageBox.Show("No product selected to delete.");
                return;
            }

            try
            {
                Product product = new Product();
                product.ProductID = selectedProductID;
                product.DELETE();
               
                LoadProducts();
                ClearInputs();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_")) // foreign key constraint
                    MessageBox.Show("Cannot delete this product because it is linked to other records.");
                else
                    MessageBox.Show("Error deleting product: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
            ClearInputs();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        }
    }

