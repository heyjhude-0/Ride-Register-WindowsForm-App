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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            OpenChildForm(new AdminDashboardForm());
        }

        private void SideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SideMenuLogo_Click(object sender, EventArgs e)
        {

        }

        private void lblGreeting2_Click(object sender, EventArgs e)
        {

        }

        private void lblGreeting1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlGreeting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picTric_Click(object sender, EventArgs e)
        {

        }

        private void pnlTtlMem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnRoutes_Click(object sender, EventArgs e)
        {

        }

        Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlChildForm.Controls.Clear();
            pnlChildForm.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            //btnMembers.FillColor = Color.WhiteSmoke;
            //btnMembers.ForeColor = Color.Blue;
            OpenChildForm(new MembersForm());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminDashboardForm());
        }
    }
}
