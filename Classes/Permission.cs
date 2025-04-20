using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class Permission
    {
        public int RoleID { get; set; }
        public int ScreenID { get; set; }
        public byte CanView { get; set; }
        public byte CanEdit { get; set; }
        public byte CanDelete { get; set; }
        public byte CanAdd { get; set; }

        public Permission(int roleID, int screenID, byte canView, byte canEdit, byte canDelete, byte canAdd)
        {
            RoleID = roleID;
            ScreenID = screenID;
            CanView = canView;
            CanEdit = canEdit;
            CanDelete = canDelete;
            CanAdd = canAdd;
        }

        public Permission()
        {
            RoleID = 0;
            ScreenID = 0;
            CanView = 0;
            CanEdit = 0;
            CanDelete = 0;
            CanAdd = 0;
        }
        public Permission(int roleID, int screenID)
        {
            RoleID = roleID;
            ScreenID = screenID;
            CanView = 0;
            CanEdit = 0;
            CanDelete = 0;
            CanAdd = 0;
        }




        public DataTable INSERT()
        {
            return prcPermissions("INSERT", this);
        }

        public DataTable UPDATE()
        {
            return prcPermissions("UPDATE", this);
        }

        public DataTable DELETE()
        {
            return prcPermissions("DELETE", this);
        }

        public DataTable SELECT()
        {
            return prcPermissions("none", this);
        }

        // Method to interact with the stored procedure
        private DataTable prcPermissions(string Operation, Permission permission)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))

                {
                    using (SqlCommand cmd = new SqlCommand("prcPermissions"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@RoleID", permission.RoleID);
                        cmd.Parameters.AddWithValue("@ScreenID", permission.ScreenID);
                        cmd.Parameters.AddWithValue("@CanView", permission.CanView);
                        cmd.Parameters.AddWithValue("@CanEdit", permission.CanEdit);
                        cmd.Parameters.AddWithValue("@CanDelete", permission.CanDelete);
                        cmd.Parameters.AddWithValue("@CanAdd", permission.CanAdd);

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
