//using Pharmacy.Properties;
//using System;
//using System.Resources;
//using System.Windows.Forms;

//namespace Pharmacy.Forms
//{
//    partial class frmPurchase
//    {
//        private System.ComponentModel.IContainer components = null;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//                components.Dispose();
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code



//        private void InitializeComponent()

//{
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
//            this.lblSupplier = new System.Windows.Forms.Label();
//            this.cmbSupplier = new System.Windows.Forms.ComboBox();
//            this.lblCurrency = new System.Windows.Forms.Label();
//            this.cmbCurrency = new System.Windows.Forms.ComboBox();
//            this.lblPaymentMethod = new System.Windows.Forms.Label();
//            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
//            this.lblProductDetails = new System.Windows.Forms.Label();
//            this.dgvProductDetails = new System.Windows.Forms.DataGridView();
//            this.TotalQuantityLbl = new System.Windows.Forms.Label();
//            this.TotalDiscountLbl = new System.Windows.Forms.Label();
//            this.TotalCostLbl = new System.Windows.Forms.Label();
//            this.btnRefresh = new System.Windows.Forms.Button();
//            this.btnAdd = new System.Windows.Forms.Button();
//            this.btnDelete = new System.Windows.Forms.Button();
//            this.btnUpdate = new System.Windows.Forms.Button();
//            this.btnExit = new System.Windows.Forms.Button();
//            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // lblSupplier
//            // 
//            this.lblSupplier.Location = new System.Drawing.Point(30, 27);
//            this.lblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
//            this.lblSupplier.Name = "lblSupplier";
//            this.lblSupplier.Size = new System.Drawing.Size(105, 22);
//            this.lblSupplier.TabIndex = 0;
//            this.lblSupplier.Text = "Supplier:";
//            // 
//            // cmbSupplier
//            // 
//            this.cmbSupplier.Location = new System.Drawing.Point(140, 27);
//            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(2);
//            this.cmbSupplier.Name = "cmbSupplier";
//            this.cmbSupplier.Size = new System.Drawing.Size(176, 23);
//            this.cmbSupplier.TabIndex = 1;
//            // 
//            // lblCurrency
//            // 
//            this.lblCurrency.Location = new System.Drawing.Point(30, 62);
//            this.lblCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
//            this.lblCurrency.Name = "lblCurrency";
//            this.lblCurrency.Size = new System.Drawing.Size(105, 22);
//            this.lblCurrency.TabIndex = 2;
//            this.lblCurrency.Text = "Currency:";
//            // 
//            // cmbCurrency
//            // 
//            this.cmbCurrency.Location = new System.Drawing.Point(140, 62);
//            this.cmbCurrency.Margin = new System.Windows.Forms.Padding(2);
//            this.cmbCurrency.Name = "cmbCurrency";
//            this.cmbCurrency.Size = new System.Drawing.Size(176, 23);
//            this.cmbCurrency.TabIndex = 3;
//            // 
//            // lblPaymentMethod
//            // 
//            this.lblPaymentMethod.Location = new System.Drawing.Point(30, 97);
//            this.lblPaymentMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
//            this.lblPaymentMethod.Name = "lblPaymentMethod";
//            this.lblPaymentMethod.Size = new System.Drawing.Size(105, 22);
//            this.lblPaymentMethod.TabIndex = 4;
//            this.lblPaymentMethod.Text = "Payment Method:";
//            // 
//            // cmbPaymentMethod
//            // 
//            this.cmbPaymentMethod.Location = new System.Drawing.Point(140, 97);
//            this.cmbPaymentMethod.Margin = new System.Windows.Forms.Padding(2);
//            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
//            this.cmbPaymentMethod.Size = new System.Drawing.Size(176, 23);
//            this.cmbPaymentMethod.TabIndex = 5;
//            // 
//            // lblProductDetails
//            // 
//            this.lblProductDetails.Location = new System.Drawing.Point(30, 141);
//            this.lblProductDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
//            this.lblProductDetails.Name = "lblProductDetails";
//            this.lblProductDetails.Size = new System.Drawing.Size(105, 22);
//            this.lblProductDetails.TabIndex = 6;
//            this.lblProductDetails.Text = "Product Details:";
//            // 
//            // dgvProductDetails
//            // 
//            this.dgvProductDetails.AllowUserToAddRows = false;
//            this.dgvProductDetails.AllowUserToDeleteRows = false;
//            this.dgvProductDetails.AllowUserToResizeColumns = false;
//            this.dgvProductDetails.AllowUserToResizeRows = false;
//            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
//            this.dgvProductDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
//            this.dgvProductDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            this.dgvProductDetails.BackgroundColor = System.Drawing.Color.Azure;
//            this.dgvProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dgvProductDetails.Location = new System.Drawing.Point(30, 167);
//            this.dgvProductDetails.Margin = new System.Windows.Forms.Padding(2);
//            this.dgvProductDetails.Name = "dgvProductDetails";
//            this.dgvProductDetails.RowHeadersVisible = false;
//            this.dgvProductDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
//            this.dgvProductDetails.Size = new System.Drawing.Size(1014, 177);
//            this.dgvProductDetails.TabIndex = 7;
//            // 
//            // TotalQuantityLbl
//            // 
//            this.TotalQuantityLbl.Location = new System.Drawing.Point(30, 353);
//            this.TotalQuantityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
//            this.TotalQuantityLbl.Name = "TotalQuantityLbl";
//            this.TotalQuantityLbl.Size = new System.Drawing.Size(131, 22);
//            this.TotalQuantityLbl.TabIndex = 8;
//            this.TotalQuantityLbl.Text = "Total Quantity:";
//            // 
//            // TotalDiscountLbl
//            // 
//            this.TotalDiscountLbl.Location = new System.Drawing.Point(30, 388);
//            this.TotalDiscountLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
//            this.TotalDiscountLbl.Name = "TotalDiscountLbl";
//            this.TotalDiscountLbl.Size = new System.Drawing.Size(131, 22);
//            this.TotalDiscountLbl.TabIndex = 9;
//            this.TotalDiscountLbl.Text = "Total Discount:";
//            // 
//            // TotalCostLbl
//            // 
//            this.TotalCostLbl.Location = new System.Drawing.Point(30, 423);
//            this.TotalCostLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
//            this.TotalCostLbl.Name = "TotalCostLbl";
//            this.TotalCostLbl.Size = new System.Drawing.Size(131, 22);
//            this.TotalCostLbl.TabIndex = 10;
//            this.TotalCostLbl.Text = "Total Cost:";
//            // 
//            // btnRefresh
//            // 
//            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
//            this.btnRefresh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnRefresh.Image = global::Pharmacy.Properties.Resources.Refresh;
//            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
//            this.btnRefresh.Location = new System.Drawing.Point(521, 27);
//            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
//            this.btnRefresh.Name = "btnRefresh";
//            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
//            this.btnRefresh.Size = new System.Drawing.Size(100, 86);
//            this.btnRefresh.TabIndex = 40;
//            this.btnRefresh.Text = "Refresh";
//            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
//            this.btnRefresh.UseVisualStyleBackColor = true;
//            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
//            // 
//            // btnAdd
//            // 
//            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
//            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnAdd.Image = global::Pharmacy.Properties.Resources.Add;
//            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
//            this.btnAdd.Location = new System.Drawing.Point(627, 27);
//            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
//            this.btnAdd.Name = "btnAdd";
//            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
//            this.btnAdd.Size = new System.Drawing.Size(100, 86);
//            this.btnAdd.TabIndex = 37;
//            this.btnAdd.Text = "Add";
//            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
//            this.btnAdd.UseVisualStyleBackColor = true;
//            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
//            // 
//            // btnDelete
//            // 
//            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
//            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnDelete.Image = global::Pharmacy.Properties.Resources.Delete;
//            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
//            this.btnDelete.Location = new System.Drawing.Point(733, 27);
//            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
//            this.btnDelete.Name = "btnDelete";
//            this.btnDelete.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
//            this.btnDelete.Size = new System.Drawing.Size(100, 86);
//            this.btnDelete.TabIndex = 38;
//            this.btnDelete.Text = "Delete";
//            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
//            this.btnDelete.UseVisualStyleBackColor = true;
//            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
//            // 
//            // btnUpdate
//            // 
//            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
//            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnUpdate.Image = global::Pharmacy.Properties.Resources.Update;
//            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
//            this.btnUpdate.Location = new System.Drawing.Point(839, 27);
//            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
//            this.btnUpdate.Name = "btnUpdate";
//            this.btnUpdate.Padding = new System.Windows.Forms.Padding(0, 11, 0, 6);
//            this.btnUpdate.Size = new System.Drawing.Size(100, 86);
//            this.btnUpdate.TabIndex = 39;
//            this.btnUpdate.Text = "Update";
//            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
//            this.btnUpdate.UseVisualStyleBackColor = true;
//            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
//            // 
//            // btnExit
//            // 
//            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
//            this.btnExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnExit.Image = global::Pharmacy.Properties.Resources.Exit;
//            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
//            this.btnExit.Location = new System.Drawing.Point(945, 27);
//            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
//            this.btnExit.Name = "btnExit";
//            this.btnExit.Padding = new System.Windows.Forms.Padding(0, 11, 0, 6);
//            this.btnExit.Size = new System.Drawing.Size(100, 86);
//            this.btnExit.TabIndex = 41;
//            this.btnExit.Text = "Exit";
//            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
//            this.btnExit.UseVisualStyleBackColor = true;
//            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
//            // 
//            // dtpPurchaseDate
//            // 
//            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
//            this.dtpPurchaseDate.Location = new System.Drawing.Point(140, 133);
//            this.dtpPurchaseDate.Margin = new System.Windows.Forms.Padding(2);
//            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
//            this.dtpPurchaseDate.Size = new System.Drawing.Size(176, 23);
//            this.dtpPurchaseDate.TabIndex = 6;
//            // 
//            // frmPurchase
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
//            this.ClientSize = new System.Drawing.Size(1066, 654);
//            this.Controls.Add(this.dtpPurchaseDate);
//            this.Controls.Add(this.btnExit);
//            this.Controls.Add(this.btnUpdate);
//            this.Controls.Add(this.btnDelete);
//            this.Controls.Add(this.btnAdd);
//            this.Controls.Add(this.btnRefresh);
//            this.Controls.Add(this.TotalCostLbl);
//            this.Controls.Add(this.TotalDiscountLbl);
//            this.Controls.Add(this.TotalQuantityLbl);
//            this.Controls.Add(this.dgvProductDetails);
//            this.Controls.Add(this.lblProductDetails);
//            this.Controls.Add(this.cmbPaymentMethod);
//            this.Controls.Add(this.lblPaymentMethod);
//            this.Controls.Add(this.cmbCurrency);
//            this.Controls.Add(this.lblCurrency);
//            this.Controls.Add(this.cmbSupplier);
//            this.Controls.Add(this.lblSupplier);
//            this.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
//            this.Margin = new System.Windows.Forms.Padding(2);
//            this.Name = "frmPurchase";
//            this.Text = "Purchase Form";
//            this.Load += new System.EventHandler(this.frmPurchase_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).EndInit();
//            this.ResumeLayout(false);

