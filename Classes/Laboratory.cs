using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class Laboratory
    {
        public int LaboratoryID { get; set; }
        public string LabName { get; set; }
        public string LabLocation { get; set; }
        public string LabContactNB { get; set; }
        public string LabEmail { get; set; }

        public Laboratory(int laboratoryID, string labName, string labLocation, string labContactNB, string labEmail)
        {
            LaboratoryID = laboratoryID;
            LabName = labName;
            LabLocation = labLocation;
            LabContactNB = labContactNB;
            LabEmail = labEmail;
        }

        public DataTable INSERT()
        {
           return prcLaboratory("INSERT", this);
        }

        public DataTable UPDATE()
        {
            return prcLaboratory("UPDATE", this);
        }

        public DataTable DELETE()
        {
            return prcLaboratory("DELETE", this);
        }

        public DataTable SELECT()
        {
            return prcLaboratory("SELECT", this);
        }

        private DataTable prcLaboratory(string Operation, Laboratory laboratory)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcLaboratory"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@LaboratoryID", laboratory.LaboratoryID);
                        cmd.Parameters.AddWithValue("@LabName", laboratory.LabName);
                        cmd.Parameters.AddWithValue("@LabLocation", laboratory.LabLocation);
                        cmd.Parameters.AddWithValue("@LabContactNB", laboratory.LabContactNB);
                        cmd.Parameters.AddWithValue("@LabEmail", laboratory.LabEmail);
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
