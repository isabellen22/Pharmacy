using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Pharmacy.Classes
{
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public DateTime EmployeeDOB { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeContactNB { get; set; }

        public Employee(int employeeID, string firstName, string lastName, DateTime dob, string address, string contactNB)
        {
            EmployeeID = employeeID;
            EmployeeFirstName = firstName;
            EmployeeLastName = lastName;
            EmployeeDOB = dob;
            EmployeeAddress = address;
            EmployeeContactNB = contactNB;
        }

        public Employee()
        {
            EmployeeID = 0;
            EmployeeFirstName = "";
            EmployeeLastName = "";
            EmployeeDOB = DateTime.Now;
            EmployeeAddress = "";
            EmployeeContactNB = "";
        }

        public DataTable INSERT()
        {
            return prcEmployee("INSERT", this);
        }

        public DataTable UPDATE()
        {
            return prcEmployee("UPDATE", this);
        }

        public DataTable DELETE()
        {
            return prcEmployee("DELETE", this);
        }

        public DataTable SELECT()
        {
            return prcEmployee("SELECT", this);
        }

        private DataTable prcEmployee(string Operation, Employee employee)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcEmployee"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", Operation);

                        SqlParameter outputID = new SqlParameter("@EmployeeID", SqlDbType.Int);
                        if (Operation == "INSERT")
                            outputID.Direction = ParameterDirection.Output;
                        else
                            outputID.Value = employee.EmployeeID;

                        cmd.Parameters.Add(outputID);
                        cmd.Parameters.AddWithValue("@EmployeeFirstName", employee.EmployeeFirstName);
                        cmd.Parameters.AddWithValue("@EmployeeLastName", employee.EmployeeLastName);
                        cmd.Parameters.AddWithValue("@EmployeeDOB", employee.EmployeeDOB);
                        cmd.Parameters.AddWithValue("@EmployeeAddress", employee.EmployeeAddress);
                        cmd.Parameters.AddWithValue("@EmployeeContactNB", employee.EmployeeContactNB);
                        cmd.Parameters.AddWithValue("@User", LoggedUser.UserID);

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(dt);
                        }

                        if (Operation == "INSERT")
                        {
                            employee.EmployeeID = Convert.ToInt32(outputID.Value);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }
    }
}
