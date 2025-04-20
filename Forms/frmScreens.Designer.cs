using System;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
    partial class frmScreens
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScreens));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblScreenName = new System.Windows.Forms.Label();
            this.txtScreenName = new System.Windows.Forms.TextBox();
            this.lblScreenURL = new System.Windows.Forms.Label();
            this.txtScreenURL = new System.Windows.Forms.TextBox();
            this.dgvScreens = new System.Windows.Forms.DataGridView();
            this.ScreenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreenURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreens)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.Image = global::Pharmacy.Properties.Resources.Refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(9, 17);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnRefresh.Size = new System.Drawing.Size(75, 70);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.Image = global::Pharmacy.Properties.Resources.Update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(248, 17);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(0, 8, 0, 5);
            this.btnUpdate.Size = new System.Drawing.Size(75, 70);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.Image = global::Pharmacy.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(168, 17);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnDelete.Size = new System.Drawing.Size(75, 70);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.Image = global::Pharmacy.Properties.Resources.Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(88, 17);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnAdd.Size = new System.Drawing.Size(75, 70);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblScreenName
            // 
            this.lblScreenName.AutoSize = true;
            this.lblScreenName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblScreenName.Location = new System.Drawing.Point(10, 119);
            this.lblScreenName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScreenName.Name = "lblScreenName";
            this.lblScreenName.Size = new System.Drawing.Size(83, 15);
            this.lblScreenName.TabIndex = 22;
            this.lblScreenName.Text = "Screen Name :";
            // 
            // txtScreenName
            // 
            this.txtScreenName.BackColor = System.Drawing.Color.White;
            this.txtScreenName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtScreenName.Location = new System.Drawing.Point(103, 114);
            this.txtScreenName.Margin = new System.Windows.Forms.Padding(2);
            this.txtScreenName.Name = "txtScreenName";
            this.txtScreenName.Size = new System.Drawing.Size(217, 23);
            this.txtScreenName.TabIndex = 1;
            this.txtScreenName.TextChanged += new System.EventHandler(this.txtScreenName_TextChanged);
            // 
            // lblScreenURL
            // 
            this.lblScreenURL.AutoSize = true;
            this.lblScreenURL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblScreenURL.Location = new System.Drawing.Point(19, 152);
            this.lblScreenURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScreenURL.Name = "lblScreenURL";
            this.lblScreenURL.Size = new System.Drawing.Size(72, 15);
            this.lblScreenURL.TabIndex = 24;
            this.lblScreenURL.Text = "Screen URL :";
            // 
            // txtScreenURL
            // 
            this.txtScreenURL.BackColor = System.Drawing.Color.White;
            this.txtScreenURL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtScreenURL.Location = new System.Drawing.Point(103, 146);
            this.txtScreenURL.Margin = new System.Windows.Forms.Padding(2);
            this.txtScreenURL.Name = "txtScreenURL";
            this.txtScreenURL.Size = new System.Drawing.Size(217, 23);
            this.txtScreenURL.TabIndex = 2;
            this.txtScreenURL.TextChanged += new System.EventHandler(this.txtScreenURL_TextChanged);
            // 
            // dgvScreens
            // 
            this.dgvScreens.AllowUserToAddRows = false;
            this.dgvScreens.AllowUserToDeleteRows = false;
            this.dgvScreens.AllowUserToResizeColumns = false;
            this.dgvScreens.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvScreens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScreens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScreens.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvScreens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvScreens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScreens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvScreens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScreens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScreenName,
            this.ScreenURL,
            this.ScreenID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScreens.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvScreens.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvScreens.Location = new System.Drawing.Point(0, 189);
            this.dgvScreens.Name = "dgvScreens";
            this.dgvScreens.ReadOnly = true;
            this.dgvScreens.RowHeadersVisible = false;
            this.dgvScreens.RowHeadersWidth = 51;
            this.dgvScreens.Size = new System.Drawing.Size(332, 187);
            this.dgvScreens.TabIndex = 25;
            this.dgvScreens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScreens_CellContentClick);
            this.dgvScreens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScreens_CellDoubleClick);
            // 
            // ScreenName
            // 
            this.ScreenName.DataPropertyName = "ScreenName";
            this.ScreenName.HeaderText = "Screen Name";
            this.ScreenName.MinimumWidth = 6;
            this.ScreenName.Name = "ScreenName";
            this.ScreenName.ReadOnly = true;
            // 
            // ScreenURL
            // 
            this.ScreenURL.DataPropertyName = "ScreenURL";
            this.ScreenURL.HeaderText = "Screen URL";
            this.ScreenURL.MinimumWidth = 6;
            this.ScreenURL.Name = "ScreenURL";
            this.ScreenURL.ReadOnly = true;
            // 
            // ScreenID
            // 
            this.ScreenID.DataPropertyName = "ScreenID";
            this.ScreenID.HeaderText = "Screen ID";
            this.ScreenID.MinimumWidth = 6;
            this.ScreenID.Name = "ScreenID";
            this.ScreenID.ReadOnly = true;
            this.ScreenID.Visible = false;
            // 
            // frmScreens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(332, 376);
            this.Controls.Add(this.dgvScreens);
            this.Controls.Add(this.lblScreenURL);
            this.Controls.Add(this.txtScreenURL);
            this.Controls.Add(this.lblScreenName);
            this.Controls.Add(this.txtScreenName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScreens";
            this.Text = "Screens";
            this.Load += new System.EventHandler(this.frmScreens_Load);
           // this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmScreens_KeyDown);
           // this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmScreens_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblScreenName;
        private System.Windows.Forms.TextBox txtScreenName;
        private System.Windows.Forms.Label lblScreenURL;
        private System.Windows.Forms.TextBox txtScreenURL;
        private System.Windows.Forms.DataGridView dgvScreens;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenID;
    }
}