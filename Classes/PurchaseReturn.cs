using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Pharmacy.Classes
{
    public class PurchaseReturn
    {
        public int PurchaseReturnID { get; set; }
        public int PurchaseID { get; set; }
        public DateTime ReturnDate { get; set; }
        public string ReturnReason { get; set; }
        public int CurrencyID { get; set; }
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }
        public decimal VAT { get; set; }
        public int PaymentMethodID { get; set; }
        public int PReturnedProduct { get; set; }
        public decimal PReturnedQuantity { get; set; }
        public decimal PReturnedPrice { get; set; }
        public decimal PReturnDiscount { get; set; }
        public decimal PReturnVAT { get; set; }

        // Constructor
        public PurchaseReturn(int purchaseID, DateTime returnDate, string returnReason,
                              int currencyID, decimal amount, decimal discount, decimal vat,
                              int paymentMethodID, int pReturnedProduct, decimal pReturnedQuantity,
                              decimal pReturnedPrice, decimal pReturnDiscount, decimal pReturnVAT)
        {
            PurchaseID = purchaseID;
            ReturnDate = returnDate;
            ReturnReason = returnReason;
            CurrencyID = currencyID;
            Amount = amount;
            Discount = discount;
            VAT = vat;
            PaymentMethodID = paymentMethodID;
            PReturnedProduct = pReturnedProduct;
            PReturnedQuantity = pReturnedQuantity;
            PReturnedPrice = pReturnedPrice;
            PReturnDiscount = pReturnDiscount;
            PReturnVAT = pReturnVAT;
        }

        public int INSERT(DataTable tPrDetail)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcPurchaseReturn", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputIdParam = new SqlParameter("@PurchaseReturnID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        cmd.Parameters.AddWithValue("@Operation", "INSERT");
                        cmd.Parameters.Add(outputIdParam);
                        cmd.Parameters.AddWithValue("@PurchaseID", PurchaseID);
                        cmd.Parameters.AddWithValue("@ReturnDate", ReturnDate);
                        cmd.Parameters.AddWithValue("@ReturnReason", ReturnReason);
                        cmd.Parameters.AddWithValue("@CurrencyID", CurrencyID);
                        cmd.Parameters.AddWithValue("@Amount", Amount);
                        cmd.Parameters.AddWithValue("@Discount", Discount);
                        cmd.Parameters.AddWithValue("@VAT", VAT);
                        cmd.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);
                        cmd.Parameters.AddWithValue("@PurchaseReturnDetailsID", 0); 
                        cmd.Parameters.AddWithValue("@PReturnedProduct", PReturnedProduct);
                        cmd.Parameters.AddWithValue("@PReturnedQuantity", PReturnedQuantity);
                        cmd.Parameters.AddWithValue("@PReturnedPrice", PReturnedPrice);
                        cmd.Parameters.AddWithValue("@PReturnDiscount", PReturnDiscount);
                        cmd.Parameters.AddWithValue("@PReturnVAT", PReturnVAT);
                        cmd.Parameters.AddWithValue("@User", LoggedUser.UserID);

                        // ✅ Pass table-valued parameter
                        SqlParameter tvpParam = cmd.Parameters.AddWithValue("@tPrDetail", tPrDetail);
                        tvpParam.SqlDbType = SqlDbType.Structured;
                        tvpParam.TypeName = "dbo.tPrDetail";

                        con.Open();
                        cmd.ExecuteNonQuery();

                        this.PurchaseReturnID = (int)outputIdParam.Value;
                        return this.PurchaseReturnID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during INSERT: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }



    }
}
