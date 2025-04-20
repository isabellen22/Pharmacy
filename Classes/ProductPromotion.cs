using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class ProductPromotion
    {
        public int PromotionID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public DateTime PromotionDate { get; set; }

        // Constructor to initialize the properties
        public ProductPromotion(int promotionID, int productID, int quantity, decimal originalPrice, decimal discountPrice, DateTime promotionDate)
        {
            PromotionID = promotionID;
            ProductID = productID;
            Quantity = quantity;
            OriginalPrice = originalPrice;
            DiscountPrice = discountPrice;
            PromotionDate = promotionDate;
        }

        // Methods for CRUD operations
        public DataTable INSERT()
        {
           return prcProductPromotion("INSERT", this);
        }

        public DataTable UPDATE()
        {
            return prcProductPromotion("UPDATE", this);
        }

        public DataTable DELETE()
        {
            return prcProductPromotion("DELETE", this);
        }

        public DataTable SELECT()
        {
            return prcProductPromotion("SELECT", this);
        }

        // Method to interact with the stored procedure
        private DataTable prcProductPromotion(string Operation, ProductPromotion productPromotion)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcProductPromotion"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Adding parameters for the stored procedure
                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@PromotionID", productPromotion.PromotionID);
                        cmd.Parameters.AddWithValue("@ProductID", productPromotion.ProductID);
                        cmd.Parameters.AddWithValue("@Quantity", productPromotion.Quantity);
                        cmd.Parameters.AddWithValue("@OriginalPrice", productPromotion.OriginalPrice);
                        cmd.Parameters.AddWithValue("@DiscountPrice", productPromotion.DiscountPrice);
                        cmd.Parameters.AddWithValue("@PromotionDate", productPromotion.PromotionDate);
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
