using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class Doctor
    {
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public DateTime DoctorDOB { get; set; }
        public int CountyID { get; set; }
        public string DoctorPhoneNB { get; set; }
        public string ClinicAddress { get; set; }
        public int SpecializationID { get; set; }

        // Constructor to initialize the properties
        public Doctor(int doctorID, string doctorName, DateTime doctorDOB, int countyID, string doctorPhoneNB, string clinicAddress, int specializationID)
        {
            DoctorID = doctorID;
            DoctorName = doctorName;
            DoctorDOB = doctorDOB;
            CountyID = countyID;
            DoctorPhoneNB = doctorPhoneNB;
            ClinicAddress = clinicAddress;
            SpecializationID = specializationID;
        }

        public Doctor()
        {
            DoctorID = 0;
            DoctorName = "";
            DoctorDOB = DateTime.Now; 
            CountyID = 0;
            DoctorPhoneNB = "";
            ClinicAddress = "";
            SpecializationID = 0;
        }

        // Methods for CRUD operations
        public DataTable INSERT()
        {
            return prcDoctors("INSERT", this);
        }

        public DataTable UPDATE()
        {
           return  prcDoctors("UPDATE", this);
        }

        public DataTable DELETE()
        {
           return prcDoctors("DELETE", this);
        }

        public DataTable SELECT()
        {
            return prcDoctors("SELECT", this);
        }

        // Method to interact with the stored procedure
        private DataTable prcDoctors(string Operation, Doctor doctor)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcDoctors"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Adding parameters for the stored procedure
                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@DoctorID", doctor.DoctorID);
                        cmd.Parameters.AddWithValue("@DoctorName", doctor.DoctorName);
                        cmd.Parameters.AddWithValue("@DoctorDOB", doctor.DoctorDOB);
                        cmd.Parameters.AddWithValue("@CountyID", doctor.CountyID);
                        cmd.Parameters.AddWithValue("@DoctorPhoneNB", doctor.DoctorPhoneNB);
                        cmd.Parameters.AddWithValue("@ClinicAddress", doctor.ClinicAddress);
                        cmd.Parameters.AddWithValue("@SpecializationID", doctor.SpecializationID);
                       cmd.Parameters.AddWithValue("@User", LoggedUser.UserID); 

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}
