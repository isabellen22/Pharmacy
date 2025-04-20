using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy.Classes
{
    internal class EmployeeSchedule
    {
        public int ScheduleID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime ScStartTime { get; set; }
        public DateTime ScEndTime { get; set; }
        public int PharmacyID { get; set; }

        public EmployeeSchedule(int scheduleID, int employeeID, DateTime scStartTime, DateTime scEndTime, int pharmacyID)
        {
            ScheduleID = scheduleID;
            EmployeeID = employeeID;
            ScStartTime = scStartTime;
            ScEndTime = scEndTime;
            PharmacyID = pharmacyID;
        }

        public EmployeeSchedule(Employee employee) // Overloaded constructor for retrieval
        {
            EmployeeID = employee.EmployeeID;
        }

        public void INSERT()
        {
            prcEmployeeSchedule("insert", this);
        }

        public void UPDATE()
        {
            prcEmployeeSchedule("update", this);
        }

        public void DELETE()
        {
            prcEmployeeSchedule("delete", this);
        }

        private DataTable prcEmployeeSchedule(string Operation, EmployeeSchedule schedule)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.Value))
                {
                    using (SqlCommand cmd = new SqlCommand("prcEmployeeSchedule"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Operation", Operation);
                        cmd.Parameters.AddWithValue("@ScheduleID", schedule.ScheduleID);
                        cmd.Parameters.AddWithValue("@EmployeeID", schedule.EmployeeID);
                        cmd.Parameters.AddWithValue("@ScStartTime", schedule.ScStartTime);
                        cmd.Parameters.AddWithValue("@ScEndTime", schedule.ScEndTime);
                        cmd.Parameters.AddWithValue("@PharmacyID", schedule.PharmacyID);
                        cmd.Parameters.AddWithValue("@User", 4);

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

        public static DataTable GetEmployeeSchedule(int employeeID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection("Server=localhost;Database=PharmacyDB;Trusted_Connection=True;"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("prcGetEmployeeSchedule", con)) // Assuming you have this stored procedure
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeID); // Corrected parameter

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
