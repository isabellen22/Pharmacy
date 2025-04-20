using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class EmployeeContract
    {
        public int ContractID { get; set; }
        public int EmployeeID { get; set; } // Added EmployeeID
        public DateTime HireDate { get; set; }
        public string ContractPeriod { get; set; }
        public int User { get; set; }

        public EmployeeContract(int contractID, int employeeID, DateTime hireDate, string contractPeriod, int user)
        {
            ContractID = contractID;
            EmployeeID = employeeID;
            HireDate = hireDate;
            ContractPeriod = contractPeriod;
            User = user;
        }

        public EmployeeContract(Employee employee) // Overloaded constructor for retrieval
        {
            EmployeeID = employee.EmployeeID; // Storing the EmployeeID
        }

        public void INSERT()
        {
            prcEmployeeContract("insert", this);
        }

        public void UPDATE()
        {
            prcEmployeeContract("update", this);
        }

        public void DELETE()
        {
            prcEmployeeContract("delete", this);
        }

        private DataTable prcEmployeeContract(string Operation, EmployeeContract contract)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcEmployeeContract"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@ContractID", contract.ContractID);
                        cmd.Parameters.AddWithValue("@EmployeeID", contract.EmployeeID); // Added EmployeeID parameter
                        cmd.Parameters.AddWithValue("@HireDate", contract.HireDate);
                        cmd.Parameters.AddWithValue("@ContractPeriod", contract.ContractPeriod);
                        cmd.Parameters.AddWithValue("@User", contract.User);

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

        public static DataTable GetEmployeeContract(int employeeID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection("Server=localhost;Database=PharmacyDB;Trusted_Connection=True;"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("prcGetEmployeeContract", con)) // Assuming you have this stored procedure
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeID); // Corrected parameter

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
