namespace Pharmacy.Forms
{
    partial class frmMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.menuStripMDI = new System.Windows.Forms.MenuStrip();
            this.healthCareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorSpecializationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currenciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payementMethodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payementStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInsurance = new System.Windows.Forms.Button();
            this.btnPurchaseReturn = new System.Windows.Forms.Button();
            this.btnSalesReceipt = new System.Windows.Forms.Button();
            this.btnClientsTests = new System.Windows.Forms.Button();
            this.btnSalesReturn = new System.Windows.Forms.Button();
            this.btnProductPromotion = new System.Windows.Forms.Button();
            this.btnMedicalProducts = new System.Windows.Forms.Button();
            this.menuStripMDI.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMDI
            // 
            this.menuStripMDI.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStripMDI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStripMDI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(178)))), ((int)(((byte)(187)))));
            this.menuStripMDI.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStripMDI.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.healthCareToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.windowsStripMenuItem});
            this.menuStripMDI.Location = new System.Drawing.Point(0, 0);
            this.menuStripMDI.Name = "menuStripMDI";
            this.menuStripMDI.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.menuStripMDI.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripMDI.Size = new System.Drawing.Size(942, 29);
            this.menuStripMDI.TabIndex = 1;
            this.menuStripMDI.Text = "menuStrip";
            // 
            // healthCareToolStripMenuItem
            // 
            this.healthCareToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.healthCareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorsToolStripMenuItem,
            this.doctorSpecializationsToolStripMenuItem,
            this.laboratoryToolStripMenuItem,
            this.testsToolStripMenuItem});
            this.healthCareToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.healthCareToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Lime;
            this.healthCareToolStripMenuItem.MergeIndex = 0;
            this.healthCareToolStripMenuItem.Name = "healthCareToolStripMenuItem";
            this.healthCareToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.healthCareToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.healthCareToolStripMenuItem.Text = "Health care";
            // 
            // doctorsToolStripMenuItem
            // 
            this.doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
            this.doctorsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.doctorsToolStripMenuItem.Text = "Doctors";
            this.doctorsToolStripMenuItem.Click += new System.EventHandler(this.doctorsToolStripMenuItem_Click);
            // 
            // doctorSpecializationsToolStripMenuItem
            // 
            this.doctorSpecializationsToolStripMenuItem.Name = "doctorSpecializationsToolStripMenuItem";
            this.doctorSpecializationsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.doctorSpecializationsToolStripMenuItem.Text = "Doctor Specializations";
            this.doctorSpecializationsToolStripMenuItem.Click += new System.EventHandler(this.doctorSpecializationsToolStripMenuItem_Click);
            // 
            // laboratoryToolStripMenuItem
            // 
            this.laboratoryToolStripMenuItem.Name = "laboratoryToolStripMenuItem";
            this.laboratoryToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.laboratoryToolStripMenuItem.Text = "Laboratory";
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.testsToolStripMenuItem.Text = "Laboratory Tests";
            this.testsToolStripMenuItem.Click += new System.EventHandler(this.btnLaboratoryTests_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suppliersToolStripMenuItem});
            this.supplierToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.supplierToolStripMenuItem.Text = "Supplier";
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currenciesToolStripMenuItem,
            this.countriesToolStripMenuItem,
            this.payementMethodsToolStripMenuItem,
            this.payementStatusToolStripMenuItem,
            this.unitsToolStripMenuItem});
            this.dataToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // currenciesToolStripMenuItem
            // 
            this.currenciesToolStripMenuItem.Name = "currenciesToolStripMenuItem";
            this.currenciesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.currenciesToolStripMenuItem.Text = "Currencies";
            this.currenciesToolStripMenuItem.Click += new System.EventHandler(this.currenciesToolStripMenuItem_Click);
            // 
            // countriesToolStripMenuItem
            // 
            this.countriesToolStripMenuItem.Name = "countriesToolStripMenuItem";
            this.countriesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.countriesToolStripMenuItem.Text = "Countries";
            this.countriesToolStripMenuItem.Click += new System.EventHandler(this.btnCountry_Click);
            // 
            // payementMethodsToolStripMenuItem
            // 
            this.payementMethodsToolStripMenuItem.Name = "payementMethodsToolStripMenuItem";
            this.payementMethodsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.payementMethodsToolStripMenuItem.Text = "Payement methods";
            this.payementMethodsToolStripMenuItem.Click += new System.EventHandler(this.payementMethodsToolStripMenuItem_Click_1);
            // 
            // payementStatusToolStripMenuItem
            // 
            this.payementStatusToolStripMenuItem.Name = "payementStatusToolStripMenuItem";
            this.payementStatusToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.payementStatusToolStripMenuItem.Text = "Payement status";
            this.payementStatusToolStripMenuItem.Click += new System.EventHandler(this.payementStatusToolStripMenuItem_Click);
            // 
            // unitsToolStripMenuItem
            // 
            this.unitsToolStripMenuItem.Name = "unitsToolStripMenuItem";
            this.unitsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.unitsToolStripMenuItem.Text = "Units";
            this.unitsToolStripMenuItem.Click += new System.EventHandler(this.unitsToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem});
            this.employeeToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.screensToolStripMenuItem,
            this.permissionsToolStripMenuItem,
            this.roleToolStripMenuItem});
            this.usersToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.usersToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.usersToolStripMenuItem.Text = "Security";
            this.usersToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.windowsToolStripMenuItem_Click);
            // 
            // screensToolStripMenuItem
            // 
            this.screensToolStripMenuItem.Name = "screensToolStripMenuItem";
            this.screensToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.screensToolStripMenuItem.Text = "Screens";
            this.screensToolStripMenuItem.Click += new System.EventHandler(this.screensToolStripMenuItem_Click);
            // 
            // permissionsToolStripMenuItem
            // 
            this.permissionsToolStripMenuItem.Name = "permissionsToolStripMenuItem";
            this.permissionsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.permissionsToolStripMenuItem.Text = "Permissions";
            this.permissionsToolStripMenuItem.Click += new System.EventHandler(this.permissionsToolStripMenuItem_Click);
            // 
            // roleToolStripMenuItem
            // 
            this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            this.roleToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.roleToolStripMenuItem.Text = "Role";
            this.roleToolStripMenuItem.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // windowsStripMenuItem
            // 
            this.windowsStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.windowsStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.windowsStripMenuItem.Name = "windowsStripMenuItem";
            this.windowsStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.windowsStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.windowsStripMenuItem.Text = "Windows";
            this.windowsStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.windowsStripMenuItem.Click += new System.EventHandler(this.windowsStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnWarehouse);
            this.panel1.Controls.Add(this.btnSales);
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Controls.Add(this.btnPurchase);
            this.panel1.Controls.Add(this.btnClients);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 61);
            this.panel1.TabIndex = 2;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnUsers.ForeColor = System.Drawing.Color.Black;
            this.btnUsers.Image = global::Pharmacy.Properties.Resources.Users;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsers.Location = new System.Drawing.Point(802, 0);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(150, 61);
            this.btnUsers.TabIndex = 8;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.BackColor = System.Drawing.Color.Transparent;
            this.btnWarehouse.FlatAppearance.BorderSize = 0;
            this.btnWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehouse.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnWarehouse.ForeColor = System.Drawing.Color.Black;
            this.btnWarehouse.Image = global::Pharmacy.Properties.Resources.Warehouse;
            this.btnWarehouse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWarehouse.Location = new System.Drawing.Point(647, 0);
            this.btnWarehouse.Margin = new System.Windows.Forms.Padding(2);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(150, 61);
            this.btnWarehouse.TabIndex = 7;
            this.btnWarehouse.Text = "Warehouse";
            this.btnWarehouse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWarehouse.UseVisualStyleBackColor = false;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.Transparent;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSales.ForeColor = System.Drawing.Color.Black;
            this.btnSales.Image = global::Pharmacy.Properties.Resources.Sales;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSales.Location = new System.Drawing.Point(338, 0);
            this.btnSales.Margin = new System.Windows.Forms.Padding(2);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(150, 61);
            this.btnSales.TabIndex = 6;
            this.btnSales.Text = "Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSales.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnProducts.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnProducts.ForeColor = System.Drawing.Color.Black;
            this.btnProducts.Image = global::Pharmacy.Properties.Resources.Products;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProducts.Location = new System.Drawing.Point(184, 0);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(150, 61);
            this.btnProducts.TabIndex = 4;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnPurchase.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnPurchase.ForeColor = System.Drawing.Color.Black;
            this.btnPurchase.Image = global::Pharmacy.Properties.Resources.Purchase;
            this.btnPurchase.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPurchase.Location = new System.Drawing.Point(493, 0);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(2);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(150, 61);
            this.btnPurchase.TabIndex = 5;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.Transparent;
            this.btnClients.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnClients.ForeColor = System.Drawing.Color.Black;
            this.btnClients.Image = global::Pharmacy.Properties.Resources.Clients;
            this.btnClients.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClients.Location = new System.Drawing.Point(29, 0);
            this.btnClients.Margin = new System.Windows.Forms.Padding(2);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(150, 61);
            this.btnClients.TabIndex = 3;
            this.btnClients.Text = "Clients";
            this.btnClients.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.btnInsurance);
            this.panel2.Controls.Add(this.btnPurchaseReturn);
            this.panel2.Controls.Add(this.btnSalesReceipt);
            this.panel2.Controls.Add(this.btnClientsTests);
            this.panel2.Controls.Add(this.btnSalesReturn);
            this.panel2.Controls.Add(this.btnProductPromotion);
            this.panel2.Controls.Add(this.btnMedicalProducts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 597);
            this.panel2.TabIndex = 3;
            // 
            // btnInsurance
            // 
            this.btnInsurance.BackColor = System.Drawing.Color.Transparent;
            this.btnInsurance.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInsurance.FlatAppearance.BorderSize = 0;
            this.btnInsurance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsurance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnInsurance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnInsurance.Image = global::Pharmacy.Properties.Resources.Insurance;
            this.btnInsurance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInsurance.Location = new System.Drawing.Point(0, 503);
            this.btnInsurance.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsurance.Name = "btnInsurance";
            this.btnInsurance.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnInsurance.Size = new System.Drawing.Size(142, 69);
            this.btnInsurance.TabIndex = 15;
            this.btnInsurance.Text = "Insurance";
            this.btnInsurance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsurance.UseVisualStyleBackColor = false;
            this.btnInsurance.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnPurchaseReturn
            // 
            this.btnPurchaseReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnPurchaseReturn.FlatAppearance.BorderSize = 0;
            this.btnPurchaseReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseReturn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnPurchaseReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnPurchaseReturn.Image = global::Pharmacy.Properties.Resources.PurchaseReturn;
            this.btnPurchaseReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPurchaseReturn.Location = new System.Drawing.Point(0, 170);
            this.btnPurchaseReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnPurchaseReturn.Name = "btnPurchaseReturn";
            this.btnPurchaseReturn.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnPurchaseReturn.Size = new System.Drawing.Size(142, 69);
            this.btnPurchaseReturn.TabIndex = 10;
            this.btnPurchaseReturn.Text = "Purchase Return";
            this.btnPurchaseReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPurchaseReturn.UseVisualStyleBackColor = false;
            // 
            // btnSalesReceipt
            // 
            this.btnSalesReceipt.BackColor = System.Drawing.Color.Transparent;
            this.btnSalesReceipt.FlatAppearance.BorderSize = 0;
            this.btnSalesReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReceipt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSalesReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnSalesReceipt.Image = global::Pharmacy.Properties.Resources.Sales_Receipt;
            this.btnSalesReceipt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalesReceipt.Location = new System.Drawing.Point(0, 88);
            this.btnSalesReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalesReceipt.Name = "btnSalesReceipt";
            this.btnSalesReceipt.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnSalesReceipt.Size = new System.Drawing.Size(142, 69);
            this.btnSalesReceipt.TabIndex = 11;
            this.btnSalesReceipt.Text = "Sales Receipt";
            this.btnSalesReceipt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalesReceipt.UseVisualStyleBackColor = false;
            this.btnSalesReceipt.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnClientsTests
            // 
            this.btnClientsTests.BackColor = System.Drawing.Color.Transparent;
            this.btnClientsTests.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClientsTests.FlatAppearance.BorderSize = 0;
            this.btnClientsTests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientsTests.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnClientsTests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnClientsTests.Image = global::Pharmacy.Properties.Resources.Client_Tests;
            this.btnClientsTests.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientsTests.Location = new System.Drawing.Point(0, 420);
            this.btnClientsTests.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientsTests.Name = "btnClientsTests";
            this.btnClientsTests.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnClientsTests.Size = new System.Drawing.Size(142, 69);
            this.btnClientsTests.TabIndex = 14;
            this.btnClientsTests.Text = "Clients Tests";
            this.btnClientsTests.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientsTests.UseVisualStyleBackColor = false;
            // 
            // btnSalesReturn
            // 
            this.btnSalesReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnSalesReturn.FlatAppearance.BorderSize = 0;
            this.btnSalesReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReturn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSalesReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnSalesReturn.Image = global::Pharmacy.Properties.Resources.SalesReturn;
            this.btnSalesReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalesReturn.Location = new System.Drawing.Point(0, 253);
            this.btnSalesReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalesReturn.Name = "btnSalesReturn";
            this.btnSalesReturn.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnSalesReturn.Size = new System.Drawing.Size(142, 69);
            this.btnSalesReturn.TabIndex = 12;
            this.btnSalesReturn.Text = "Sales Return";
            this.btnSalesReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalesReturn.UseVisualStyleBackColor = false;
            // 
            // btnProductPromotion
            // 
            this.btnProductPromotion.BackColor = System.Drawing.Color.Transparent;
            this.btnProductPromotion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnProductPromotion.FlatAppearance.BorderSize = 0;
            this.btnProductPromotion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProductPromotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductPromotion.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnProductPromotion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnProductPromotion.Image = global::Pharmacy.Properties.Resources.ProductPromotion;
            this.btnProductPromotion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductPromotion.Location = new System.Drawing.Point(0, 5);
            this.btnProductPromotion.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductPromotion.Name = "btnProductPromotion";
            this.btnProductPromotion.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnProductPromotion.Size = new System.Drawing.Size(142, 69);
            this.btnProductPromotion.TabIndex = 9;
            this.btnProductPromotion.Text = " Product Promotion";
            this.btnProductPromotion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductPromotion.UseVisualStyleBackColor = false;
            // 
            // btnMedicalProducts
            // 
            this.btnMedicalProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnMedicalProducts.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMedicalProducts.FlatAppearance.BorderSize = 0;
            this.btnMedicalProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicalProducts.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnMedicalProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnMedicalProducts.Image = global::Pharmacy.Properties.Resources.MedicalProducts;
            this.btnMedicalProducts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMedicalProducts.Location = new System.Drawing.Point(0, 337);
            this.btnMedicalProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnMedicalProducts.Name = "btnMedicalProducts";
            this.btnMedicalProducts.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnMedicalProducts.Size = new System.Drawing.Size(142, 69);
            this.btnMedicalProducts.TabIndex = 13;
            this.btnMedicalProducts.Text = "Medical Products";
            this.btnMedicalProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMedicalProducts.UseVisualStyleBackColor = false;
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(942, 687);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStripMDI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMDI;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMDI";
            this.Text = "Pharmacy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMDI_FormClosed);
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStripMDI.ResumeLayout(false);
            this.menuStripMDI.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMDI;
        private System.Windows.Forms.ToolStripMenuItem healthCareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currenciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payementMethodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payementStatusToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProductPromotion;
        private System.Windows.Forms.Button btnPurchaseReturn;
        private System.Windows.Forms.Button btnSalesReceipt;
        private System.Windows.Forms.Button btnSalesReturn;
        private System.Windows.Forms.Button btnMedicalProducts;
        private System.Windows.Forms.Button btnClientsTests;
        private System.Windows.Forms.Button btnInsurance;
        private System.Windows.Forms.ToolStripMenuItem windowsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorSpecializationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
    }
}
