using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class Pharmacyy
    {
        public int PharmacyID { get; set; }
        public string PharmacyName { get; set; }
        public string PharmacyLocation { get; set; }
        public string PharmacySpace { get; set; }
        public string PharmacyEmail { get; set; }
        public string PharmacyContactNB { get; set; }

        // Constructor to initialize the properties
        public Pharmacyy(int pharmacyID, string pharmacyName, string pharmacyLocation, string pharmacySpace, string pharmacyEmail, string pharmacyContactNB)
        {
            PharmacyID = pharmacyID;
            PharmacyName = pharmacyName;
            PharmacyLocation = pharmacyLocation;
            PharmacySpace = pharmacySpace;
            PharmacyEmail = pharmacyEmail;
            PharmacyContactNB = pharmacyContactNB;
        }

        // Methods for CRUD operations
        public void INSERT()
        {
            prcPharmacyy("insert", this);
        }

        public void UPDATE()
        {
            prcPharmacyy("update", this);
        }

        public void DELETE()
        {
            prcPharmacyy("delete", this);
        }

        public void SELECT()
        {
            prcPharmacyy("select", this);
        }

        // Method to interact with the stored procedure
        private DataTable prcPharmacyy(string Operation, Pharmacyy pharmacyy)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcPharmacy"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Adding parameters for the stored procedure
                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@PharmacyID", pharmacyy.PharmacyID);
                        cmd.Parameters.AddWithValue("@PharmacyName", pharmacyy.PharmacyName);
                        cmd.Parameters.AddWithValue("@PharmacyLocation", pharmacyy.PharmacyLocation);
                        cmd.Parameters.AddWithValue("@PharmacySpace", pharmacyy.PharmacySpace);
                        cmd.Parameters.AddWithValue("@PharmacyEmail", pharmacyy.PharmacyEmail);
                        cmd.Parameters.AddWithValue("@PharmacyContactNB", pharmacyy.PharmacyContactNB);
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
