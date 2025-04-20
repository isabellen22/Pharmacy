using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    public class EmployeeSalary
    {
        public int EmployeeID { get; set; }
        public decimal EmployeeSalaryAmount { get; set; }
        public int CurrencyID { get; set; }

        public EmployeeSalary(int employeeID, decimal employeeSalaryAmount, int currencyID)
        {
            EmployeeID = employeeID;
            EmployeeSalaryAmount = employeeSalaryAmount;
            CurrencyID = currencyID;
        }

        public void INSERT()
        {
            prcEmployeeSalary("insert", this);
        }

        public void UPDATE()
        {
            prcEmployeeSalary("update", this);
        }

        public void DELETE()
        {
            prcEmployeeSalary("delete", this);
        }

        public DataTable SELECT()  // Modified SELECT method
        {
            return prcEmployeeSalary("select", this);
        }

        private DataTable prcEmployeeSalary(string Operation, EmployeeSalary salary)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcEmployeeSalary"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@EmployeeID", salary.EmployeeID);
                        cmd.Parameters.AddWithValue("@EmployeeSalary", salary.EmployeeSalaryAmount);
                        cmd.Parameters.AddWithValue("@CurrencyID", salary.CurrencyID);
                        cmd.Parameters.AddWithValue("@User", 4); // Assuming '1' is the default user ID

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
