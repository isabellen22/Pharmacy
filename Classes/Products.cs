using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public bool NeedsRefrigerator { get; set; }
        public string ProductGroup { get; set; }
        public bool IsPerishable { get; set; }

        public Product()
        {
            ProductID = 0;
            ProductName = "";
            NeedsRefrigerator = false;
            ProductGroup = "";
            IsPerishable = false;
        }

        public Product(int productID, string productName, bool needsRefrigerator, string productGroup, bool isPerishable)
        {
            ProductID = productID;
            ProductName = productName;
            NeedsRefrigerator = needsRefrigerator;
            ProductGroup = productGroup;
            IsPerishable = isPerishable;
        }

        public DataTable INSERT() => prcProducts("INSERT", this);
        public DataTable UPDATE() => prcProducts("UPDATE", this);
        public DataTable DELETE() => prcProducts("DELETE", this);
        public DataTable SELECT() => prcProducts("SELECT", this);

      


        private DataTable prcProducts(string operation, Product product)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcProducts", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", operation);
                        cmd.Parameters.AddWithValue("@ProductID", product.ProductID);
                        cmd.Parameters.AddWithValue("@ProductName", product.ProductName ?? "");
                        cmd.Parameters.AddWithValue("@NeedsRefrigerator", product.NeedsRefrigerator);
                        cmd.Parameters.AddWithValue("@ProductGroup", product.ProductGroup ?? "");
                        cmd.Parameters.AddWithValue("@IsPerishable", product.IsPerishable);
                        cmd.Parameters.AddWithValue("@User", LoggedUser.UserID);

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(dt);
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("This product is linked to another table and cannot be deleted.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}
