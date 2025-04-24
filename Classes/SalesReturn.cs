using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    public class SalesReturn
    {
        public int SalesReturnID { get; set; }
        public int SalesID { get; set; }
        public DateTime ReturnDate { get; set; }
        public string ReturnReason { get; set; }
        public int CurrencyID { get; set; }
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }
        public decimal VAT { get; set; }
        public int PaymentMethodID { get; set; }
        public int SReturnedProduct { get; set; }
        public decimal SReturnedQuantity { get; set; }
        public decimal SReturnedPrice { get; set; }
        public decimal SReturnDiscount { get; set; }
        public decimal SReturnVAT { get; set; }

        public SalesReturn(int salesID, DateTime returnDate, string returnReason,
                           int currencyID, decimal amount, decimal discount, decimal vat,
                           int paymentMethodID, int sReturnedProduct, decimal sReturnedQuantity,
                           decimal sReturnedPrice, decimal sReturnDiscount, decimal sReturnVAT)
        {
            SalesID = salesID;
            ReturnDate = returnDate;
            ReturnReason = returnReason;
            CurrencyID = currencyID;
            Amount = amount;
            Discount = discount;
            VAT = vat;
            PaymentMethodID = paymentMethodID;
            SReturnedProduct = sReturnedProduct;
            SReturnedQuantity = sReturnedQuantity;
            SReturnedPrice = sReturnedPrice;
            SReturnDiscount = sReturnDiscount;
            SReturnVAT = sReturnVAT;
        }

        public int INSERT(DataTable tSales)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcSalesReturn", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputIdParam = new SqlParameter("@SalesReturnID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        cmd.Parameters.AddWithValue("@Operation", "INSERT");
                        cmd.Parameters.Add(outputIdParam);
                        cmd.Parameters.AddWithValue("@SalesID", SalesID);
                        cmd.Parameters.AddWithValue("@ReturnDate", ReturnDate);
                        cmd.Parameters.AddWithValue("@ReturnReason", ReturnReason);
                        cmd.Parameters.AddWithValue("@CurrencyID", CurrencyID);
                        cmd.Parameters.AddWithValue("@Amount", Amount);
                        cmd.Parameters.AddWithValue("@Discount", Discount);
                        cmd.Parameters.AddWithValue("@VAT", VAT);
                        cmd.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);
                        cmd.Parameters.AddWithValue("@User", LoggedUser.UserID);

                        SqlParameter tvpParam = cmd.Parameters.AddWithValue("@tSales", tSales);
                        tvpParam.SqlDbType = SqlDbType.Structured;
                        tvpParam.TypeName = "dbo.tSales"; // Updated table type name

                        con.Open();
                        cmd.ExecuteNonQuery();

                        this.SalesReturnID = (int)outputIdParam.Value;
                        return this.SalesReturnID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during Sales Return INSERT: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
    }
}
