using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy.Classes.UsefullClasses;

namespace Pharmacy.Classes
{
    internal class UsersPasswords
    {
        private int UserID { get; set; }
        private string UserName { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private int RoleID { get; set; }
        
        public UsersPasswords(int userID, string userName, string email, string password, int roleID)
        {
            UserID = userID;
            UserName = userName;
            Email = email;
            Password = password;
            RoleID = roleID;
        }

        public UsersPasswords()
        {
            UserID = 0;
            UserName = "none";
            Email = "none";
            Password = "password";
            RoleID = 0;
        }
        public UsersPasswords(int userID)
        {
            UserID = userID;
            UserName = "none";
            Email = "none";
            Password = "password";
            RoleID = 0;
        }


        public DataTable INSERT()
        {

            return prcUsersPasswords("INSERT", this);
        }
        public DataTable UPDATE()
        {

           return prcUsersPasswords("UPDATE", this);
        }
        public DataTable DELETE()
        {

           return prcUsersPasswords("DELETE", this);
        }

        public DataTable SELECT()
        {
           return prcUsersPasswords("none", this);
        }

        public DataTable LOGIN()
        {
            return prcUsersPasswords("LOGIN", this);
        }



        private DataTable prcUsersPasswords(string Operation, UsersPasswords user)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))

                {
                    using (SqlCommand cmd = new SqlCommand("prcUsersPasswords", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@UserID", user.UserID);
                        cmd.Parameters.AddWithValue("@UserName", user.UserName);
                        cmd.Parameters.AddWithValue("@Email", user.Email);
                        cmd.Parameters.AddWithValue("@Password", user.Password);
                        cmd.Parameters.AddWithValue("@RoleID", user.RoleID);


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
