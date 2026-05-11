using Ride_Register.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace Ride_Register.Services
{
    public class TricycleService
    {
        public void AddTricycle(string plateNum, string model, int ownerID, int? driverID, int? routeID)
        {

            DatabaseConnection db = new DatabaseConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"Insert Into Tricycle (PlateNumber, Model, OwnerMemberID, DriverMemberID, RouteID)
                                     VALUES (@plateNum, @model, @ownerID, @driverID, @routeID)";

                SqlCommand cmd1 = new SqlCommand(query, conn);
                cmd1.Parameters.AddWithValue("@plateNum", plateNum);
                cmd1.Parameters.AddWithValue("@model", model);
                cmd1.Parameters.AddWithValue("@ownerID", ownerID);
                cmd1.Parameters.AddWithValue("@driverID", driverID ?? (object)DBNull.Value);
                cmd1.Parameters.AddWithValue("@routeID", routeID ?? (object)DBNull.Value);

                cmd1.ExecuteScalar();


            }
        }
        public DataTable GetAllTricycles()
        {
            DatabaseConnection db = new DatabaseConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                                SELECT t.TricycleID, t.PlateNumber AS Plate_Number, t.Model, t.OwnerMemberID, t.DriverMemberID, o.FirstName + ' ' + o.LastName AS Owner, ISNULL(d.FirstName + ' ' + d.LastName,'No Driver') AS Driver, r.RouteID,  ISNULL(r.RouteName,'No Route') AS Route
                                FROM Tricycle T
                                LEFT JOIN Members o on o.MemberID = t.OwnerMemberID
                                LEFT JOIN Members d on d.MemberID = t.DriverMemberID
                                LEFT JOIN Route r on r.RouteID = t.RouteID;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public void UpdateTricycle(int tricycleID, string plateNum, string model, int ownerID, int? driverID, int? routeID)
        {
            DatabaseConnection db = new DatabaseConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    string memberQuery = @"UPDATE Tricycle SET PlateNumber = @plateNum, Model = @model, OwnerMemberID = @ownerID, DriverMemberID = @driverID, RouteID = @routeID" +
                        "                 WHERE TricycleID = @tricycleID";

                    SqlCommand cmd1 = new SqlCommand(memberQuery, conn, trans);
                    cmd1.Parameters.AddWithValue("@plateNum", plateNum);
                    cmd1.Parameters.AddWithValue("@model", model);
                    cmd1.Parameters.AddWithValue("@ownerID", ownerID);
                    cmd1.Parameters.AddWithValue("@driverID", driverID ?? (object)DBNull.Value);
                    cmd1.Parameters.AddWithValue("@routeID", routeID ?? (object)DBNull.Value);
                    cmd1.Parameters.AddWithValue("@tricycleID", tricycleID);
        

                    cmd1.ExecuteNonQuery();

                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                    ;
                }
            }
        }

        public void DeleteTricycles(int tricycleID)
        {
            DatabaseConnection db = new DatabaseConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"DELETE FROM Tricycle WHERE TricycleID = @tricycleID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tricycleID", tricycleID);
                cmd.ExecuteNonQuery();


            }
        }

    }
}
