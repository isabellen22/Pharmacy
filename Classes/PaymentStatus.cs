using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class PaymentStatus
    {
        public int PaymentStatusID { get; set; }
        public string PaymentStatusName { get; set; } 

        
        public PaymentStatus(int paymentStatusID, string paymentStatusName)
        {
            PaymentStatusID = paymentStatusID;
            PaymentStatusName = paymentStatusName;
        }

        // Methods for CRUD operations
        public DataTable INSERT()
        {
           return prcPaymentStatus("INSERT", this);
        }

        public DataTable UPDATE()
        {
            return prcPaymentStatus("UPDATE", this);
        }

        public DataTable DELETE()
        {
            return prcPaymentStatus("DELETE", this);
        }

        public DataTable SELECT()
        {
            return prcPaymentStatus("SELECT", this);
        }

        
        private DataTable prcPaymentStatus(string Operation, PaymentStatus paymentStatus)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcPaymentStatus"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Adding parameters for the stored procedure
                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@PaymentStatusID", paymentStatus.PaymentStatusID);
                        cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatus.PaymentStatusName);
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
