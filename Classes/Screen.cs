using Pharmacy.Classes.UsefullClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class Screen
    {
        public int ScreenID { get; set; }
        public string ScreenName { get; set; }
        public string ScreenURL { get; set; }
        
        public Screen(int screenID, string screenName, string screenURL)
        {
            ScreenID = screenID;
            ScreenName = screenName;
            ScreenURL = screenURL;
        }
        public Screen()
        {
            ScreenName = "none";
            ScreenURL = "none";
        }
        public Screen(int screenID)
        {
            ScreenID = screenID;
            ScreenName = "none";
            ScreenURL = "none";
        }





        public DataTable INSERT() {
            return prcScreen("INSERT",this);
        }
        public DataTable UPDATE() {
            return prcScreen("UPDATE", this);
        }
        public DataTable DELETE() {
            return prcScreen("DELETE", this);
        }
        public DataTable SELECT() {
            return prcScreen("none", this); //none so it goes directly down to the SELECT * FROM tblScreens
        }





        public DataTable prcScreen(string Operation, Screen screen)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))

                {
                    using (SqlCommand cmd = new SqlCommand("prcScreens", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@ScreenID", screen.ScreenID);
                        cmd.Parameters.AddWithValue("@ScreenName", screen.ScreenName);
                        cmd.Parameters.AddWithValue("@ScreenURL", screen.ScreenURL);


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
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }
    }
}
