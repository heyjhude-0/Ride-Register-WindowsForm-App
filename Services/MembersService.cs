using Ride_Register.Data;
using Ride_Register.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Ride_Register.Services
{
    public class MembersService
    {

        public int AddMembers(string firstName, string lastName, DateTime bdate, string phoneNo, string address, string role, DateTime startDate, DateTime endDate)
        {
            DatabaseConnection db = new DatabaseConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string membershipQuery = @"Insert Into Memberships (Role, StartDate, ExpiryDate)
                                     OUTPUT INSERTED.MembershipID
                                     VALUES (@role, @startDate, @endDate)";

                SqlCommand cmd1 = new SqlCommand(membershipQuery, conn);
                cmd1.Parameters.AddWithValue("@role", role);
                cmd1.Parameters.AddWithValue("@startDate", startDate);
                cmd1.Parameters.AddWithValue("@endDate", endDate);

                int membershipID = (int)cmd1.ExecuteScalar();

                string memberQuery = @"Insert Into Members (FirstName, LastName, DateOfBirth, PhoneNumber, Address, MembershipID)
                                           OUTPUT INSERTED.MemberID
                                           VALUES (@firstName, @lastName, @bdate, @phoneNo, @address, @membershipID)";

                SqlCommand cmd2 = new SqlCommand(memberQuery, conn);
                cmd2.Parameters.AddWithValue("@firstName", firstName);
                cmd2.Parameters.AddWithValue("@lastName", lastName);
                cmd2.Parameters.AddWithValue("@bdate", bdate);
                cmd2.Parameters.AddWithValue("@phoneNo", phoneNo);
                cmd2.Parameters.AddWithValue("@address", address);
                cmd2.Parameters.AddWithValue("@membershipID", membershipID);

                int memberID = (int)cmd2.ExecuteScalar();
                return memberID;
            }

        }
        public DataTable GetAllMembers()
        {
            DatabaseConnection db = new DatabaseConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                                SELECT m.MemberID, m.MembershipID, m.FirstName, m.LastName, m.DateOfBirth, m.PhoneNumber,
                                m.Address, ms.Role, ms.ExpiryDate, CASE WHEN GETDATE() > ms.ExpiryDate THEN 'Expired' ELSE 'Active' END AS Status,
                                CASE WHEN u.UserID IS NOT NULL THEN 'Has Account' ELSE 'No Account' END AS AccountStatus, ms.StartDate
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
                    string memberQuery = @"UPDATE Members SET FirstName = @fname, LastName = @lname, DateOfBirth = @bdate, PhoneNumber = @phone, Address = @address" +
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

        public DataTable GetAllMembersForCmb()
        {
            DatabaseConnection db = new DatabaseConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"SELECT m.MemberID, m.FirstName + ' ' + m.LastName AS FullName FROM Members m";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                DataTable table = new DataTable();
                da.Fill(table);

                return table;
            }
        }

        public DataTable GetDriversForCmb()
        {
            DatabaseConnection db = new DatabaseConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"SELECT m.MemberID, m.FirstName + ' ' + m.LastName AS FullName
                                FROM Members m
                                JOIN Memberships ms on ms.MembershipID = m.MembershipID
                                WHERE ms.Role = 'Driver' OR ms.Role = 'Driver/Operator';";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                DataTable table = new DataTable();
                da.Fill(table);

                return table;
            }
        }

        public void RenewMembership(int membershipID, DateTime newExpiryDate)
        {
            DatabaseConnection db = new DatabaseConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"UPDATE Memberships SET ExpiryDate = @expiryDate WHERE MembershipID = @membershipID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@expiryDate", newExpiryDate);
                cmd.Parameters.AddWithValue("@membershipID", membershipID);

                cmd.ExecuteNonQuery();
            }
        }

    }
}
