using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class Warehouse
    {
        public int WarehouseID { get; set; }
        public string WarehouseName { get; set; }
        public string WarehouseLocation { get; set; }
        public string WarehouseSpace { get; set; }
        public int User { get; set; } 

        public Warehouse(int warehouseID, string warehouseName, string warehouseLocation, string warehouseSpace, int user)
        {
            WarehouseID = warehouseID;
            WarehouseName = warehouseName;
            WarehouseLocation = warehouseLocation;
            WarehouseSpace = warehouseSpace;
            User = user;
        }

        public Warehouse()
        {
        }

        public DataTable INSERT()
        {
            return prcWarehouse("INSERT", this);
        }

        public DataTable UPDATE()
        {
            return prcWarehouse("UPDATE", this);
        }

        public DataTable DELETE()
        {
            return prcWarehouse("DELETE", this);
        }

        public DataTable SELECT()
        {
            return prcWarehouse("select", this); 
        }

        // Method to interact with stored procedure
        private DataTable prcWarehouse(string Operation, Warehouse warehouse)
        {
             DataTable dt = new DataTable();
        try
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.Value))
            using (SqlCommand cmd = new SqlCommand("prcWarehouse", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Operation", Operation);
                cmd.Parameters.AddWithValue("@WarehouseID", WarehouseID);
                cmd.Parameters.AddWithValue("@WarehouseName", WarehouseName ?? "");
                cmd.Parameters.AddWithValue("@WarehouseLocation", WarehouseLocation ?? "");
                cmd.Parameters.AddWithValue("@WarehouseSpace", WarehouseSpace ?? "");
                cmd.Parameters.AddWithValue("@User", LoggedUser.UserID);

                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    sda.Fill(dt);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}", "Warehouse DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return dt;
    }
        

        public string WarehouseFullName => $"{WarehouseName} - {WarehouseLocation}";
    }
}
