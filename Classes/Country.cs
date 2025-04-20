using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }

        public Country(int countryID, string countryName, string countryCode)
        {
            CountryID = countryID;
            CountryName = countryName;
            CountryCode = countryCode;
        }
        public Country()
        {
            CountryID = 0;
            CountryName = "none";
            CountryCode = "000";
        }

        public DataTable INSERT()
        {
            return prcCountry("INSERT", this);
        }

        public DataTable UPDATE()
        {
            return prcCountry("UPDATE", this);
        }

        public DataTable DELETE()
        {
            return prcCountry("DELETE", this);
        }

        public DataTable SELECT()
        {
            return prcCountry("none", this);
        }

        private DataTable prcCountry(string Operation, Country country)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcCountry"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Operation", Operation);

                        // Add parameters for Country
                        cmd.Parameters.AddWithValue("@CountryID", country.CountryID);
                        cmd.Parameters.AddWithValue("@CountryName", country.CountryName);
                        cmd.Parameters.AddWithValue("@CountryCode", country.CountryCode);
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
                throw;
            }
            return dt;
        }
    }
}
