using Pharmacy.Classes.UsefullClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        
        public Role(int roleID, string roleName)
        {
            RoleID = roleID;
            RoleName = roleName;
        }
        public Role(int roleID)
        {
            RoleID = roleID;
            RoleName = "none";
        }
        public Role()
        {
            RoleID = 0;
            RoleName = "none";
        }

        public DataTable INSERT() {

            return prcRole("INSERT", this);
        }
        public DataTable UPDATE() {

            return prcRole("UPDATE", this);
        }
        public DataTable DELETE() {

            return prcRole("DELETE", this);
        }

        public DataTable SELECT()
        {
          return  prcRole("none", this);
        }


        private DataTable prcRole(string Operation, Role role)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))

                {
                    using (SqlCommand cmd = new SqlCommand("prcRole", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@RoleID", role.RoleID);
                        cmd.Parameters.AddWithValue("@RoleName", role.RoleName);
                        

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
