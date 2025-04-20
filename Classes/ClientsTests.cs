using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class ClientTests
    {
        public int TestID { get; set; }
        public int LabTestID { get; set; }
        public int LaboratoryID { get; set; }
        public int ClientID { get; set; }
        public decimal TestDiscount { get; set; }
        public DateTime TestDate { get; set; }
        public DateTime TestDueDate { get; set; }
        public string TestResult { get; set; }

        // Constructor to initialize the properties
        public ClientTests(int testID, int labTestID, int laboratoryID, int clientID, decimal testDiscount, DateTime testDate, DateTime testDueDate, string testResult)
        {
            TestID = testID;
            LabTestID = labTestID;
            LaboratoryID = laboratoryID;
            ClientID = clientID;
            TestDiscount = testDiscount;
            TestDate = testDate;
            TestDueDate = testDueDate;
            TestResult = testResult;
        }

        // Methods for CRUD operations
        public DataTable INSERT()
        {
            return prcClientsTests("INSERT", this);
        }

        public DataTable UPDATE()
        {
            return prcClientsTests("UPDATE", this);
        }

        public DataTable DELETE()
        {
            return prcClientsTests("DELETE", this);
        }

        public DataTable SELECT()
        {
            return prcClientsTests("SELECT", this);
        }

        // Method to interact with the stored procedure
        private DataTable prcClientsTests(string Operation, ClientTests clientTest)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcClientsTests"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Adding parameters for the stored procedure
                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@TestID", clientTest.TestID);
                        cmd.Parameters.AddWithValue("@LabTestID", clientTest.LabTestID);
                        cmd.Parameters.AddWithValue("@LaboratoryID", clientTest.LaboratoryID);
                        cmd.Parameters.AddWithValue("@ClientID", clientTest.ClientID);
                        cmd.Parameters.AddWithValue("@TestDiscount", clientTest.TestDiscount);
                        cmd.Parameters.AddWithValue("@TestDate", clientTest.TestDate);
                        cmd.Parameters.AddWithValue("@TestDueDate", clientTest.TestDueDate);
                        cmd.Parameters.AddWithValue("@TestResult", clientTest.TestResult);
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
