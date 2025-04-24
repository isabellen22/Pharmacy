//using System;

namespace Pharmacy.Forms
{
    partial class frmProduct
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductGroup = new System.Windows.Forms.TextBox();
            this.chkNeedsRefrigerator = new System.Windows.Forms.CheckBox();
            this.chkIsPerishable = new System.Windows.Forms.CheckBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductGroup = new System.Windows.Forms.Label();
            this.lblNeedsRefrigerator = new System.Windows.Forms.Label();
            this.lblIsPerishable = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ProductNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductGroupCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NeedsRefrigeratorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPerishableCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductDetails = new System.Windows.Forms.DataGridView();
            this.DetailIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDetailProductIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(180, 44);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(224, 25);
            this.txtProductName.TabIndex = 0;
            // 
            // txtProductGroup
            // 
            this.txtProductGroup.Location = new System.Drawing.Point(180, 84);
            this.txtProductGroup.Name = "txtProductGroup";
            this.txtProductGroup.Size = new System.Drawing.Size(224, 25);
            this.txtProductGroup.TabIndex = 1;
            // 
            // chkNeedsRefrigerator
            // 
            this.chkNeedsRefrigerator.Location = new System.Drawing.Point(180, 124);
            this.chkNeedsRefrigerator.Name = "chkNeedsRefrigerator";
            this.chkNeedsRefrigerator.Size = new System.Drawing.Size(104, 24);
            this.chkNeedsRefrigerator.TabIndex = 2;
            // 
            // chkIsPerishable
            // 
            this.chkIsPerishable.Location = new System.Drawing.Point(180, 164);
            this.chkIsPerishable.Name = "chkIsPerishable";
            this.chkIsPerishable.Size = new System.Drawing.Size(104, 24);
            this.chkIsPerishable.TabIndex = 3;
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(35, 44);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(120, 25);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblProductGroup
            // 
            this.lblProductGroup.Location = new System.Drawing.Point(35, 84);
            this.lblProductGroup.Name = "lblProductGroup";
            this.lblProductGroup.Size = new System.Drawing.Size(120, 25);
            this.lblProductGroup.TabIndex = 5;
            this.lblProductGroup.Text = "Product Group:";
            // 
            // lblNeedsRefrigerator
            // 
            this.lblNeedsRefrigerator.Location = new System.Drawing.Point(35, 124);
            this.lblNeedsRefrigerator.Name = "lblNeedsRefrigerator";
            this.lblNeedsRefrigerator.Size = new System.Drawing.Size(140, 25);
            this.lblNeedsRefrigerator.TabIndex = 6;
            this.lblNeedsRefrigerator.Text = "Needs Refrigerator:";
            // 
            // lblIsPerishable
            // 
            this.lblIsPerishable.Location = new System.Drawing.Point(35, 164);
            this.lblIsPerishable.Name = "lblIsPerishable";
            this.lblIsPerishable.Size = new System.Drawing.Size(120, 25);
            this.lblIsPerishable.TabIndex = 7;
            this.lblIsPerishable.Text = "Is Perishable:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::Pharmacy.Properties.Resources.Refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(478, 40);
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
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::Pharmacy.Properties.Resources.Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(584, 40);
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
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::Pharmacy.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(690, 40);
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
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::Pharmacy.Properties.Resources.Update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(796, 40);
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
            this.btnExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::Pharmacy.Properties.Resources.Exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(902, 40);
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
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductNameCol,
            this.ProductGroupCol,
            this.NeedsRefrigeratorCol,
            this.IsPerishableCol,
            this.ProductIDCol});
            this.dgvProducts.Location = new System.Drawing.Point(0, 210);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.Size = new System.Drawing.Size(1066, 200);
            this.dgvProducts.TabIndex = 42;
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            // 
            // ProductNameCol
            // 
            this.ProductNameCol.DataPropertyName = "ProductName";
            this.ProductNameCol.HeaderText = "Product Name";
            this.ProductNameCol.Name = "ProductNameCol";
            this.ProductNameCol.ReadOnly = true;
            // 
            // ProductGroupCol
            // 
            this.ProductGroupCol.DataPropertyName = "ProductGroup";
            this.ProductGroupCol.HeaderText = "Group";
            this.ProductGroupCol.Name = "ProductGroupCol";
            this.ProductGroupCol.ReadOnly = true;
            // 
            // NeedsRefrigeratorCol
            // 
            this.NeedsRefrigeratorCol.DataPropertyName = "NeedsRefrigerator";
            this.NeedsRefrigeratorCol.HeaderText = "Needs Refrigerator";
            this.NeedsRefrigeratorCol.Name = "NeedsRefrigeratorCol";
            this.NeedsRefrigeratorCol.ReadOnly = true;
            // 
            // IsPerishableCol
            // 
            this.IsPerishableCol.DataPropertyName = "IsPerishable";
            this.IsPerishableCol.HeaderText = "Is Perishable";
            this.IsPerishableCol.Name = "IsPerishableCol";
            this.IsPerishableCol.ReadOnly = true;
            // 
            // ProductIDCol
            // 
            this.ProductIDCol.DataPropertyName = "ProductID";
            this.ProductIDCol.HeaderText = "ProductID";
            this.ProductIDCol.Name = "ProductIDCol";
            this.ProductIDCol.ReadOnly = true;
            this.ProductIDCol.Visible = false;
            // 
            // dgvProductDetails
            // 
            this.dgvProductDetails.AllowUserToAddRows = false;
            this.dgvProductDetails.AllowUserToDeleteRows = false;
            this.dgvProductDetails.AllowUserToOrderColumns = true;
            this.dgvProductDetails.AllowUserToResizeColumns = false;
            this.dgvProductDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvProductDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductDetails.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetailIDCol,
            this.BatchNoCol,
            this.ExpiryDateCol,
            this.QuantityCol,
            this.UnitPriceCol,
            this.ProductDetailProductIDCol});
            this.dgvProductDetails.Location = new System.Drawing.Point(0, 420);
            this.dgvProductDetails.Name = "dgvProductDetails";
            this.dgvProductDetails.ReadOnly = true;
            this.dgvProductDetails.RowHeadersVisible = false;
            this.dgvProductDetails.Size = new System.Drawing.Size(1066, 200);
            this.dgvProductDetails.TabIndex = 43;
            // 
            // DetailIDCol
            // 
            this.DetailIDCol.DataPropertyName = "DetailID";
            this.DetailIDCol.HeaderText = "Detail ID";
            this.DetailIDCol.Name = "DetailIDCol";
            this.DetailIDCol.ReadOnly = true;
            this.DetailIDCol.Visible = false;
            // 
            // BatchNoCol
            // 
            this.BatchNoCol.DataPropertyName = "BatchNo";
            this.BatchNoCol.HeaderText = "Batch No";
            this.BatchNoCol.Name = "BatchNoCol";
            this.BatchNoCol.ReadOnly = true;
            // 
            // ExpiryDateCol
            // 
            this.ExpiryDateCol.DataPropertyName = "ExpiryDate";
            this.ExpiryDateCol.HeaderText = "Expiry Date";
            this.ExpiryDateCol.Name = "ExpiryDateCol";
            this.ExpiryDateCol.ReadOnly = true;
            // 
            // QuantityCol
            // 
            this.QuantityCol.DataPropertyName = "Quantity";
            this.QuantityCol.HeaderText = "Quantity";
            this.QuantityCol.Name = "QuantityCol";
            this.QuantityCol.ReadOnly = true;
            // 
            // UnitPriceCol
            // 
            this.UnitPriceCol.DataPropertyName = "UnitPrice";
            this.UnitPriceCol.HeaderText = "Unit Price";
            this.UnitPriceCol.Name = "UnitPriceCol";
            this.UnitPriceCol.ReadOnly = true;
            // 
            // ProductDetailProductIDCol
            // 
            this.ProductDetailProductIDCol.DataPropertyName = "ProductID";
            this.ProductDetailProductIDCol.HeaderText = "ProductID";
            this.ProductDetailProductIDCol.Name = "ProductDetailProductIDCol";
            this.ProductDetailProductIDCol.ReadOnly = true;
            this.ProductDetailProductIDCol.Visible = false;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1066, 654);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductGroup);
            this.Controls.Add(this.chkNeedsRefrigerator);
            this.Controls.Add(this.chkIsPerishable);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductGroup);
            this.Controls.Add(this.lblNeedsRefrigerator);
            this.Controls.Add(this.lblIsPerishable);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvProductDetails);
            this.Font = new System.Drawing.Font("Arial", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduct";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductGroup;
        private System.Windows.Forms.CheckBox chkNeedsRefrigerator;
        private System.Windows.Forms.CheckBox chkIsPerishable;

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductGroup;
        private System.Windows.Forms.Label lblNeedsRefrigerator;
        private System.Windows.Forms.Label lblIsPerishable;

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGroupCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NeedsRefrigeratorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPerishableCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDCol;

        private System.Windows.Forms.DataGridView dgvProductDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetailIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDetailProductIDCol;
    }
}
