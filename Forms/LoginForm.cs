using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Ride_Register.Data;
using Ride_Register.Forms;

namespace Ride_Register
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        //private void ReadUsers()
        //{
        //    DataTable dataTable = new DataTable();

        //    dataTable.Columns.Add("ID");
        //    dataTable.Columns.Add("Username");
        //    dataTable.Columns.Add("Password");
        //}
        private void button1_Click(object sender, EventArgs e)
        {
           
                try
                {
                    DbConnection db = new DbConnection();

                    using (SqlConnection conn = db.GetConnection())
                    {
                        conn.Open();

                        string query = "SELECT * FROM Users";

                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridViewUsers.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            this.Hide();
            ad.ShowDialog();
            this.Close();
        }
    }
}
