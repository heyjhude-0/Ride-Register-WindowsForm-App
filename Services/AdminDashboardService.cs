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
    public class AdminDashboardService
    {
        public DataTable GetDashboardStats()
        {
            DatabaseConnection db = new DatabaseConnection();

            DataTable table = new DataTable();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"SELECT

                (SELECT COUNT(*) FROM Members) AS TotalMembers,

                (SELECT COUNT(*) FROM Members m
                 JOIN Memberships ms ON m.MembershipID = ms.MembershipID
                 WHERE GETDATE() <= ms.ExpiryDate) AS ActiveMembers,

                (SELECT COUNT(*) FROM Members m
                 JOIN Memberships ms ON m.MembershipID = ms.MembershipID
                 WHERE GETDATE() > ms.ExpiryDate) AS ExpiredMembers,

 
                (SELECT COUNT(*) FROM Tricycle) AS TotalTricycles,

                (SELECT COUNT(*) FROM Tricycle WHERE DriverMemberID IS NOT NULL) AS WithDriver,

                (SELECT COUNT(*) FROM Tricycle WHERE DriverMemberID IS NULL) AS WithoutDriver,

                (SELECT COUNT(*) FROM Route) AS TotalRoutes,

                (SELECT COUNT(*) FROM Tricycle
                WHERE RouteID IS NOT NULL) AS WithRoute,

                (SELECT COUNT(*) FROM Tricycle
                WHERE RouteID IS NULL) AS WithoutRoute,

                (SELECT COUNT(*) FROM Memberships
                 WHERE Role = 'Driver') AS MemberDriver,
        
                (SELECT COUNT(*) FROM Memberships
                WHERE Role = 'Operator') AS MemberOperator,

                (SELECT COUNT(*) FROM Memberships
                WHERE Role = 'Driver/Operator') AS MemberDriverOperator,

                (SELECT COUNT(*) FROM Memberships 
                WHERE ExpiryDate BETWEEN GETDATE() AND DATEADD(DAY, 30, GETDATE())) AS ExpiringMemberships
                ";



                 SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                 adapter.Fill(table);
            }

            return table;
        }

        public DataTable GetExpiringMemberships()
        {
            DatabaseConnection db =
                new DatabaseConnection();

            DataTable table =
                new DataTable();

            using (SqlConnection conn =
                db.GetConnection())
            {
                conn.Open();

                string query = @"SELECT m.MemberID, m.FirstName + ' ' + m.LastName AS FullName, ms.Role, ms.ExpiryDate,
                        DATEDIFF(DAY, GETDATE(), ms.ExpiryDate) AS DaysRemaining
                        FROM Members m 
                        JOIN Memberships ms ON m.MembershipID = ms.MembershipID
                        WHERE ms.ExpiryDate BETWEEN GETDATE() AND DATEADD(DAY, 30, GETDATE())
                        ORDER BYms.ExpiryDate ASC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(table);
            }

            return table;
        }
    }
}
