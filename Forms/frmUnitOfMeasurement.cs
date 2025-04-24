using System;
using System.Data;
using System.Windows.Forms;
using Pharmacy.Classes;

namespace Pharmacy.Forms
{
    public partial class frmUnitOfMeasurement : Form
    {
        private int selectedUnitID = -1;

        public frmUnitOfMeasurement()
        {
            InitializeComponent();
            
            dgvUnits.AutoGenerateColumns = false;
            LoadUnits();
            ClearInputs();
        }

        private void frmUnitOfMeasurement_Load(object sender, EventArgs e)
        {
            LoadUnits();
            ClearInputs();
        }

        private void LoadUnits()
        {
            try
            {
                DataTable dt = new UnitOfMeasurement().SELECT();
                dgvUnits.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading units: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txtUnitName.Clear();
            txtUnitSymbol.Clear();
            selectedUnitID = -1;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dgvUnits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUnits.Rows[e.RowIndex];
                selectedUnitID = Convert.ToInt32(row.Cells["UnitIDCol"].Value);
                txtUnitName.Text = row.Cells["UnitNameCol"].Value.ToString();
                txtUnitSymbol.Text = row.Cells["UnitSymbolCol"].Value.ToString();

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var unit = new UnitOfMeasurement(0, txtUnitName.Text.Trim(), txtUnitSymbol.Text.Trim(), 0);
                unit.INSERT();
                
                LoadUnits();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding unit: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUnitID == -1)
            {
                MessageBox.Show("No unit selected.");
                return;
            }

            try
            {
                var unit = new UnitOfMeasurement(selectedUnitID, txtUnitName.Text.Trim(), txtUnitSymbol.Text.Trim(), 0);
                unit.UPDATE();
                
                LoadUnits();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating unit: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUnitID == -1)
            {
                MessageBox.Show("No unit selected.");
                return;
            }

            try
            {
                var unit = new UnitOfMeasurement { UnitID = selectedUnitID };
                unit.DELETE();
                
                LoadUnits();
                ClearInputs();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_"))
                    MessageBox.Show("Cannot delete this unit because it is linked to other records.");
                else
                    MessageBox.Show("Error deleting unit: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUnits();
            ClearInputs();
        }

        
    }
}
