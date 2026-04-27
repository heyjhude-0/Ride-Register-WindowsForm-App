using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Register.Data
{
    public class DbConnection
    {
        private string connectionString = "Data Source=DESKTOP-QMT1Q3U\\SQLEXPRESS;Initial Catalog=RideRegister_DB;Integrated Security=True;TrustServerCertificate=True";


        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
