using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ride_Register.Forms
{
    public partial class MembersForm : Form
    {
        public MembersForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Enter username";
                    return;
                }
                textBox1.ForeColor = Color.Black;
                panel3.Visible = false;
            }
            catch { }  
        } 

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    textBox2.Text = "Password";
                    return;
                }
                textBox2.ForeColor = Color.Black;
                panel5.Visible = false;
            }
            catch { }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter username")
            {
                panel3.Visible = true;
                textBox1.Focus();
                return;

                if (textBox2.Text == "********")
                {
                    panel5.Visible = true;
                    textBox2.Focus();
                    return;
                }
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void pnlLogin_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Green;
        }

        private void pnlLogin_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
