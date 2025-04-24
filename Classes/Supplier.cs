using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierContactNB { get; set; }
        public int CountryID { get; set; }

        public Supplier()
        {
            SupplierID = 0;
            SupplierName = "";
            SupplierEmail = "";
            SupplierContactNB = "";
            CountryID = 0;
        }

        public Supplier(int supplierID, string supplierName, string supplierEmail, string supplierContactNB, int countryID)
        {
            SupplierID = supplierID;
            SupplierName = supplierName;
            SupplierEmail = supplierEmail;
            SupplierContactNB = supplierContactNB;
            CountryID = countryID;
        }

        public DataTable INSERT() => prcSupplier("INSERT", this);
        public DataTable UPDATE() => prcSupplier("UPDATE", this);
        public DataTable DELETE() => prcSupplier("DELETE", this);
        public DataTable SELECT() => prcSupplier("SELECT", this);

        private DataTable prcSupplier(string operation, Supplier supplier)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcSupplier", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", operation);
                        cmd.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                        cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName ?? "");
                        cmd.Parameters.AddWithValue("@SupplierEmail", supplier.SupplierEmail ?? "");
                        cmd.Parameters.AddWithValue("@SupplierContactNB", supplier.SupplierContactNB ?? "");
                        cmd.Parameters.AddWithValue("@CountyID", supplier.CountryID);
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
                MessageBox.Show("This supplier is linked to another record and cannot be deleted.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }
    }
}
