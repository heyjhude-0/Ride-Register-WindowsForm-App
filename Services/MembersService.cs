using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Ride_Register.Data;
using System.Windows.Forms;

namespace Ride_Register.Services
{
    public class MembersService
    {
        public DataTable GetAllMembers()
        {
            DatabaseConnection db = new DatabaseConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                                SELECT m.MemberID, m.MembershipID, m.FirstName, m.LastName, m.DateOfBirth, m.PhoneNumber,
                                m.Address, ms.Role, CASE WHEN GETDATE() > ms.ExpiryDate THEN 'Expired' ELSE 'Active' END AS MembershipStatus,
                                CASE WHEN u.UserID IS NOT NULL THEN 'Has Account' ELSE 'No Account' END AS AccountStatus
                                FROM Members m 
                                JOIN Memberships ms ON ms.MembershipID = m.MembershipID
                                LEFT JOIN Users u ON u.MemberID = m.MemberID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public void UpdateMembers (int memberID, int membershipID, string fname, string lname, DateTime bdate, string phone, string address, string role)
        {
            DatabaseConnection db = new DatabaseConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    string memberQuery = @"UPDATE Members" +
                        "                 SET FirstName = @fname, LastName = @lname, DateOfBirth = @bdate, PhoneNumber = @phone, Address = @address" +
                        "                 WHERE MemberID = @memberID";

                    SqlCommand cmd1 = new SqlCommand(memberQuery, conn, trans);
                    cmd1.Parameters.AddWithValue("@fname", fname);
                    cmd1.Parameters.AddWithValue("@lname", lname);
                    cmd1.Parameters.AddWithValue("@bdate", bdate);
                    cmd1.Parameters.AddWithValue("@phone", phone);
                    cmd1.Parameters.AddWithValue("@address", address);
                    cmd1.Parameters.AddWithValue("@memberID", memberID);

                    cmd1.ExecuteNonQuery();

                    string roleQuery = @"UPDATE Memberships SET Role = @role WHERE MembershipID = @membershipID";

                    SqlCommand cmd2 = new SqlCommand(roleQuery, conn, trans);
                    cmd2.Parameters.AddWithValue("@role", role);
                    cmd2.Parameters.AddWithValue("@membershipID", membershipID);

                    cmd2.ExecuteNonQuery();

                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
;                }
            }


        }

        public void DeleteMembers(int memberID)
        {
            DatabaseConnection db2 = new DatabaseConnection();

            using (SqlConnection conn = db2.GetConnection())
            {
                conn.Open();

                string query = @"DELETE FROM Members where memberID = @memberID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@memberID", memberID);
                cmd.ExecuteNonQuery();

                
            }
        }
    }
}
