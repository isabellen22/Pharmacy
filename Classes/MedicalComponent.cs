using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class MedicalComponent
    {
        public int ComponentID { get; set; }
        public int MedicalProductDetailID { get; set; }
        public string SideEffects { get; set; }

        public MedicalComponent(int componentID, int medicalProductDetailID, string sideEffects)
        {
            ComponentID = componentID;
            MedicalProductDetailID = medicalProductDetailID;
            SideEffects = sideEffects;
        }

        public DataTable INSERT()
        {
            return prcMedicalComponents("INSERT", this);
        }

        public DataTable UPDATE()
        {
           return prcMedicalComponents("UPDATE", this);
        }

        public DataTable DELETE()
        {
            return prcMedicalComponents("DELETE", this);
        }

        public DataTable SELECT()
        {
            return prcMedicalComponents("SELECT", this);
        }

        private DataTable prcMedicalComponents(string Operation, MedicalComponent component)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcMedicalComponents"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@ComponentID", component.ComponentID);
                        cmd.Parameters.AddWithValue("@MedicalProductDetailID", component.MedicalProductDetailID);
                        cmd.Parameters.AddWithValue("@SideEffects", component.SideEffects);
                        cmd.Parameters.AddWithValue("@User", LoggedUser.UserID ); 

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
