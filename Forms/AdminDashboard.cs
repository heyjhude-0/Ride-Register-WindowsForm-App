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

        AdminDashboardForm adminDashboard = new AdminDashboardForm();
        MembersForm members = new MembersForm();
        TricycleForm tricycle = new TricycleForm();
        RouteForm route = new RouteForm();

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            OpenChildForm(adminDashboard);

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

 

        Form activeForm = null;

        //private void OpenChildForm(Form childForm)
        //{
        //    if (activeForm != null)
        //        activeForm.Close();
        //    activeForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;

        //    pnlChildForm.Controls.Clear();
        //    pnlChildForm.Controls.Add(childForm);
        //    childForm.Show();
        //}


        private void OpenChildForm(Form childForm)
        {
            foreach (Control ctrl in pnlChildForm.Controls)
                ctrl.Visible = false;

            if (!pnlChildForm.Controls.Contains(childForm))
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlChildForm.Controls.Add(childForm);
                childForm.Show();
            }
            else
            {
                childForm.Visible = true;
                childForm.BringToFront();
            }

            activeForm = childForm;
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            //btnMembers.FillColor = Color.WhiteSmoke;
            //btnMembers.ForeColor = Color.Blue;
            OpenChildForm(members);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(adminDashboard);
            adminDashboard.RefreshDashboard();
        }

        private void btnTricycles_Click(object sender, EventArgs e)
        {
            OpenChildForm(tricycle);
        }
        private void btnRoutes_Click(object sender, EventArgs e)
        {
            OpenChildForm(route);
        }

        private void pnlChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result =
            MessageBox.Show(
            "Are you sure you want to sign out?",
            "Sign Out",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
