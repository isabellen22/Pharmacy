using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class UnitOfMeasurement
    {
        public int UnitID { get; set; }
        public string UnitName { get; set; }
        public string UnitSymbol { get; set; }
        

        public UnitOfMeasurement()
        {
            UnitID = 0;
            UnitName = "";
            UnitSymbol = "";
           
        }

        public UnitOfMeasurement(int unitID, string unitName, string unitSymbol, int conversionUnitID)
        {
            UnitID = unitID;
            UnitName = unitName;
            UnitSymbol = unitSymbol;
            
        }

        public DataTable INSERT() => prcUnitOfMeasurement("INSERT", this);
        public DataTable UPDATE() => prcUnitOfMeasurement("UPDATE", this);
        public DataTable DELETE() => prcUnitOfMeasurement("DELETE", this);
        public DataTable SELECT() => prcUnitOfMeasurement("SELECT", this);

        private DataTable prcUnitOfMeasurement(string operation, UnitOfMeasurement unit)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcUnitOfMeasurement", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Operation", operation);
                        cmd.Parameters.AddWithValue("@UnitID", unit.UnitID);
                        cmd.Parameters.AddWithValue("@UnitName", unit.UnitName ?? "");
                        cmd.Parameters.AddWithValue("@UnitSymbol", unit.UnitSymbol ?? "");
                       
                        cmd.Parameters.AddWithValue("@User", LoggedUser.UserID);

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(dt);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547 && operation == "DELETE")
                    MessageBox.Show("This unit is linked to another table and cannot be deleted.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("SQL Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}
