using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class InsuranceCompany
    {
        public int InsuranceCompanyID { get; set; }
        public int CountryID { get; set; }
        public string InsCompanyEmail { get; set; }
        public string InsContactNB { get; set; }

        public InsuranceCompany(int insuranceCompanyID, int countryID, string insCompanyEmail, string insContactNB)
        {
            InsuranceCompanyID = insuranceCompanyID;
            CountryID = countryID;
            InsCompanyEmail = insCompanyEmail;
            InsContactNB = insContactNB;
        }

        public DataTable INSERT()
        {
           return prcInsuranceCompany("INSERT", this);
        }

        public DataTable UPDATE()
        {
            return prcInsuranceCompany("UPDATE", this);
        }

        public DataTable DELETE()
        {
            return prcInsuranceCompany("DELETE", this);
        }

        public DataTable SELECT()
        {
            return prcInsuranceCompany("SELECT", this);
        }

        private DataTable prcInsuranceCompany(string Operation, InsuranceCompany insuranceCompany)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcInsuranceCompany"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@InsuranceCompanyID", insuranceCompany.InsuranceCompanyID);
                        cmd.Parameters.AddWithValue("@CountryID", insuranceCompany.CountryID);
                        cmd.Parameters.AddWithValue("@InsCompanyEmail", insuranceCompany.InsCompanyEmail);
                        cmd.Parameters.AddWithValue("@InsContactNB", insuranceCompany.InsContactNB);
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
