using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class ConversionUnit
    {
        public int ConversionUnitID { get; set; }
        public string BaseUnit { get; set; }
        public string TargetUnit { get; set; }
        public decimal ConversionFactor { get; set; }

        // Constructor to initialize the properties
        public ConversionUnit(int conversionUnitID, string baseUnit, string targetUnit, decimal conversionFactor)
        {
            ConversionUnitID = conversionUnitID;
            BaseUnit = baseUnit;
            TargetUnit = targetUnit;
            ConversionFactor = conversionFactor;
        }

        // Methods for CRUD operations
        public DataTable INSERT()
        {
            return prcConversionUnit("INSERT", this);
        }

        public DataTable UPDATE()
        {
            return prcConversionUnit("UPDATE", this);
        }

        public DataTable DELETE()
        {
           return prcConversionUnit("DELETE", this);
        }

        public DataTable SELECT()
        {
            return prcConversionUnit("SELECT", this);
        }

        // Method to interact with the stored procedure
        private DataTable prcConversionUnit(string Operation, ConversionUnit conversionUnit)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcConversionUnit"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Adding parameters for the stored procedure
                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@ConversionUnitID", conversionUnit.ConversionUnitID);
                        cmd.Parameters.AddWithValue("@BaseUnit", conversionUnit.BaseUnit);
                        cmd.Parameters.AddWithValue("@TargetUnit", conversionUnit.TargetUnit);
                        cmd.Parameters.AddWithValue("@ConversionFactor", conversionUnit.ConversionFactor);
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
