using System.Windows.Forms;

namespace Pharmacy.Forms
{
    partial class frmLaboratory
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.DataGridView dgvLaboratory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaboratory));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dgvLaboratory = new System.Windows.Forms.DataGridView();
            this.LabName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaboratoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Lab Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 115);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 21);
            this.txtName.TabIndex = 4;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(20, 150);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(57, 15);
            this.lblLocation.TabIndex = 6;
            this.lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(115, 147);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(217, 21);
            this.txtLocation.TabIndex = 5;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(16, 180);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(100, 15);
            this.lblContact.TabIndex = 6;
            this.lblContact.Text = "Contact Number:";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(115, 177);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(217, 21);
            this.txtContact.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 210);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(115, 207);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(217, 21);
            this.txtEmail.TabIndex = 7;
            // 
            // dgvLaboratory
            // 
            this.dgvLaboratory.AllowUserToAddRows = false;
            this.dgvLaboratory.AllowUserToDeleteRows = false;
            this.dgvLaboratory.AllowUserToResizeColumns = false;
            this.dgvLaboratory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvLaboratory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLaboratory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLaboratory.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvLaboratory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLaboratory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLaboratory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaboratory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LabName,
            this.LabLocation,
            this.LabContact,
            this.LabEmail,
            this.LaboratoryID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLaboratory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLaboratory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLaboratory.Location = new System.Drawing.Point(0, 245);
            this.dgvLaboratory.Name = "dgvLaboratory";
            this.dgvLaboratory.ReadOnly = true;
            this.dgvLaboratory.RowHeadersVisible = false;
            this.dgvLaboratory.Size = new System.Drawing.Size(365, 187);
            this.dgvLaboratory.TabIndex = 8;
            this.dgvLaboratory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLaboratory_CellDoubleClick);
            // 
            // LabName
            // 
            this.LabName.DataPropertyName = "LabName";
            this.LabName.HeaderText = "Lab Name";
            this.LabName.Name = "LabName";
            this.LabName.ReadOnly = true;
            // 
            // LabLocation
            // 
            this.LabLocation.DataPropertyName = "LabLocation";
            this.LabLocation.HeaderText = "Location";
            this.LabLocation.Name = "LabLocation";
            this.LabLocation.ReadOnly = true;
            // 
            // LabContact
            // 
            this.LabContact.DataPropertyName = "LabContactNB";
            this.LabContact.HeaderText = "Contact Number";
            this.LabContact.Name = "LabContact";
            this.LabContact.ReadOnly = true;
            // 
            // LabEmail
            // 
            this.LabEmail.DataPropertyName = "LabEmail";
            this.LabEmail.HeaderText = "Email";
            this.LabEmail.Name = "LabEmail";
            this.LabEmail.ReadOnly = true;
            // 
            // LaboratoryID
            // 
            this.LaboratoryID.DataPropertyName = "LaboratoryID";
            this.LaboratoryID.HeaderText = "ID";
            this.LaboratoryID.Name = "LaboratoryID";
            this.LaboratoryID.ReadOnly = true;
            this.LaboratoryID.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F);
            this.btnUpdate.Image = global::Pharmacy.Properties.Resources.Update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(262, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnUpdate.Size = new System.Drawing.Size(75, 70);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F);
            this.btnDelete.Image = global::Pharmacy.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(181, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnDelete.Size = new System.Drawing.Size(75, 70);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F);
            this.btnAdd.Image = global::Pharmacy.Properties.Resources.Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(100, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnAdd.Size = new System.Drawing.Size(75, 70);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 9F);
            this.btnRefresh.Image = global::Pharmacy.Properties.Resources.Refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(19, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnRefresh.Size = new System.Drawing.Size(75, 70);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmLaboratory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(365, 432);
            this.Controls.Add(this.dgvLaboratory);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLaboratory";
            this.Text = "Laboratory";
            this.Load += new System.EventHandler(this.frmLaboratory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DataGridViewTextBoxColumn LabName;
        private DataGridViewTextBoxColumn LabLocation;
        private DataGridViewTextBoxColumn LabContactNB;
        private DataGridViewTextBoxColumn LabContact;
        private DataGridViewTextBoxColumn LabEmail;
        private DataGridViewTextBoxColumn LaboratoryID;
    }
}
