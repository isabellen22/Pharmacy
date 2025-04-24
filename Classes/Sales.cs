using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    public class Sales
    {
        public int SalesID { get; set; }
        public DateTime SalesDate { get; set; }
        public int EmployeeID { get; set; }
        public int ClientID { get; set; }
        public int WarehouseID { get; set; }
        public int PaymentStatusID { get; set; }
        public decimal VAT { get; set; }
        public decimal SalesAmount { get; set; }
        public int CurrencyID { get; set; }

        // Constructor
        public Sales(int salesID, DateTime salesDate, int employeeID, int clientID, int warehouseID,
                     int paymentStatusID, decimal vat, decimal salesAmount, int currencyID)
        {
            SalesID = salesID;
            SalesDate = salesDate;
            EmployeeID = employeeID;
            ClientID = clientID;
            WarehouseID = warehouseID;
            PaymentStatusID = paymentStatusID;
            VAT = vat;
            SalesAmount = salesAmount;
            CurrencyID = currencyID;
        }

        public int INSERT(DataTable tSales)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcSales", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputIdParam = new SqlParameter("@SalesID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        cmd.Parameters.AddWithValue("@Operation", "INSERT");
                        cmd.Parameters.Add(outputIdParam);
                        cmd.Parameters.AddWithValue("@SalesDate", SalesDate);
                        cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                        cmd.Parameters.AddWithValue("@ClientID", ClientID);
                        cmd.Parameters.AddWithValue("@WarehouseID", WarehouseID);
                        cmd.Parameters.AddWithValue("@PaymentStatusID", PaymentStatusID);
                        cmd.Parameters.AddWithValue("@VAT", VAT);
                        cmd.Parameters.AddWithValue("@SalesAmount", SalesAmount);
                        cmd.Parameters.AddWithValue("@CurrencyID", CurrencyID);
                        cmd.Parameters.AddWithValue("@ProductID", 0);
                        cmd.Parameters.AddWithValue("@SalesQuantity", 0);
                        cmd.Parameters.AddWithValue("@SalesPrice", 0);
                        cmd.Parameters.AddWithValue("@SalesDiscount", 0);
                        cmd.Parameters.AddWithValue("@User", LoggedUser.UserID);

                        // ✅ Updated TVP name and parameter name
                        SqlParameter tvpParam = new SqlParameter("@tSales", SqlDbType.Structured)
                        {
                            TypeName = "dbo.tSales", // updated type
                            Value = tSales            // updated variable name
                        };
                        cmd.Parameters.Add(tvpParam);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        this.SalesID = (int)outputIdParam.Value;
                        return this.SalesID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during INSERT: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public bool UPDATE(DataTable tProducts)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcSales", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", "UPDATE");
                        cmd.Parameters.AddWithValue("@SalesID", SalesID);
                        cmd.Parameters.AddWithValue("@SalesDate", SalesDate);
                        cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                        cmd.Parameters.AddWithValue("@ClientID", ClientID);
                        cmd.Parameters.AddWithValue("@WarehouseID", WarehouseID);
                        cmd.Parameters.AddWithValue("@PaymentStatusID", PaymentStatusID);
                        cmd.Parameters.AddWithValue("@VAT", VAT);
                        cmd.Parameters.AddWithValue("@SalesAmount", SalesAmount);
                        cmd.Parameters.AddWithValue("@CurrencyID", CurrencyID);
                        cmd.Parameters.AddWithValue("@ProductID", 0); // Placeholder
                        cmd.Parameters.AddWithValue("@SalesQuantity", 0); // Placeholder
                        cmd.Parameters.AddWithValue("@SalesPrice", 0); // Placeholder
                        cmd.Parameters.AddWithValue("@SalesDiscount", 0); // Placeholder
                        cmd.Parameters.AddWithValue("@User", 4); // adjust if needed

                        SqlParameter tvp = new SqlParameter("@tProducts", SqlDbType.Structured)
                        {
                            TypeName = "dbo.tProductDetails",
                            Value = tProducts
                        };
                        cmd.Parameters.Add(tvp);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during UPDATE: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
