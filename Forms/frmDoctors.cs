using Pharmacy.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
    public partial class frmDoctor : Form
    {
        int selectedDoctorID = -1;

        public frmDoctor()
        {
            InitializeComponent();
            dgvDoctors.AutoGenerateColumns = false;
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            LoadCombos();
            LoadDoctors();
        }

        private void LoadCombos()
        {
            try
            {
                cmbCountry.DisplayMember = "CountryName";
                cmbCountry.ValueMember = "CountryID";
                cmbCountry.DataSource = new Country().SELECT();

                cmbSpecialization.DisplayMember = "SpecializationName";
                cmbSpecialization.ValueMember = "SpecializationID";
                cmbSpecialization.DataSource = new DoctorsSpecialization().SELECT();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Combo load error:\n" + ex.Message);
            }
        }

        private void LoadDoctors()
        {
            DataTable doctors = new Doctor().SELECT();
            DataTable countries = new Country().SELECT();
            DataTable specs = new DoctorsSpecialization().SELECT();

            if (!doctors.Columns.Contains("CountryName"))
                doctors.Columns.Add("CountryName", typeof(string));
            if (!doctors.Columns.Contains("SpecializationName"))
                doctors.Columns.Add("SpecializationName", typeof(string));

            foreach (DataRow row in doctors.Rows)
            {
                int countryID = Convert.ToInt32(row["CountryID"]);
                int specID = Convert.ToInt32(row["SpecializationID"]);

                row["CountryName"] = countries.Select($"CountryID = {countryID}").FirstOrDefault()?["CountryName"]?.ToString() ?? "N/A";
                row["SpecializationName"] = specs.Select($"SpecializationID = {specID}").FirstOrDefault()?["SpecializationName"]?.ToString() ?? "N/A";
            }

            dgvDoctors.DataSource = doctors;
            dgvDoctors.ClearSelection();
            ClearForm();
        }

        private void ClearForm()
        {
            selectedDoctorID = -1;
            txtName.Clear();
            txtPhone.Clear();
            txtClinic.Clear();
            dtpDOB.Value = DateTime.Today;
            cmbCountry.SelectedIndex = -1;
            cmbSpecialization.SelectedIndex = -1;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var doctor = new Doctor(0, txtName.Text.Trim(), dtpDOB.Value,
                Convert.ToInt32(cmbCountry.SelectedValue),
                txtPhone.Text.Trim(),
                txtClinic.Text.Trim(),
                Convert.ToInt32(cmbSpecialization.SelectedValue));

            doctor.INSERT();
            LoadDoctors();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedDoctorID == -1) return;

            var doctor = new Doctor(selectedDoctorID, txtName.Text.Trim(), dtpDOB.Value,
                Convert.ToInt32(cmbCountry.SelectedValue),
                txtPhone.Text.Trim(),
                txtClinic.Text.Trim(),
                Convert.ToInt32(cmbSpecialization.SelectedValue));

            doctor.UPDATE();
            LoadDoctors();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedDoctorID == -1) return;

            try
            {
                new Doctor(selectedDoctorID, "", DateTime.Today, 0, "", "", 0).DELETE();
                LoadDoctors();
            }
            catch (SqlException ex) when (ex.Message.Contains("REFERENCE"))
            {
                MessageBox.Show("This doctor is referenced elsewhere and cannot be deleted.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDoctors();
        }

        private void dgvDoctors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvDoctors.Rows[e.RowIndex];
            selectedDoctorID = Convert.ToInt32(row.Cells["DoctorID"].Value);

            txtName.Text = row.Cells["DoctorName"].Value.ToString();
            dtpDOB.Value = Convert.ToDateTime(row.Cells["DoctorDOB"].Value);
            txtPhone.Text = row.Cells["DoctorPhoneNB"].Value.ToString();
            txtClinic.Text = row.Cells["ClinicAddress"].Value.ToString();
            cmbCountry.Text = row.Cells["CountryName"].Value.ToString();
            cmbSpecialization.Text = row.Cells["SpecializationName"].Value.ToString();

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void frmDoctor_FormClosed(object sender, FormClosedEventArgs e)
        {
            // optional: notify MDI parent
        }
    }
}