//}


//        #endregion

//        private System.Windows.Forms.Label lblSupplier;
//        private System.Windows.Forms.ComboBox cmbSupplier;
//        private System.Windows.Forms.Label lblCurrency;
//        private System.Windows.Forms.ComboBox cmbCurrency;
//        private System.Windows.Forms.Label lblPaymentMethod;
//        private System.Windows.Forms.ComboBox cmbPaymentMethod;
//        private System.Windows.Forms.Label lblProductDetails;
//        private System.Windows.Forms.DataGridView dgvProductDetails;
//        private System.Windows.Forms.Label TotalQuantityLbl;
//        private System.Windows.Forms.Label TotalDiscountLbl;
//        private System.Windows.Forms.Label TotalCostLbl;
//        private System.Windows.Forms.Button btnRefresh;
//        private System.Windows.Forms.Button btnAdd;
//        private System.Windows.Forms.Button btnDelete;
//        private System.Windows.Forms.Button btnUpdate;
//        private System.Windows.Forms.Button btnExit;
//        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
//    }
//}


using Pharmacy.Classes;
using Pharmacy.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
    partial class frmPurchase
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.dgvProductDetails = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ProductDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQuantityLbl = new System.Windows.Forms.Label();
            this.TotalDiscountLbl = new System.Windows.Forms.Label();
            this.TotalCostLbl = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSupplier
            // 
            this.lblSupplier.Location = new System.Drawing.Point(30, 27);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(105, 22);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "Supplier:";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Location = new System.Drawing.Point(140, 27);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(176, 23);
            this.cmbSupplier.TabIndex = 1;
            // 
            // lblCurrency
            // 
            this.lblCurrency.Location = new System.Drawing.Point(30, 62);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(105, 22);
            this.lblCurrency.TabIndex = 2;
            this.lblCurrency.Text = "Currency:";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.Location = new System.Drawing.Point(140, 62);
            this.cmbCurrency.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(176, 23);
            this.cmbCurrency.TabIndex = 3;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Location = new System.Drawing.Point(30, 97);
            this.lblPaymentMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(105, 22);
            this.lblPaymentMethod.TabIndex = 4;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.Location = new System.Drawing.Point(140, 97);
            this.cmbPaymentMethod.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(176, 23);
            this.cmbPaymentMethod.TabIndex = 5;
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.Location = new System.Drawing.Point(30, 141);
            this.lblProductDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Size = new System.Drawing.Size(105, 22);
            this.lblProductDetails.TabIndex = 6;
            this.lblProductDetails.Text = "Product Details:";
            // 
            // dgvProductDetails
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvProductDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductDetails.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.ProductDate,
            this.ExpiryDate,
            this.Quantity,
            this.PurchasePrice,
            this.Discount,
            this.VAT,
            this.Total});
            this.dgvProductDetails.Location = new System.Drawing.Point(0, 167);
            this.dgvProductDetails.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductDetails.Name = "dgvProductDetails";
            this.dgvProductDetails.RowHeadersVisible = false;
            this.dgvProductDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductDetails.Size = new System.Drawing.Size(1217, 335);
            this.dgvProductDetails.TabIndex = 7;
            this.dgvProductDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductDetails_CellValueChanged);
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            // 
            // ProductDate
            // 
            this.ProductDate.HeaderText = "Product Date";
            this.ProductDate.Name = "ProductDate";
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.HeaderText = "Expiry Date";
            this.ExpiryDate.Name = "ExpiryDate";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.HeaderText = "Purchase Price";
            this.PurchasePrice.Name = "PurchasePrice";
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            // 
            // VAT
            // 
            this.VAT.HeaderText = "VAT";
            this.VAT.Name = "VAT";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // TotalQuantityLbl
            // 
            this.TotalQuantityLbl.Location = new System.Drawing.Point(4, 677);
            this.TotalQuantityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalQuantityLbl.Name = "TotalQuantityLbl";
            this.TotalQuantityLbl.Size = new System.Drawing.Size(131, 22);
            this.TotalQuantityLbl.TabIndex = 8;
            this.TotalQuantityLbl.Text = "Total Quantity:";
            this.TotalQuantityLbl.Click += new System.EventHandler(this.TotalQuantityLbl_Click);
            // 
            // TotalDiscountLbl
            // 
            this.TotalDiscountLbl.Location = new System.Drawing.Point(653, 677);
            this.TotalDiscountLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalDiscountLbl.Name = "TotalDiscountLbl";
            this.TotalDiscountLbl.Size = new System.Drawing.Size(131, 22);
            this.TotalDiscountLbl.TabIndex = 9;
            this.TotalDiscountLbl.Text = "Total Discount:";
            // 
            // TotalCostLbl
            // 
            this.TotalCostLbl.Location = new System.Drawing.Point(331, 677);
            this.TotalCostLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalCostLbl.Name = "TotalCostLbl";
            this.TotalCostLbl.Size = new System.Drawing.Size(131, 22);
            this.TotalCostLbl.TabIndex = 10;
            this.TotalCostLbl.Text = "Total Cost:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 9F);
            this.btnRefresh.Image = global::Pharmacy.Properties.Resources.Refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(737, 27);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnRefresh.Size = new System.Drawing.Size(100, 86);
            this.btnRefresh.TabIndex = 40;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F);
            this.btnAdd.Image = global::Pharmacy.Properties.Resources.Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(843, 27);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnAdd.Size = new System.Drawing.Size(100, 86);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F);
            this.btnDelete.Image = global::Pharmacy.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(949, 27);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnDelete.Size = new System.Drawing.Size(100, 86);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F);
            this.btnUpdate.Image = global::Pharmacy.Properties.Resources.Update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(1055, 27);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(0, 11, 0, 6);
            this.btnUpdate.Size = new System.Drawing.Size(100, 86);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Arial", 9F);
            this.btnExit.Image = global::Pharmacy.Properties.Resources.Exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(1161, 27);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(0, 11, 0, 6);
            this.btnExit.Size = new System.Drawing.Size(100, 86);
            this.btnExit.TabIndex = 41;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(140, 133);
            this.dtpPurchaseDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(176, 23);
            this.dtpPurchaseDate.TabIndex = 6;
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1282, 708);
            this.Controls.Add(this.dtpPurchaseDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.TotalCostLbl);
            this.Controls.Add(this.TotalDiscountLbl);
            this.Controls.Add(this.TotalQuantityLbl);
            this.Controls.Add(this.dgvProductDetails);
            this.Controls.Add(this.lblProductDetails);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.lblSupplier);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPurchase";
            this.Text = "Purchase Form";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblProductDetails;
        private System.Windows.Forms.DataGridView dgvProductDetails;
        private System.Windows.Forms.Label TotalQuantityLbl;
        private System.Windows.Forms.Label TotalDiscountLbl;
        private System.Windows.Forms.Label TotalCostLbl;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;

        //private System.Windows.Forms.DataGridView dgvProductDetails;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private void InitializeDataGridView()
        {
            // Set properties for the DataGridView
            dgvProductDetails.AllowUserToAddRows = true; // Allow users to add rows
            dgvProductDetails.AllowUserToDeleteRows = true; // Allow users to delete rows
            dgvProductDetails.AllowUserToResizeColumns = false; // Disable column resizing
            dgvProductDetails.AllowUserToResizeRows = false; // Disable row resizing
            dgvProductDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Auto fit columns based on content (not recommended with fixed width)
            dgvProductDetails.BackgroundColor = System.Drawing.Color.Azure; // Set background color
            dgvProductDetails.RowHeadersVisible = false; // Hide row headers
            dgvProductDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Set column widths
            dgvProductDetails.Columns["Product"].Width = 200;  // Product Column
            dgvProductDetails.Columns["ProductDate"].Width = 150; // Product Date Column
            dgvProductDetails.Columns["ExpiryDate"].Width = 150; // Expiry Date Column
            dgvProductDetails.Columns["Quantity"].Width = 100; // Quantity Column
            dgvProductDetails.Columns["PurchasePrice"].Width = 120; // Purchase Price Column
            dgvProductDetails.Columns["Discount"].Width = 100; // Discount Column
            dgvProductDetails.Columns["VAT"].Width = 100; // VAT Column
            dgvProductDetails.Columns["Total"].Width = 120; // Total Column

            // Set alternating row colors
            dgvProductDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue; // Alternating row color
            dgvProductDetails.RowsDefaultCellStyle.BackColor = Color.Azure; // Normal row color

            // Set the headers style (adjust to match your design)
            dgvProductDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dgvProductDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvProductDetails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            // Optional: Set the total column to read-only since it will be calculated
            dgvProductDetails.Columns["Total"].ReadOnly = true;

            // Handle numeric validation for specific columns
            dgvProductDetails.CellValidating += dgvProductDetails_CellValidating;

            // Handle DateTimePicker in ProductDate and ExpiryDate columns
            dgvProductDetails.EditingControlShowing += dgvProductDetails_EditingControlShowing;
        }
        private void BindProductDropdown()
        {
            Product product = new Product();
            DataTable productsTable = product.SELECT(); // Get the list of products from the SELECT method

            // Bind the data to the Product column in the DataGridView
            this.Product.DataSource = productsTable;
            this.Product.DisplayMember = "ProductName"; // Column to display in the dropdown
            this.Product.ValueMember = "ProductID"; // Store the ProductID in the background
        }

        private void dgvProductDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvProductDetails.Rows[e.RowIndex];
                if (e.ColumnIndex == dgvProductDetails.Columns["Quantity"].Index ||
                    e.ColumnIndex == dgvProductDetails.Columns["PurchasePrice"].Index ||
                    e.ColumnIndex == dgvProductDetails.Columns["Discount"].Index ||
                    e.ColumnIndex == dgvProductDetails.Columns["VAT"].Index)
                {
                    // Retrieve values from the row
                    double quantity = Convert.ToDouble(row.Cells["Quantity"].Value);
                    double purchasePrice = Convert.ToDouble(row.Cells["PurchasePrice"].Value);
                    double discount = Convert.ToDouble(row.Cells["Discount"].Value);
                    double vat = Convert.ToDouble(row.Cells["VAT"].Value);

                    // Calculate total = (quantity * price) - discount + VAT
                    double total = (quantity * purchasePrice) - discount + vat;
                    row.Cells["Total"].Value = total.ToString("0.00"); // Format to 2 decimal places
                }
            }
        }
    }
}
