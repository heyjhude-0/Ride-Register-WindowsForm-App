using Ride_Register.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ride_Register.Forms
{
    public partial class AccountForm : Form
    {
        private int _memberID;
        private string _firstName;
        private string _lastName;
        public AccountForm(int memberID, string firstName, string lastName)
        {
            InitializeComponent();
            _memberID = memberID;
            _firstName = firstName;
            _lastName = lastName;
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            txtUsername.Text = GenerateUsername();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void userBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text != txtConPassword.Text)
            {
                MessageBox.Show("Password don't match.");
                return;
            }

            else if (cmbAccRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an account type.");
            }

            else
            {
                DatabaseConnection db = new DatabaseConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO Users (Username, Password, Role, MemberID) 
                                 VALUES (@username, @password, @role, @memberID)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@memberID", _memberID);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@role", cmbAccRole.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account created!");
                    this.Close();
                    
                }
            }
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAccRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a member role.");
            }
        }

        private void txtConPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private string GenerateUsername()
        {
            return _firstName.ToLower() + _lastName.ToLower() + _memberID;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (txtConPassword.PasswordChar == '*')
            {
                btnVisibility2.Checked = true;
                txtConPassword.PasswordChar = '\0';
            }
            else
            {
                btnVisibility2.Checked = false;
                txtConPassword.PasswordChar = '*';

            }
        }

        private void btnVisibility1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnVisibility1.Checked = true;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                btnVisibility1.Checked = false;
                txtPassword.PasswordChar = '*';
                
            }
        }
    }
}
