using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class EmployeePromotion
    {
        public int EmployeeID { get; set; }
        public decimal NewSalary { get; set; }
        public DateTime PromotionDate { get; set; }
        public string PromotionReason { get; set; }
        public int CurrencyID { get; set; }

        public EmployeePromotion(int employeeID, decimal newSalary, DateTime promotionDate, string promotionReason, int currencyID)
        {
            EmployeeID = employeeID;
            NewSalary = newSalary;
            PromotionDate = promotionDate;
            PromotionReason = promotionReason;
            CurrencyID = currencyID;
        }

        public EmployeePromotion(int employeeID) // Overloaded constructor for retrieval
        {
            EmployeeID = employeeID;
        }

        public void INSERT()
        {
            prcEmployeePromotion("insert", this);
        }

        public void UPDATE()
        {
            prcEmployeePromotion("update", this);
        }

        public void DELETE()
        {
            prcEmployeePromotion("delete", this);
        }

        private DataTable prcEmployeePromotion(string Operation, EmployeePromotion promotion)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcEmployeePromotion"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@EmployeeID", promotion.EmployeeID);
                        cmd.Parameters.AddWithValue("@NewSalary", promotion.NewSalary);
                        cmd.Parameters.AddWithValue("@PromotionDate", promotion.PromotionDate);
                        cmd.Parameters.AddWithValue("@PromotionReason", promotion.PromotionReason);
                        cmd.Parameters.AddWithValue("@CurrencyID", promotion.CurrencyID);
                        cmd.Parameters.AddWithValue("@User", 4);

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

        public static DataTable GetEmployeePromotion(int employeeID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("prcGetEmployeePromotion", con)) // Assuming you have this stored procedure
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

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