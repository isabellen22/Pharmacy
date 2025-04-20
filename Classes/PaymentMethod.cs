using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class PaymentMethod
    {
        public int PaymentMethodID { get; set; }
        public string MethodName { get; set; }
        public string PMDescription { get; set; }

        public PaymentMethod(int paymentMethodID, string methodName, string pmDescription)
        {
            PaymentMethodID = paymentMethodID;
            MethodName = methodName;
            PMDescription = pmDescription;
        }

        public DataTable INSERT()
        {
           return prcPaymentMethod("INSERT", this);
        }

        public DataTable UPDATE()
        {
            return prcPaymentMethod("UPDATE", this);
        }

        public DataTable DELETE()
        {
            return prcPaymentMethod("DELETE", this);
        }

        public DataTable SELECT()
        {
            return prcPaymentMethod("SELECT", this);
        }

        private DataTable prcPaymentMethod(string Operation, PaymentMethod paymentMethod)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcPaymentMethod"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@PaymentMethodID", paymentMethod.PaymentMethodID);
                        cmd.Parameters.AddWithValue("@MethodName", paymentMethod.MethodName);
                        cmd.Parameters.AddWithValue("@PMDescription", paymentMethod.PMDescription);
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
