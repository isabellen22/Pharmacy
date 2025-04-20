using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class ChemicalComponent
    {
        public int ComponentID { get; set; }
        public string ComponentName { get; set; }
        public string ChemicalName { get; set; }

        public ChemicalComponent(int componentID, string componentName, string chemicalName)
        {
            ComponentID = componentID;
            ComponentName = componentName;
            ChemicalName = chemicalName;
        }
        public DataTable INSERT()
        {
           return  prcChemicalComponent("INSERT", this);
        }

        public DataTable UPDATE()
        {
           return  prcChemicalComponent("UPDATE", this);
        }

        public DataTable DELETE()
        {
           return prcChemicalComponent("DELETE", this);
        }

        public DataTable SELECT()
        {
           return prcChemicalComponent("SELECT", this);
        }

       
        private DataTable prcChemicalComponent(string Operation, ChemicalComponent component)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcChemicalComponent"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Adding parameters for the stored procedure
                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@ComponentID", component.ComponentID);
                        cmd.Parameters.AddWithValue("@ComponentName", component.ComponentName);
                        cmd.Parameters.AddWithValue("@ChemicalName", component.ChemicalName);
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

