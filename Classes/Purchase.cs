using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class Purchase
    {
        public int PurchaseID { get; set; }
        public int SupplierID { get; set; }
        public int CurrencyID { get; set; }
        public int PaymentMethodID { get; set; }
        public int UserID { get; set; }

        public Purchase(int purchaseID, int supplierID, int currencyID, int paymentMethodID, int userID)
        {
            PurchaseID = purchaseID;
            SupplierID = supplierID;
            CurrencyID = currencyID;
            PaymentMethodID = paymentMethodID;
            UserID = userID;
        }

        public Purchase()
        {
            PurchaseID = 0;
            SupplierID = 0;
            CurrencyID = 0;
            PaymentMethodID = 0;
            UserID = 0;
        }

        // CRUD Operations
        public DataTable DELETE()
        {
            return prcPurchase("DELETE", this, DateTime.Now);
        }

        public DataTable SELECT()
        {
            return prcPurchase("SELECT", this, DateTime.Now);  // In this case, we won't pass a purchaseDate, it's not needed for SELECT
        }

        public DataTable INSERT(DateTime purchaseDate)
        {
            return prcPurchase("INSERT", this, purchaseDate);
        }

        public DataTable UPDATE(DateTime purchaseDate)
        {
            return prcPurchase("UPDATE", this, purchaseDate);
        }

        // Modify the prcPurchase method to accept DateTime purchaseDate
        private DataTable prcPurchase(string operation, Purchase purchase, DateTime purchaseDate)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcPurchase", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", operation);
                        cmd.Parameters.AddWithValue("@PurchaseID", purchase.PurchaseID);
                        cmd.Parameters.AddWithValue("@SupplierID", purchase.SupplierID);
                        cmd.Parameters.AddWithValue("@CurrencyID", purchase.CurrencyID);
                        cmd.Parameters.AddWithValue("@PaymentMethodID", purchase.PaymentMethodID);
                        cmd.Parameters.AddWithValue("@User", LoggedUser.UserID);



                        cmd.Parameters.AddWithValue("@PurchaseDate", purchaseDate);
                        

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }
    }
}
