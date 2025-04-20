using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public DateTime? EmployeeDOB { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeContactNB { get; set; }

        public Employee(int employeeID, string employeeFirstName, string employeeLastName, DateTime employeeDOB, string employeeAddress, string employeeContactNB)
        {
            EmployeeID = employeeID;
            EmployeeFirstName = employeeFirstName;
            EmployeeLastName = employeeLastName;
            EmployeeDOB = employeeDOB;
            EmployeeAddress = employeeAddress;
            EmployeeContactNB = employeeContactNB;
        }

        public int INSERT()
        {
            int newEmployeeID;
            prcEmployee("INSERT", this, out newEmployeeID);
            MessageBox.Show($"New Employee ID: {newEmployeeID}", "Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Information); // Add this line
            return newEmployeeID;
        }

        public void UPDATE()
        {
            int dummyEmployeeID; // Dummy variable for the out parameter
            prcEmployee("UPDATE", this, out dummyEmployeeID);
        }

        public void DELETE()
        {
            int dummyEmployeeID; // Dummy variable for the out parameter
            prcEmployee("DELETE", this, out dummyEmployeeID);
        }

        public DataTable SELECT()
        {
            int dummyEmployeeID; // Dummy variable for the out parameter
            return prcEmployee("SELECT", null, out dummyEmployeeID);
        }

        private DataTable prcEmployee(string Operation, Employee employee, out int newEmployeeID)
        {
            newEmployeeID = 0; // Initialize out parameter
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("prcEmployee", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Operation", Operation);

                        // Handle EmployeeID parameter
                        if (Operation.ToUpper() == "INSERT")
                        {
                            cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Direction = ParameterDirection.Output;
                        }
                        else if (Operation.ToUpper() != "SELECT")
                        {
                            cmd.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@EmployeeID", DBNull.Value); // For SELECT
                        }

                        // Handle other parameters - Use null-conditional operator and null-coalescing operator
                        cmd.Parameters.AddWithValue("@EmployeeFirstName", employee?.EmployeeFirstName ?? string.Empty);
                        cmd.Parameters.AddWithValue("@EmployeeLastName", employee?.EmployeeLastName ?? string.Empty);
                        cmd.Parameters.AddWithValue("@EmployeeDOB", employee?.EmployeeDOB.HasValue == true ? (object)employee.EmployeeDOB.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@EmployeeAddress", employee?.EmployeeAddress ?? string.Empty);
                        cmd.Parameters.AddWithValue("@EmployeeContactNB", employee?.EmployeeContactNB ?? string.Empty);
                        cmd.Parameters.AddWithValue("@User", 4); // Replace with actual user ID if needed

                        if (Operation.ToUpper() == "SELECT")
                        {
                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {
                                sda.Fill(dt);
                            }
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            if (Operation.ToUpper() == "INSERT")
                            {
                                newEmployeeID = (int)cmd.Parameters["@EmployeeID"].Value;
                            }
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

        public string EmployeeFullName => $"{EmployeeFirstName} {EmployeeLastName}";
    }
}