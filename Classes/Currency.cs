using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class Currency
    {
        private string v1;
        private int v2;
        private DateTime now;

        public int CurrencyID { get; set; }
        public string CurrencyCode { get; set; }
        public int RateID { get; set; }
        public string CurrencyName { get; set; }
        public decimal CurrencyRate { get; set; }
        public DateTime CurrencyRateDate { get; set; }

        // Constructor to initialize the properties
        public Currency(int currencyID, string currencyCode, string currencyName, decimal currencyRate, DateTime currencyRateDate, int rateID)
        {
            CurrencyID = currencyID;
            CurrencyCode = currencyCode;
            CurrencyName = currencyName;
            CurrencyRate = currencyRate;
            CurrencyRateDate = currencyRateDate;
            RateID = rateID;
        }

        public Currency(int currencyID, string currencyName)
        {
            CurrencyID = currencyID;
            CurrencyName = currencyName;
        }

        public Currency(int currencyID, string currencyName, string v1, int v2, DateTime now) : this(currencyID, currencyName)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.now = now;
        }

        public override string ToString()
        {
            return CurrencyName; 
        }

        public DataTable INSERT()
        {
           return prcCurrency("INSERT", this);
        }

        public DataTable UPDATE()
        {
           return prcCurrency("UPDATE", this);
        }

        public DataTable DELETE()
        {
            return prcCurrency("DELETE", this);
        }

        public DataTable SELECT()
        {

            return prcCurrency("SELECT", new Currency(0, "", "", 0, DateTime.Now, 0));

        }
        
        // Method to interact with the stored procedure
        private DataTable prcCurrency(string Operation, Currency currency)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcCurrency"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Adding parameters for the stored procedure
                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@CurrencyID", currency.CurrencyID);
                        cmd.Parameters.AddWithValue("@CurrencyCode", currency.CurrencyCode);
                        cmd.Parameters.AddWithValue("@CurrencyName", currency.CurrencyName);
                        cmd.Parameters.AddWithValue("@CurrencyRate", currency.CurrencyRate);
                        cmd.Parameters.AddWithValue("@RateID", currency.RateID);
                        cmd.Parameters.AddWithValue("@CurrencyRateDate", currency.CurrencyRateDate);
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
