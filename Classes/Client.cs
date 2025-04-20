using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class Client
    {
        public int ClientID { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public string ClientAddress { get; set; }
        public string ClientContactNB { get; set; }
        public int CountyID { get; set; }

        // Constructor to initialize the properties
        public Client(int clientID, string clientFirstName, string clientLastName, string clientAddress, string clientContactNB, int countyID)
        {
            ClientID = clientID;
            ClientFirstName = clientFirstName;
            ClientLastName = clientLastName;
            ClientAddress = clientAddress;
            ClientContactNB = clientContactNB;
            CountyID = countyID;
        }
        public Client()
        {
            ClientID = 0;
            ClientFirstName = "none";
            ClientLastName = "none";
            ClientAddress = "none";
            ClientContactNB = "none";
            CountyID = 0;
        }
        public Client(int clientID)
        {
            ClientID = clientID;
            ClientFirstName = "none";
            ClientLastName = "none";
            ClientAddress = "none";
            ClientContactNB = "none";
            CountyID = 0;
        }

        // Methods for CRUD operations
        public DataTable INSERT()
        {
           return prcClient("INSERT", this);
        }

        public DataTable UPDATE()
        {
           return prcClient("UPDATE", this);
        }

        public DataTable DELETE()
        {
           return prcClient("DELETE", this);
        }

        public DataTable SELECT()
        {
           return prcClient("none", this);
        }

        // Method to interact with the stored procedure
        private DataTable prcClient(string Operation, Client client)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcClient"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Adding parameters for the stored procedure
                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@ClientID", client.ClientID);
                        cmd.Parameters.AddWithValue("@ClientFirstName", client.ClientFirstName);
                        cmd.Parameters.AddWithValue("@ClientLastName", client.ClientLastName);
                        cmd.Parameters.AddWithValue("@ClientAddress", client.ClientAddress);
                        cmd.Parameters.AddWithValue("@ClientContactNB", client.ClientContactNB);
                        cmd.Parameters.AddWithValue("@CountyID", client.CountyID);
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
