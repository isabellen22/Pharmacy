using System.Windows.Forms;

namespace Pharmacy.Forms
{
    partial class frmUnitOfMeasurement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnitOfMeasurement));
            this.lblUnitName = new System.Windows.Forms.Label();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.lblUnitSymbol = new System.Windows.Forms.Label();
            this.txtUnitSymbol = new System.Windows.Forms.TextBox();
            this.dgvUnits = new System.Windows.Forms.DataGridView();
            this.UnitNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitSymbolCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Location = new System.Drawing.Point(8, 118);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(69, 15);
            this.lblUnitName.TabIndex = 4;
            this.lblUnitName.Text = "Unit Name:";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(103, 115);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(217, 21);
            this.txtUnitName.TabIndex = 3;
            // 
            // lblUnitSymbol
            // 
            this.lblUnitSymbol.AutoSize = true;
            this.lblUnitSymbol.Location = new System.Drawing.Point(8, 150);
            this.lblUnitSymbol.Name = "lblUnitSymbol";
            this.lblUnitSymbol.Size = new System.Drawing.Size(76, 15);
            this.lblUnitSymbol.TabIndex = 2;
            this.lblUnitSymbol.Text = "Unit Symbol:";
            // 
            // txtUnitSymbol
            // 
            this.txtUnitSymbol.Location = new System.Drawing.Point(103, 147);
            this.txtUnitSymbol.Name = "txtUnitSymbol";
            this.txtUnitSymbol.Size = new System.Drawing.Size(217, 21);
            this.txtUnitSymbol.TabIndex = 1;
            // 
            // dgvUnits
            // 
            this.dgvUnits.AllowUserToAddRows = false;
            this.dgvUnits.AllowUserToDeleteRows = false;
            this.dgvUnits.AllowUserToResizeColumns = false;
            this.dgvUnits.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvUnits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnits.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvUnits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUnits.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnitNameCol,
            this.UnitSymbolCol,
            this.UnitIDCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnits.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUnits.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUnits.Location = new System.Drawing.Point(0, 189);
            this.dgvUnits.Name = "dgvUnits";
            this.dgvUnits.ReadOnly = true;
            this.dgvUnits.RowHeadersVisible = false;
            this.dgvUnits.Size = new System.Drawing.Size(332, 187);
            this.dgvUnits.TabIndex = 0;
            this.dgvUnits.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnits_CellDoubleClick);
            // 
            // UnitNameCol
            // 
            this.UnitNameCol.DataPropertyName = "UnitName";
            this.UnitNameCol.HeaderText = "Unit Name";
            this.UnitNameCol.Name = "UnitNameCol";
            this.UnitNameCol.ReadOnly = true;
            // 
            // UnitSymbolCol
            // 
            this.UnitSymbolCol.DataPropertyName = "UnitSymbol";
            this.UnitSymbolCol.HeaderText = "Symbol";
            this.UnitSymbolCol.Name = "UnitSymbolCol";
            this.UnitSymbolCol.ReadOnly = true;
            // 
            // UnitIDCol
            // 
            this.UnitIDCol.DataPropertyName = "UnitID";
            this.UnitIDCol.HeaderText = "ID";
            this.UnitIDCol.Name = "UnitIDCol";
            this.UnitIDCol.ReadOnly = true;
            this.UnitIDCol.Visible = false;
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
            // frmUnitOfMeasurement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(332, 376);
            this.Controls.Add(this.dgvUnits);
            this.Controls.Add(this.txtUnitSymbol);
            this.Controls.Add(this.lblUnitSymbol);
            this.Controls.Add(this.txtUnitName);
            this.Controls.Add(this.lblUnitName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUnitOfMeasurement";
            this.Text = "Units";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Label lblUnitSymbol;
        private System.Windows.Forms.TextBox txtUnitSymbol;
        private System.Windows.Forms.DataGridView dgvUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitSymbolCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitIDCol;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
       
    }
}
