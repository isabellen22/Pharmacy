using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public bool NeedsRefrigerator { get; set; }
        public string ProductGroup { get; set; }

        public int ProductDetailsID { get; set; }
        public DateTime? ProductProdDate { get; set; }
        public DateTime? ProductExpDate { get; set; }
        public decimal ProductQuantity { get; set; }
        public int PurchaseID { get; set; }

        // Constructor
        public Product(int productID, string productName, bool needsRefrigerator, string productGroup,
                       int productDetailsID, DateTime productProdDate, DateTime productExpDate,
                       decimal productQuantity, int purchaseID)
        {
            ProductID = productID;
            ProductName = productName;
            NeedsRefrigerator = needsRefrigerator;
            ProductGroup = productGroup;
            ProductDetailsID = productDetailsID;
            ProductProdDate = productProdDate;
            ProductExpDate = productExpDate;
            ProductQuantity = productQuantity;
            PurchaseID = purchaseID;
        }
        public Product(int productID,
                       int productDetailsID, DateTime productProdDate, DateTime productExpDate,
                       decimal productQuantity, int purchaseID)
        {
            ProductID = productID;
            ProductDetailsID = productDetailsID;
            ProductProdDate = productProdDate;
            ProductExpDate = productExpDate;
            ProductQuantity = productQuantity;
            PurchaseID = purchaseID;
        }
        // Method to add details if needed
        public void AddProductDetail(int productDetailsID, DateTime productProdDate, DateTime productExpDate, decimal productQuantity)
        {
            ProductDetailsID = productDetailsID;
            ProductProdDate = productProdDate;
            ProductExpDate = productExpDate;
            ProductQuantity = productQuantity;
        }



        public void INSERT(DataTable productDetailsData)
        {
            try
            {
                // Debugging: Display DataTable contents
                string dataTableContent = "DataTable Contents:\n";
                foreach (DataRow row in productDetailsData.Rows)
                {
                    foreach (DataColumn col in productDetailsData.Columns)
                    {
                        dataTableContent += $"{col.ColumnName}: {row[col]}\t";
                    }
                    dataTableContent += "\n";
                }
                MessageBox.Show(dataTableContent, "DataTable Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcProducts"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Operation", "insert");
                        cmd.Parameters.AddWithValue("@ProductID", ProductID);
                        cmd.Parameters.AddWithValue("@ProductName", ProductName);
                        cmd.Parameters.AddWithValue("@NeedsRefrigerator", NeedsRefrigerator);
                        cmd.Parameters.AddWithValue("@ProductGroup", ProductGroup);
                        cmd.Parameters.AddWithValue("@ProductDetailsID", ProductDetailsID);
                        cmd.Parameters.AddWithValue("@ProductProdDate", productDetailsData.Rows[0]["ProductProdDate"]);
                        cmd.Parameters.AddWithValue("@ProductExpDate", productDetailsData.Rows[0]["ProductExpDate"]);
                        cmd.Parameters.AddWithValue("@ProductQuantity", productDetailsData.Rows[0]["ProductQuantity"]);
                        cmd.Parameters.AddWithValue("@PurchaseID", 2);
                        cmd.Parameters.AddWithValue("@User", LoggedUser.UserID);

                        // Add the table-valued parameter
                        SqlParameter tvpParam = cmd.Parameters.AddWithValue("@tProducts", productDetailsData);
                        tvpParam.SqlDbType = SqlDbType.Structured;
                        tvpParam.TypeName = "tPurchaseDetails";

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void INSERTProductDetails(int productID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcProducts"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Operation", "insert");
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        cmd.Parameters.AddWithValue("@ProductName", ProductName);
                        cmd.Parameters.AddWithValue("@NeedsRefrigerator", NeedsRefrigerator);
                        cmd.Parameters.AddWithValue("@ProductGroup", ProductGroup);
                        cmd.Parameters.AddWithValue("@ProductDetailsID", ProductDetailsID);
                        cmd.Parameters.AddWithValue("@ProductProdDate", ProductProdDate);
                        cmd.Parameters.AddWithValue("@ProductExpDate", ProductExpDate);
                        cmd.Parameters.AddWithValue("@ProductQuantity", ProductQuantity);
                        cmd.Parameters.AddWithValue("@PurchaseID", PurchaseID);
                        cmd.Parameters.AddWithValue("@User", LoggedUser.UserID);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                if (ProductDetailsID > 0)
                {
                    INSERTProductDetails(ProductID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // UPDATE method to update Product and its details in the database
        public void UPDATE()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcProduct"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Operation", "update");
                        cmd.Parameters.AddWithValue("@ProductID", ProductID);
                        cmd.Parameters.AddWithValue("@ProductName", ProductName);
                        cmd.Parameters.AddWithValue("@NeedsRefrigerator", NeedsRefrigerator);
                        cmd.Parameters.AddWithValue("@ProductGroup", ProductGroup);
                        cmd.Parameters.AddWithValue("@ProductDetailsID", ProductDetailsID);
                        cmd.Parameters.AddWithValue("@ProductProdDate", ProductProdDate);
                        cmd.Parameters.AddWithValue("@ProductExpDate", ProductExpDate);
                        cmd.Parameters.AddWithValue("@ProductQuantity", ProductQuantity);
                        cmd.Parameters.AddWithValue("@PurchaseID", PurchaseID);
                        cmd.Parameters.AddWithValue("@User", LoggedUser.UserID);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                if (ProductDetailsID > 0) // If details exist, update them as well
                {
                    UPDATEProductDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // UPDATE method to update Product Details in the database
        private void UPDATEProductDetails()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcProductDetails"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Operation", "update");
                        cmd.Parameters.AddWithValue("@ProductDetailsID", ProductDetailsID);
                        cmd.Parameters.AddWithValue("@ProductProdDate", ProductProdDate);
                        cmd.Parameters.AddWithValue("@ProductExpDate", ProductExpDate);
                        cmd.Parameters.AddWithValue("@ProductQuantity", ProductQuantity);
                        cmd.Parameters.AddWithValue("@User", LoggedUser.UserID);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // DELETE method to delete the Product and its details from the database
        public void DELETE()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcProduct"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Operation", "delete");
                        cmd.Parameters.AddWithValue("@ProductID", ProductID);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                if (ProductDetailsID > 0) // If details exist, delete them as well
                {
                    DELETEProductDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static DataTable GetProductBasicInfo(int productID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("prcGetProductBasicInfo", con)) // Assuming you have a stored procedure for basic product info
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ProductID", productID);

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


        // DELETE method to delete Product Details from the database
        private void DELETEProductDetails()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcProductDetails"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Operation", "delete");
                        cmd.Parameters.AddWithValue("@ProductDetailsID", ProductDetailsID);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // SELECT method to retrieve the Product and its details from the database

    }
}
