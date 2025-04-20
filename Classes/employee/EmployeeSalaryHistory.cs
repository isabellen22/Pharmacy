using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class EmployeeSalaryHistory
    {
        public int SalaryHistoryID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime SalaryMonth { get; set; }
        public decimal SalaryAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int CurrencyID { get; set; }

        public EmployeeSalaryHistory(int salaryHistoryID, int employeeID, DateTime salaryMonth, decimal salaryAmount, DateTime paymentDate, int currencyID)
        {
            SalaryHistoryID = salaryHistoryID;
            EmployeeID = employeeID;
            SalaryMonth = salaryMonth;
            SalaryAmount = salaryAmount;
            PaymentDate = paymentDate;
            CurrencyID = currencyID;
        }

        public void INSERT()
        {
            prcEmployeeSalaryHistory("insert", this);
        }

        public void UPDATE()
        {
            prcEmployeeSalaryHistory("update", this);
        }

        public void DELETE()
        {
            prcEmployeeSalaryHistory("delete", this);
        }

        public void SELECT()
        {
            prcEmployeeSalaryHistory("select", this);
        }

        private DataTable prcEmployeeSalaryHistory(string Operation, EmployeeSalaryHistory history)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcEmployeeSalaryHistory"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@SalaryHistoryID", history.SalaryHistoryID);
                        cmd.Parameters.AddWithValue("@EmployeeID", history.EmployeeID);
                        cmd.Parameters.AddWithValue("@SalaryMonth", history.SalaryMonth);
                        cmd.Parameters.AddWithValue("@SalaryAmount", history.SalaryAmount);
                        cmd.Parameters.AddWithValue("@PaymentDate", history.PaymentDate);
                        cmd.Parameters.AddWithValue("@CurrencyID", history.CurrencyID);
                        cmd.Parameters.AddWithValue("@User", 1);

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
