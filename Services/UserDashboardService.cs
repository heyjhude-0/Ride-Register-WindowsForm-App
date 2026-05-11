using Ride_Register.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Register.Services
{
    public class UserDashboardService
    {
        public DataTable GetUserDashboardData(int userID)
        {
            DatabaseConnection db = new DatabaseConnection();
            DataTable table = new DataTable();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT u.UserID, u.Username, u.Role AS AccountRole, m.MemberID, m.FirstName, m.LastName, m.DateOfBirth, m.PhoneNumber, m.Address, ms.MembershipID,
                    ms.Role AS MembershipRole, ms.StartDate, ms.ExpiryDate, CASE WHEN GETDATE() > ms.ExpiryDate THEN 'Expired' ELSE 'Active' END AS MembershipStatus
                    FROM Users u
                    JOIN Members m ON u.MemberID = m.MemberID
                    JOIN Memberships ms ON m.MembershipID = ms.MembershipID
                    WHERE u.UserID = @userID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userID", userID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
            }

            return table;
        }

        public DataTable GetUserTricycleData(int userID)
        {
            DatabaseConnection db = new DatabaseConnection();
            DataTable table = new DataTable();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT t.TricycleID, t.PlateNumber, t.Model, t.DriverMemberID, t.OwnerMemberID, t.RouteID
                    FROM Tricycle t
                    WHERE t.DriverMemberID = (SELECT m.MemberID FROM Members m JOIN Users u ON u.MemberID = m.MemberID WHERE u.UserID = @userID)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userID", userID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
            }

            return table;
        }

        public DataTable GetUserRouteData(int userID)
        {
            DatabaseConnection db = new DatabaseConnection();
            DataTable table = new DataTable();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT r.RouteID, r.RouteName, r.StartPoint, r.EndPoint, r.Fare
                    FROM Route r WHERE r.RouteID IN (SELECT t.RouteID FROM Tricycle t 
                        WHERE t.DriverMemberID = (SELECT m.MemberID FROM Members m JOIN Users u ON u.MemberID = m.MemberID WHERE u.UserID = @userID))";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userID", userID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
            }

            return table;
        }
    }
}