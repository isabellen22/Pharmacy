namespace Pharmacy.Forms
{
    partial class frmPermissions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermissions));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.cmbScreen = new System.Windows.Forms.ComboBox();
            this.cbCanView = new System.Windows.Forms.CheckBox();
            this.cbCanDelete = new System.Windows.Forms.CheckBox();
            this.cbCanAdd = new System.Windows.Forms.CheckBox();
            this.cbCanEdit = new System.Windows.Forms.CheckBox();
            this.dgvPermissions = new System.Windows.Forms.DataGridView();
            this.RoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSelectRole = new System.Windows.Forms.Label();
            this.lblSelectScreen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::Pharmacy.Properties.Resources.Refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(10, 18);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnRefresh.Size = new System.Drawing.Size(75, 70);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::Pharmacy.Properties.Resources.Update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(249, 18);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(0, 8, 0, 5);
            this.btnUpdate.Size = new System.Drawing.Size(75, 70);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::Pharmacy.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(169, 18);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnDelete.Size = new System.Drawing.Size(75, 70);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::Pharmacy.Properties.Resources.Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(89, 18);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnAdd.Size = new System.Drawing.Size(75, 70);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownWidth = 180;
            this.cmbRole.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.IntegralHeight = false;
            this.cmbRole.Location = new System.Drawing.Point(169, 115);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(136, 24);
            this.cmbRole.TabIndex = 29;
            this.cmbRole.Text = "Role";
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            // 
            // cmbScreen
            // 
            this.cmbScreen.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbScreen.FormattingEnabled = true;
            this.cmbScreen.Location = new System.Drawing.Point(169, 164);
            this.cmbScreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbScreen.Name = "cmbScreen";
            this.cmbScreen.Size = new System.Drawing.Size(136, 24);
            this.cmbScreen.TabIndex = 30;
            this.cmbScreen.Text = "Screen";
            this.cmbScreen.SelectedIndexChanged += new System.EventHandler(this.smbScreen_SelectedIndexChanged);
            // 
            // cbCanView
            // 
            this.cbCanView.AutoSize = true;
            this.cbCanView.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCanView.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCanView.Location = new System.Drawing.Point(31, 100);
            this.cbCanView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCanView.Name = "cbCanView";
            this.cbCanView.Size = new System.Drawing.Size(96, 21);
            this.cbCanView.TabIndex = 31;
            this.cbCanView.Text = "Can View";
            this.cbCanView.UseVisualStyleBackColor = true;
            this.cbCanView.CheckedChanged += new System.EventHandler(this.cbCanView_CheckedChanged);
            // 
            // cbCanDelete
            // 
            this.cbCanDelete.AutoSize = true;
            this.cbCanDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCanDelete.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCanDelete.Location = new System.Drawing.Point(30, 175);
            this.cbCanDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCanDelete.Name = "cbCanDelete";
            this.cbCanDelete.Size = new System.Drawing.Size(109, 21);
            this.cbCanDelete.TabIndex = 32;
            this.cbCanDelete.Text = "Can Delete";
            this.cbCanDelete.UseVisualStyleBackColor = true;
            this.cbCanDelete.CheckedChanged += new System.EventHandler(this.cbCanDelete_CheckedChanged);
            // 
            // cbCanAdd
            // 
            this.cbCanAdd.AutoSize = true;
            this.cbCanAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCanAdd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCanAdd.Location = new System.Drawing.Point(30, 150);
            this.cbCanAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCanAdd.Name = "cbCanAdd";
            this.cbCanAdd.Size = new System.Drawing.Size(89, 21);
            this.cbCanAdd.TabIndex = 33;
            this.cbCanAdd.Text = "Can Add";
            this.cbCanAdd.UseVisualStyleBackColor = true;
            this.cbCanAdd.CheckedChanged += new System.EventHandler(this.cbCanAdd_CheckedChanged);
            // 
            // cbCanEdit
            // 
            this.cbCanEdit.AutoSize = true;
            this.cbCanEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCanEdit.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCanEdit.Location = new System.Drawing.Point(30, 125);
            this.cbCanEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCanEdit.Name = "cbCanEdit";
            this.cbCanEdit.Size = new System.Drawing.Size(90, 21);
            this.cbCanEdit.TabIndex = 34;
            this.cbCanEdit.Text = "Can Edit";
            this.cbCanEdit.UseVisualStyleBackColor = true;
            this.cbCanEdit.CheckedChanged += new System.EventHandler(this.cbCanEdit_CheckedChanged);
            // 
            // dgvPermissions
            // 
            this.dgvPermissions.AllowUserToAddRows = false;
            this.dgvPermissions.AllowUserToDeleteRows = false;
            this.dgvPermissions.AllowUserToResizeColumns = false;
            this.dgvPermissions.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvPermissions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPermissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPermissions.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvPermissions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPermissions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPermissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoleID,
            this.ScreenID,
            this.CanView,
            this.CanEdit,
            this.CanAdd,
            this.CanDelete});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPermissions.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPermissions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPermissions.Location = new System.Drawing.Point(0, 222);
            this.dgvPermissions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPermissions.Name = "dgvPermissions";
            this.dgvPermissions.ReadOnly = true;
            this.dgvPermissions.RowHeadersVisible = false;
            this.dgvPermissions.RowHeadersWidth = 51;
            this.dgvPermissions.RowTemplate.Height = 24;
            this.dgvPermissions.Size = new System.Drawing.Size(339, 187);
            this.dgvPermissions.TabIndex = 35;
            this.dgvPermissions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermissions_CellContentClick);
            this.dgvPermissions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermissions_CellContentDoubleClick);
            // 
            // RoleID
            // 
            this.RoleID.DataPropertyName = "RoleID";
            this.RoleID.HeaderText = "Role ID";
            this.RoleID.MinimumWidth = 6;
            this.RoleID.Name = "RoleID";
            this.RoleID.ReadOnly = true;
            // 
            // ScreenID
            // 
            this.ScreenID.DataPropertyName = "ScreenID";
            this.ScreenID.HeaderText = "Screen ID";
            this.ScreenID.MinimumWidth = 6;
            this.ScreenID.Name = "ScreenID";
            this.ScreenID.ReadOnly = true;
            // 
            // CanView
            // 
            this.CanView.DataPropertyName = "CanView";
            this.CanView.HeaderText = "Can View";
            this.CanView.MinimumWidth = 6;
            this.CanView.Name = "CanView";
            this.CanView.ReadOnly = true;
            // 
            // CanEdit
            // 
            this.CanEdit.DataPropertyName = "CanEdit";
            this.CanEdit.HeaderText = "Can Edit";
            this.CanEdit.MinimumWidth = 6;
            this.CanEdit.Name = "CanEdit";
            this.CanEdit.ReadOnly = true;
            // 
            // CanAdd
            // 
            this.CanAdd.DataPropertyName = "CanAdd";
            this.CanAdd.HeaderText = "Can Add";
            this.CanAdd.MinimumWidth = 6;
            this.CanAdd.Name = "CanAdd";
            this.CanAdd.ReadOnly = true;
            // 
            // CanDelete
            // 
            this.CanDelete.DataPropertyName = "CanDelete";
            this.CanDelete.HeaderText = "Can Delete";
            this.CanDelete.MinimumWidth = 6;
            this.CanDelete.Name = "CanDelete";
            this.CanDelete.ReadOnly = true;
            // 
            // lblSelectRole
            // 
            this.lblSelectRole.AutoSize = true;
            this.lblSelectRole.Location = new System.Drawing.Point(166, 100);
            this.lblSelectRole.Name = "lblSelectRole";
            this.lblSelectRole.Size = new System.Drawing.Size(63, 13);
            this.lblSelectRole.TabIndex = 36;
            this.lblSelectRole.Text = "Select role :";
            this.lblSelectRole.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSelectScreen
            // 
            this.lblSelectScreen.AutoSize = true;
            this.lblSelectScreen.Location = new System.Drawing.Point(166, 149);
            this.lblSelectScreen.Name = "lblSelectScreen";
            this.lblSelectScreen.Size = new System.Drawing.Size(78, 13);
            this.lblSelectScreen.TabIndex = 37;
            this.lblSelectScreen.Text = "Select screen :";
            // 
            // frmPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(339, 409);
            this.Controls.Add(this.lblSelectScreen);
            this.Controls.Add(this.lblSelectRole);
            this.Controls.Add(this.dgvPermissions);
            this.Controls.Add(this.cbCanEdit);
            this.Controls.Add(this.cbCanAdd);
            this.Controls.Add(this.cbCanDelete);
            this.Controls.Add(this.cbCanView);
            this.Controls.Add(this.cmbScreen);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPermissions";
            this.Text = "Permissions";
            this.Load += new System.EventHandler(this.frmPermissions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.ComboBox cmbScreen;
        private System.Windows.Forms.CheckBox cbCanView;
        private System.Windows.Forms.CheckBox cbCanDelete;
        private System.Windows.Forms.CheckBox cbCanAdd;
        private System.Windows.Forms.CheckBox cbCanEdit;
        private System.Windows.Forms.DataGridView dgvPermissions;
        private System.Windows.Forms.Label lblSelectRole;
        private System.Windows.Forms.Label lblSelectScreen;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanDelete;
    }
}