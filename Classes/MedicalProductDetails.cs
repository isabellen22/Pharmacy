using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class MedicalProductDetail
    {
        public int MedicalProductDetailsID { get; set; }
        public int ProductID { get; set; }
        public string Prescription { get; set; }
        public decimal Dosage { get; set; }
        public int UnitID { get; set; }

        public MedicalProductDetail(int medicalProductDetailsID, int productID, string prescription, decimal dosage, int unitID)
        {
            MedicalProductDetailsID = medicalProductDetailsID;
            ProductID = productID;
            Prescription = prescription;
            Dosage = dosage;
            UnitID = unitID;
        }

        public DataTable INSERT()
        {
           return prcMedicalProductDetails("INSERT", this);
        }

        public DataTable UPDATE()
        {
            return prcMedicalProductDetails("UPDATE", this);
        }

        public DataTable DELETE()
        {
            return prcMedicalProductDetails("DELETE", this);
        }

        public DataTable SELECT()
        {
            return prcMedicalProductDetails("SELECT", this);
        }

        private DataTable prcMedicalProductDetails(string Operation, MedicalProductDetail productDetail)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcMedicalProductDetails"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@MedicalProductDetailsID", productDetail.MedicalProductDetailsID);
                        cmd.Parameters.AddWithValue("@ProductID", productDetail.ProductID);
                        cmd.Parameters.AddWithValue("@Prescription", productDetail.Prescription);
                        cmd.Parameters.AddWithValue("@Dosage", productDetail.Dosage);
                        cmd.Parameters.AddWithValue("@UnitID", productDetail.UnitID);
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
