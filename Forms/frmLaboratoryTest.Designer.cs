// Updated frmLaboratoryTest.Designer.cs matching frmCountry layout

using System.Windows.Forms;
using System.Drawing;

namespace Pharmacy.Forms
{
    partial class frmLaboratoryTest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaboratoryTest));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMinRange = new System.Windows.Forms.TextBox();
            this.txtMaxRange = new System.Windows.Forms.TextBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.dgvLabTests = new System.Windows.Forms.DataGridView();
            this.LabTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabTestDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabTestPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinHealthyRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxHealthyRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabTestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabTests)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::Pharmacy.Properties.Resources.Refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(7, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnRefresh.Size = new System.Drawing.Size(75, 70);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::Pharmacy.Properties.Resources.Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(88, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnAdd.Size = new System.Drawing.Size(75, 70);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::Pharmacy.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(169, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnDelete.Size = new System.Drawing.Size(75, 70);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::Pharmacy.Properties.Resources.Update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(250, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnUpdate.Size = new System.Drawing.Size(75, 70);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(7, 87);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(7, 113);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 20);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(7, 139);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(86, 20);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price:";
            // 
            // lblMin
            // 
            this.lblMin.Location = new System.Drawing.Point(7, 165);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(86, 20);
            this.lblMin.TabIndex = 7;
            this.lblMin.Text = "Min Range:";
            // 
            // lblMax
            // 
            this.lblMax.Location = new System.Drawing.Point(7, 191);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(86, 20);
            this.lblMax.TabIndex = 8;
            this.lblMax.Text = "Max Range:";
            // 
            // lblUnit
            // 
            this.lblUnit.Location = new System.Drawing.Point(7, 217);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(86, 20);
            this.lblUnit.TabIndex = 9;
            this.lblUnit.Text = "Unit:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 20);
            this.txtName.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(99, 113);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(226, 20);
            this.txtDescription.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(99, 139);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(226, 20);
            this.txtPrice.TabIndex = 12;
            // 
            // txtMinRange
            // 
            this.txtMinRange.Location = new System.Drawing.Point(99, 165);
            this.txtMinRange.Name = "txtMinRange";
            this.txtMinRange.Size = new System.Drawing.Size(226, 20);
            this.txtMinRange.TabIndex = 13;
            // 
            // txtMaxRange
            // 
            this.txtMaxRange.Location = new System.Drawing.Point(99, 191);
            this.txtMaxRange.Name = "txtMaxRange";
            this.txtMaxRange.Size = new System.Drawing.Size(226, 20);
            this.txtMaxRange.TabIndex = 14;
            // 
            // cmbUnit
            // 
            this.cmbUnit.Location = new System.Drawing.Point(99, 217);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(226, 21);
            this.cmbUnit.TabIndex = 15;
            // 
            // dgvLabTests
            // 
            this.dgvLabTests.AllowUserToAddRows = false;
            this.dgvLabTests.AllowUserToDeleteRows = false;
            this.dgvLabTests.AllowUserToResizeColumns = false;
            this.dgvLabTests.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvLabTests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLabTests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLabTests.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvLabTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLabTests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLabTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLabTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LabTestName,
            this.LabTestDescription,
            this.LabTestPrice,
            this.MinHealthyRange,
            this.MaxHealthyRange,
            this.UnitName,
            this.LabTestID,
            this.UnitID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLabTests.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLabTests.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLabTests.Location = new System.Drawing.Point(0, 254);
            this.dgvLabTests.Name = "dgvLabTests";
            this.dgvLabTests.ReadOnly = true;
            this.dgvLabTests.RowHeadersVisible = false;
            this.dgvLabTests.Size = new System.Drawing.Size(348, 147);
            this.dgvLabTests.TabIndex = 16;
            this.dgvLabTests.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLabTests_CellDoubleClick);
            // 
            // LabTestName
            // 
            this.LabTestName.DataPropertyName = "LabTestName";
            this.LabTestName.HeaderText = "Test";
            this.LabTestName.Name = "LabTestName";
            this.LabTestName.ReadOnly = true;
            // 
            // LabTestDescription
            // 
            this.LabTestDescription.DataPropertyName = "LabTestDescription";
            this.LabTestDescription.HeaderText = "Description";
            this.LabTestDescription.Name = "LabTestDescription";
            this.LabTestDescription.ReadOnly = true;
            // 
            // LabTestPrice
            // 
            this.LabTestPrice.DataPropertyName = "LabTestPrice";
            this.LabTestPrice.HeaderText = "Price";
            this.LabTestPrice.Name = "LabTestPrice";
            this.LabTestPrice.ReadOnly = true;
            // 
            // MinHealthyRange
            // 
            this.MinHealthyRange.DataPropertyName = "MinHealthyRange";
            this.MinHealthyRange.HeaderText = "Min";
            this.MinHealthyRange.Name = "MinHealthyRange";
            this.MinHealthyRange.ReadOnly = true;
            // 
            // MaxHealthyRange
            // 
            this.MaxHealthyRange.DataPropertyName = "MaxHealthyRange";
            this.MaxHealthyRange.HeaderText = "Max";
            this.MaxHealthyRange.Name = "MaxHealthyRange";
            this.MaxHealthyRange.ReadOnly = true;
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "Unit";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            // 
            // LabTestID
            // 
            this.LabTestID.DataPropertyName = "LabTestID";
            this.LabTestID.Name = "LabTestID";
            this.LabTestID.ReadOnly = true;
            this.LabTestID.Visible = false;
            // 
            // UnitID
            // 
            this.UnitID.DataPropertyName = "UnitID";
            this.UnitID.Name = "UnitID";
            this.UnitID.ReadOnly = true;
            this.UnitID.Visible = false;
            // 
            // frmLaboratoryTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(348, 401);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMinRange);
            this.Controls.Add(this.txtMaxRange);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.dgvLabTests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLaboratoryTest";
            this.Text = "Laboratory Test";
            this.Load += new System.EventHandler(this.frmLaboratoryTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabTests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRefresh;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Label lblName;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblMin;
        private Label lblMax;
        private Label lblUnit;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private TextBox txtMinRange;
        private TextBox txtMaxRange;
        private ComboBox cmbUnit;
        private DataGridView dgvLabTests;
        private DataGridViewTextBoxColumn LabTestName;
        private DataGridViewTextBoxColumn LabTestDescription;
        private DataGridViewTextBoxColumn LabTestPrice;
        private DataGridViewTextBoxColumn MinHealthyRange;
        private DataGridViewTextBoxColumn MaxHealthyRange;
        private DataGridViewTextBoxColumn UnitName;
        private DataGridViewTextBoxColumn LabTestID;
        private DataGridViewTextBoxColumn UnitID;
    }
}
