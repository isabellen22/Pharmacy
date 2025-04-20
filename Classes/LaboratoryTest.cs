using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class LaboratoryTest
    {
        public int LabTestID { get; set; }
        public string LabTestName { get; set; }
        public string LabTestDescription { get; set; }
        public decimal LabTestPrice { get; set; }
        public decimal MinHealthyRange { get; set; }
        public decimal MaxHealthyRange { get; set; }
        public int UnitID { get; set; }

        public LaboratoryTest(int labTestID, string labTestName, string labTestDescription, decimal labTestPrice, decimal minHealthyRange, decimal maxHealthyRange, int unitID)
        {
            LabTestID = labTestID;
            LabTestName = labTestName;
            LabTestDescription = labTestDescription;
            LabTestPrice = labTestPrice;
            MinHealthyRange = minHealthyRange;
            MaxHealthyRange = maxHealthyRange;
            UnitID = unitID;
        }

        public DataTable INSERT()
        {
           return prcLaboratoryTest("INSERT", this);
        }

        public DataTable UPDATE()
        {
            return prcLaboratoryTest("UPDATE", this);
        }

        public DataTable DELETE()
        {
            return prcLaboratoryTest("DELETE", this);
        }

        public DataTable SELECT()
        {
            return prcLaboratoryTest("SELECT", this);
        }

        private DataTable prcLaboratoryTest(string Operation, LaboratoryTest test)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcLaboratoryTest"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@LabTestID", test.LabTestID);
                        cmd.Parameters.AddWithValue("@LabTestName", test.LabTestName);
                        cmd.Parameters.AddWithValue("@LabTestDescription", test.LabTestDescription);
                        cmd.Parameters.AddWithValue("@LabTestPrice", test.LabTestPrice);
                        cmd.Parameters.AddWithValue("@MinHealthyRange", test.MinHealthyRange);
                        cmd.Parameters.AddWithValue("@MaxHealthyRange", test.MaxHealthyRange);
                        cmd.Parameters.AddWithValue("@UnitID", test.UnitID);
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
