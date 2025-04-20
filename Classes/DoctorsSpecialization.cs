using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class DoctorsSpecialization
    {
        public int SpecializationID { get; set; }
        public string SpecializationName { get; set; }
        public string SpecializationCategory { get; set; }

        public DoctorsSpecialization(int id, string name, string category)
        {
            SpecializationID = id;
            SpecializationName = name;
            SpecializationCategory = category;
        }

        public DoctorsSpecialization()
        {
        }

        public DataTable SELECT()
        {
            return prcDoctorsSpecialization("SELECT", this);
        }

        public DataTable INSERT()
        {
            return prcDoctorsSpecialization("INSERT", this);
        }

        public DataTable UPDATE()
        {
            return prcDoctorsSpecialization("UPDATE", this);
        }

        public DataTable DELETE()
        {
            return prcDoctorsSpecialization("DELETE", this);
        }

        private DataTable prcDoctorsSpecialization(string operation, DoctorsSpecialization spec)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                using (SqlCommand cmd = new SqlCommand("prcDoctorsSpecialization", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // These must always be supplied
                    cmd.Parameters.AddWithValue("@Operation", operation);
                    cmd.Parameters.AddWithValue("@SpecializationID", spec.SpecializationID);
                    cmd.Parameters.AddWithValue("@SpecializationName", spec.SpecializationName ?? "");
                    cmd.Parameters.AddWithValue("@SpecializationCategory", spec.SpecializationCategory ?? "");
                    cmd.Parameters.AddWithValue("@User", LoggedUser.UserID);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return dt;
        }
    }
}
