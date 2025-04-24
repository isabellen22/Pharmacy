using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Pharmacy.Classes;
using Pharmacy.Classes.UsefullClasses;

namespace Pharmacy.Forms
{
    public partial class frmLaboratoryTest : Form
    {
        private int selectedTestID = -1;

        public frmLaboratoryTest()
        {
            InitializeComponent();
            dgvLabTests.AutoGenerateColumns = false;
        }

        private void frmLaboratoryTest_Load(object sender, EventArgs e)
        {
            LoadUnits();
            LoadLabTests(); // or whatever your main data loading method is
            ClearInputs();
        }

        
        private void LoadUnits()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT UnitID, UnitName FROM tblUnitOfMeasurement ORDER BY UnitName", con))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        cmbUnit.DataSource = dt;
                        cmbUnit.DisplayMember = "UnitName";
                        cmbUnit.ValueMember = "UnitID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading units: " + ex.Message);
            }
        }

        private void LoadLabTests()
        {
            try
            {
                // Step 1: Load lab tests and units
                DataTable labTests = new LaboratoryTest(0, "", "", 0, 0, 0, 0).SELECT();
                DataTable units = new UnitOfMeasurement().SELECT();

                // Step 2: Add UnitName column to labTests
                if (!labTests.Columns.Contains("UnitName"))
                    labTests.Columns.Add("UnitName", typeof(string));

                foreach (DataRow row in labTests.Rows)
                {
                    var matchingUnit = units.Rows
                        .Cast<DataRow>()
                        .FirstOrDefault(u => Convert.ToInt32(u["UnitID"]) == Convert.ToInt32(row["UnitID"]));

                    row["UnitName"] = matchingUnit != null ? matchingUnit["UnitName"].ToString() : "";
                }

                // Step 3: Bind to grid
                dgvLabTests.DataSource = labTests;

                // Step 4: Optional formatting
                dgvLabTests.Columns["LabTestPrice"].DefaultCellStyle.Format = "N2";
                dgvLabTests.Columns["MinHealthyRange"].DefaultCellStyle.Format = "N2";
                dgvLabTests.Columns["MaxHealthyRange"].DefaultCellStyle.Format = "N2";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading lab tests: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtMinRange.Clear();
            txtMaxRange.Clear();
            cmbUnit.SelectedIndex = -1;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            selectedTestID = -1;
        }

        private void dgvLabTests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLabTests.Rows[e.RowIndex];
                selectedTestID = Convert.ToInt32(row.Cells["LabTestID"].Value);
                txtName.Text = row.Cells["LabTestName"].Value.ToString();
                txtDescription.Text = row.Cells["LabTestDescription"].Value.ToString();
                txtPrice.Text = row.Cells["LabTestPrice"].Value.ToString();
                txtMinRange.Text = row.Cells["MinHealthyRange"].Value.ToString();
                txtMaxRange.Text = row.Cells["MaxHealthyRange"].Value.ToString();
                cmbUnit.SelectedValue = Convert.ToInt32(row.Cells["UnitID"].Value);

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtPrice.Text, out decimal price) ||
                    !decimal.TryParse(txtMinRange.Text, out decimal minRange) ||
                    !decimal.TryParse(txtMaxRange.Text, out decimal maxRange))
                {
                    MessageBox.Show("Please enter valid numeric values for price and ranges.");
                    return;
                }

                if (cmbUnit.SelectedValue == null)
                {
                    MessageBox.Show("Please select a unit.");
                    return;
                }

                var test = new LaboratoryTest(
                    0,
                    txtName.Text.Trim(),
                    txtDescription.Text.Trim(),
                    price,
                    minRange,
                    maxRange,
                    Convert.ToInt32(cmbUnit.SelectedValue)
                );

                test.INSERT();
               
                LoadLabTests();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding lab test: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedTestID == -1)
            {
                MessageBox.Show("No test selected.");
                return;
            }

            try
            {
                LaboratoryTest test = new LaboratoryTest(
                    selectedTestID,
                    txtName.Text.Trim(),
                    txtDescription.Text.Trim(),
                    decimal.Parse(txtPrice.Text),
                    decimal.Parse(txtMinRange.Text),
                    decimal.Parse(txtMaxRange.Text),
                    Convert.ToInt32(cmbUnit.SelectedValue)
                );

                test.UPDATE();
                
                LoadLabTests();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating lab test: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedTestID == -1)
            {
                MessageBox.Show("No test selected.");
                return;
            }

            try
            {
                LaboratoryTest test = new LaboratoryTest();
                test.LabTestID = selectedTestID;
                test.DELETE();
               
                LoadLabTests();
                ClearInputs();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_"))
                    MessageBox.Show("Cannot delete: linked to other records.");
                else
                    MessageBox.Show("Error deleting lab test: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLabTests();
            ClearInputs();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
