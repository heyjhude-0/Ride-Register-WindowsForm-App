using Ride_Register.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Ride_Register.Services
{
    public class RouteService
    {

        public int AddRoute(string routeName, string startPoint, string endPoint, decimal fare)
        {
            DatabaseConnection db = new DatabaseConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"Insert Into Route (RouteName, StartPoint, EndPoint, Fare)
                                     OUTPUT INSERTED.RouteID
                                     VALUES (@routeName, @startPoint, @endPoint, @fare)";

                SqlCommand cmd1 = new SqlCommand(query, conn);
                cmd1.Parameters.AddWithValue("@routeName", routeName);
                cmd1.Parameters.AddWithValue("@startPoint", startPoint);
                cmd1.Parameters.AddWithValue("@endPoint", endPoint);
                cmd1.Parameters.AddWithValue("@fare", fare);




                int routeID = (int)cmd1.ExecuteScalar();
                return routeID;

            }
        }

        public DataTable GetRoutes()
        {
            DatabaseConnection db = new DatabaseConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"Select r.RouteID, COUNT(t.TricycleID) AS TricycleCount, r.RouteName, r.StartPoint, r.EndPoint, r.Fare 
                                FROM Route r
                                LEFT JOIN Tricycle t on t.RouteID = r.RouteID
                                GROUP BY r.RouteID, r.RouteName, r.StartPoint, r.EndPoint, r.Fare ;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public void UpdateRoute(int routeID, string routeName, string startPoint, string endPoint, decimal fare)
        {
            DatabaseConnection db = new DatabaseConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    string query = @"UPDATE Route SET RouteName = @routeName, StartPoint = @startPoint, Endpoint = @endPoint, Fare = @fare" +
                        "                 WHERE RouteID = @routeID";

                    SqlCommand cmd1 = new SqlCommand(query, conn, trans);
                    cmd1.Parameters.AddWithValue("@routeName", routeName);
                    cmd1.Parameters.AddWithValue("@startPoint", startPoint);
                    cmd1.Parameters.AddWithValue("@endPoint", endPoint);
                    cmd1.Parameters.AddWithValue("@fare", fare);
                    cmd1.Parameters.AddWithValue("@routeID", routeID);

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

        public void DeleteRoute(int routeID)
        {
            DatabaseConnection db2 = new DatabaseConnection();

            using (SqlConnection conn = db2.GetConnection())
            {
                conn.Open();

                string query = @"DELETE FROM Route where routeID = @routeID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@routeID", routeID);
                cmd.ExecuteNonQuery();

                
            }
        }
        public DataTable GetRoutesforCmb()
        {
            DatabaseConnection db = new DatabaseConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"SELECT RouteID, RouteName FROM Route";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                DataTable table = new DataTable();
                da.Fill(table);

                return table;
            }
        }

    }

}

