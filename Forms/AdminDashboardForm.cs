using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ride_Register.Services;

namespace Ride_Register.Forms
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            LoadExpiringMemberships();
        }

        private void lblGreeting1_Click(object sender, EventArgs e)
        {

        }

        private void lblGreeting2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void lblToda_Click(object sender, EventArgs e)
        {

        }

        private void pnlTtlMem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadDashboard()
        {
            AdminDashboardService service =
                new AdminDashboardService();

            DataTable table =
                service.GetDashboardStats();

            if (table.Rows.Count > 0)
            {
                DataRow row =
                    table.Rows[0];

                lblTotalMembers.Text = row["TotalMembers"].ToString();

                lblActive.Text = row["ActiveMembers"].ToString();
                lblTotalTric.Text = row["TotalTricycles"].ToString();

                lblWithDriver.Text = row["WithDriver"].ToString();

                lblWithoutDriver.Text =row["WithoutDriver"].ToString();

                lblTotalRoute.Text = row["TotalRoutes"].ToString();

                lblWithRoute.Text = row["WithRoute"].ToString();
                lblWithoutRoute.Text = row["WithoutRoute"].ToString();
                lblDriver.Text = row["MemberDriver"].ToString();
                lblOperator.Text = row["MemberOperator"].ToString();
                lblDriverOperator.Text = row["MemberDriverOperator"].ToString();
                lblExpiring.Text = row["ExpiringMemberships"].ToString();

            }
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel14_Click(object sender, EventArgs e)
        {

        }

        private void dgvExpiringMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadExpiringMemberships()
        {
            AdminDashboardService service =
                new AdminDashboardService();

            dgvExpiringMemberships.DataSource =
                service.GetExpiringMemberships();
            dgvExpiringMemberships.Columns["MemberID"].HeaderText = "ID";

            dgvExpiringMemberships.Columns["FullName"].HeaderText = "Member Name";

            dgvExpiringMemberships.Columns["Role"].HeaderText = "Role";

            dgvExpiringMemberships.Columns["ExpiryDate"].HeaderText = "Expiry";
            dgvExpiringMemberships.Columns["DaysRemaining"].HeaderText ="Days Left";
            dgvExpiringMemberships.Columns["ExpiryDate"].DefaultCellStyle.Format ="MMM dd, yyyy";
        }

        private void AdminDashboardForm_Activated(object sender, EventArgs e)
        {
            RefreshDashboard();
        }
        public void RefreshDashboard()
        {
            LoadDashboard();
            LoadExpiringMemberships();
        }
    }
}
