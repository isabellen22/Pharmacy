using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class InsuranceContract
    {
        public int ClientID { get; set; }
        public int InsuranceCompanyID { get; set; }
        public decimal PercentageCoverage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public InsuranceContract(int clientID, int insuranceCompanyID, decimal percentageCoverage, DateTime startDate, DateTime endDate)
        {
            ClientID = clientID;
            InsuranceCompanyID = insuranceCompanyID;
            PercentageCoverage = percentageCoverage;
            StartDate = startDate;
            EndDate = endDate;
        }

        public DataTable INSERT()
        {
           return prcInsuranceContract("INSERT", this);
        }

        public DataTable UPDATE()
        {
            return prcInsuranceContract("UPDATE", this);
        }

        public DataTable DELETE()
        {
            return prcInsuranceContract("DELETE", this);
        }

        public DataTable SELECT()
        {
            return prcInsuranceContract("SELECT", this);
        }

        private DataTable prcInsuranceContract(string Operation, InsuranceContract contract)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcInsuranceContract"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@ClientID", contract.ClientID);
                        cmd.Parameters.AddWithValue("@InsuranceCompanyID", contract.InsuranceCompanyID);
                        cmd.Parameters.AddWithValue("@PercentageCoverage", contract.PercentageCoverage);
                        cmd.Parameters.AddWithValue("@StartDate", contract.StartDate);
                        cmd.Parameters.AddWithValue("@EndDate", contract.EndDate);
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
