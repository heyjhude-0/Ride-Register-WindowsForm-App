using Ride_Register.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ride_Register.Data;

namespace Ride_Register
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (userBox.Text == "")
        //        {
        //            userBox.Text = "Enter username";
        //            return;
        //        }
        //        userBox.ForeColor = Color.Black;
        //        panel3.Visible = false;
        //    }
        //    catch { }
        //}

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (passBox.Text == "")
        //        {
        //            passBox.Text = "Password";
        //            return;
        //        }
        //        passBox.ForeColor = Color.Black;
        //        panel5.Visible = false;
        //    }
        //    catch { }
        //}


        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "Enter username")
            //{
            //    panel3.Visible = true;
            //    textBox1.Focus();
            //    return;

            //    if (textBox2.Text == "********")
            //    {
            //        panel5.Visible = true;
            //        textBox2.Focus();
            //        return;
            //    }
            //}

                AdminDashboard ad = new AdminDashboard();
                ad.Show();
                this.Hide();
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            userBox.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            passBox.SelectAll();
        }

        private void pnlLogin_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void pnlLogin_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string username = userBox.Text;
            string password = passBox.Text;

            try
            {
                DatabaseConnection db = new DatabaseConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"Select Role FROM Users 
                                    WHERE Username = @userName AND Password = @password";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();

                        if (role == "Admin")
                        {
                            new AdminDashboard().Show();
                        }
                        else
                        {
                            //
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (passBox.PasswordChar == '*')
            {
                btnVisibility.Checked = true;
                passBox.PasswordChar = '\0';
            }
            else
            {
                btnVisibility.Checked = false;
                passBox.PasswordChar = '*';
                
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}