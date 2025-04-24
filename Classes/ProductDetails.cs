using Pharmacy.Classes.UsefullClasses;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace Pharmacy.Classes
{
    public class ProductDetail
    {
        public int ProductDetailsID { get; set; }
        public int ProductID { get; set; }
        public DateTime ProductProdDate { get; set; }
        public DateTime ProductExpDate { get; set; }
        public decimal ProductQuantity { get; set; }
        public int PurchaseID { get; set; }

        // Constructor
        public ProductDetail()
        {
            ProductDetailsID = 0;
            ProductID = 0;
            ProductProdDate = DateTime.Now;
            ProductExpDate = DateTime.Now;
            ProductQuantity = 0;
            PurchaseID = 0;
        }

        public ProductDetail(int detailID, int productID, DateTime prodDate, DateTime expDate, decimal qty, int purchaseID)
        {
            ProductDetailsID = detailID;
            ProductID = productID;
            ProductProdDate = prodDate;
            ProductExpDate = expDate;
            ProductQuantity = qty;
            PurchaseID = purchaseID;
        }

        // Method to insert a new product detail
        public int INSERT()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcProductDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", "insert");
                        cmd.Parameters.AddWithValue("@ProductID", ProductID);
                        cmd.Parameters.AddWithValue("@ProductProdDate", ProductProdDate);
                        cmd.Parameters.AddWithValue("@ProductExpDate", ProductExpDate);
                        cmd.Parameters.AddWithValue("@ProductQuantity", ProductQuantity);
                        cmd.Parameters.AddWithValue("@PurchaseID", PurchaseID);
                        cmd.Parameters.AddWithValue("@User", LoggedUser.UserID);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        return 1; // Success
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during INSERT: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        // Method to update an existing product detail
        public int UPDATE()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcProductDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", "update");
                        cmd.Parameters.AddWithValue("@ProductDetailsID", ProductDetailsID);
                        cmd.Parameters.AddWithValue("@ProductID", ProductID);
                        cmd.Parameters.AddWithValue("@ProductProdDate", ProductProdDate);
                        cmd.Parameters.AddWithValue("@ProductExpDate", ProductExpDate);
                        cmd.Parameters.AddWithValue("@ProductQuantity", ProductQuantity);
                        cmd.Parameters.AddWithValue("@PurchaseID", PurchaseID);
                        cmd.Parameters.AddWithValue("@User", LoggedUser.UserID);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        return 1; // Success
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during UPDATE: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        // Method to delete a product detail
        public int DELETE()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcProductDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", "delete");
                        cmd.Parameters.AddWithValue("@ProductDetailsID", ProductDetailsID);
                        cmd.Parameters.AddWithValue("@User", LoggedUser.UserID);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        return 1; // Success
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during DELETE: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        // Method to fetch product details by ProductID
        public static DataTable SELECT(int productID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblProductDetails WHERE ProductID = @ProductID", con))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        sda.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during SELECT: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}
