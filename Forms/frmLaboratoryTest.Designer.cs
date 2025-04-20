using System.Windows.Forms;

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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.dgvTests = new System.Windows.Forms.DataGridView();
            this.LabTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabTestDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabTestPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinHealthyRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxHealthyRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabTestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
            this.SuspendLayout();

            // Labels and TextBoxes positions
            int lblX = 12, txtX = 110, topBase = 95, spacing = 27;

            this.lblName.Location = new System.Drawing.Point(lblX, topBase);
            this.lblName.Size = new System.Drawing.Size(100, 15);
            this.lblName.Text = "Test Name:";

            this.txtName.Location = new System.Drawing.Point(txtX, topBase);
            this.txtName.Size = new System.Drawing.Size(217, 21);

            this.lblDesc.Location = new System.Drawing.Point(lblX, topBase + spacing);
            this.lblDesc.Size = new System.Drawing.Size(100, 15);
            this.lblDesc.Text = "Description:";

            this.txtDesc.Location = new System.Drawing.Point(txtX, topBase + spacing);
            this.txtDesc.Size = new System.Drawing.Size(217, 21);

            this.lblPrice.Location = new System.Drawing.Point(lblX, topBase + spacing * 2);
            this.lblPrice.Size = new System.Drawing.Size(100, 15);
            this.lblPrice.Text = "Price:";

            this.txtPrice.Location = new System.Drawing.Point(txtX, topBase + spacing * 2);
            this.txtPrice.Size = new System.Drawing.Size(217, 21);

            this.lblMin.Location = new System.Drawing.Point(lblX, topBase + spacing * 3);
            this.lblMin.Size = new System.Drawing.Size(100, 15);
            this.lblMin.Text = "Min Range:";

            this.txtMin.Location = new System.Drawing.Point(txtX, topBase + spacing * 3);
            this.txtMin.Size = new System.Drawing.Size(217, 21);

            this.lblMax.Location = new System.Drawing.Point(lblX, topBase + spacing * 4);
            this.lblMax.Size = new System.Drawing.Size(100, 15);
            this.lblMax.Text = "Max Range:";

            this.txtMax.Location = new System.Drawing.Point(txtX, topBase + spacing * 4);
            this.txtMax.Size = new System.Drawing.Size(217, 21);

            this.lblUnit.Location = new System.Drawing.Point(lblX, topBase + spacing * 5);
            this.lblUnit.Size = new System.Drawing.Size(100, 15);
            this.lblUnit.Text = "Unit ID:";

            this.txtUnit.Location = new System.Drawing.Point(txtX, topBase + spacing * 5);
            this.txtUnit.Size = new System.Drawing.Size(217, 21);

            // DataGridView
            this.dgvTests.AllowUserToAddRows = false;
            this.dgvTests.AllowUserToDeleteRows = false;
            this.dgvTests.AllowUserToResizeColumns = false;
            this.dgvTests.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvTests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTests.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.LabTestName,
                this.LabTestDescription,
                this.LabTestPrice,
                this.MinHealthyRange,
                this.MaxHealthyRange,
                this.UnitID,
                this.LabTestID });
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvTests.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTests.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTests.Location = new System.Drawing.Point(0, 250);
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.ReadOnly = true;
            this.dgvTests.RowHeadersVisible = false;
            this.dgvTests.Size = new System.Drawing.Size(340, 190);
            this.dgvTests.TabIndex = 0;
            this.dgvTests.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTests_CellDoubleClick);

            // Columns
            this.LabTestName.DataPropertyName = "LabTestName";
            this.LabTestName.HeaderText = "Test Name";
            this.LabTestName.Name = "LabTestName";
            this.LabTestName.ReadOnly = true;

            this.LabTestDescription.DataPropertyName = "LabTestDescription";
            this.LabTestDescription.HeaderText = "Description";
            this.LabTestDescription.Name = "LabTestDescription";
            this.LabTestDescription.ReadOnly = true;

            this.LabTestPrice.DataPropertyName = "LabTestPrice";
            this.LabTestPrice.HeaderText = "Price";
            this.LabTestPrice.Name = "LabTestPrice";
            this.LabTestPrice.ReadOnly = true;

            this.MinHealthyRange.DataPropertyName = "MinHealthyRange";
            this.MinHealthyRange.HeaderText = "Min Range";
            this.MinHealthyRange.Name = "MinHealthyRange";
            this.MinHealthyRange.ReadOnly = true;

            this.MaxHealthyRange.DataPropertyName = "MaxHealthyRange";
            this.MaxHealthyRange.HeaderText = "Max Range";
            this.MaxHealthyRange.Name = "MaxHealthyRange";
            this.MaxHealthyRange.ReadOnly = true;

            this.UnitID.DataPropertyName = "UnitID";
            this.UnitID.HeaderText = "Unit ID";
            this.UnitID.Name = "UnitID";
            this.UnitID.ReadOnly = true;

            this.LabTestID.DataPropertyName = "LabTestID";
            this.LabTestID.HeaderText = "ID";
            this.LabTestID.Name = "LabTestID";
            this.LabTestID.ReadOnly = true;
            this.LabTestID.Visible = false;

            // Buttons
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();

            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Image = global::Pharmacy.Properties.Resources.Refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.Location = new System.Drawing.Point(7, 12);
            this.btnRefresh.Size = new System.Drawing.Size(75, 70);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnAdd.Text = "Add";
            this.btnAdd.Image = global::Pharmacy.Properties.Resources.Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.Location = new System.Drawing.Point(88, 12);
            this.btnAdd.Size = new System.Drawing.Size(75, 70);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.Image = global::Pharmacy.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.Location = new System.Drawing.Point(169, 12);
            this.btnDelete.Size = new System.Drawing.Size(75, 70);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnUpdate.Text = "Update";
            this.btnUpdate.Image = global::Pharmacy.Properties.Resources.Update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.Location = new System.Drawing.Point(250, 12);
            this.btnUpdate.Size = new System.Drawing.Size(75, 70);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // frmLaboratoryTest
            this.ClientSize = new System.Drawing.Size(340, 440);
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.dgvTests);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLaboratoryTest";
            this.Text = "Laboratory Tests";
            this.Load += new System.EventHandler(this.frmLaboratoryTest_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLaboratoryTest_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblUnit;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtUnit;

        private System.Windows.Forms.DataGridView dgvTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabTestDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabTestPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinHealthyRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxHealthyRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabTestID;

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}
