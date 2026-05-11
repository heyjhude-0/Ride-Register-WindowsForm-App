using Ride_Register.Services;
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
    public partial class UserDashboardForm : Form
    {
        private int loggedUserID;
        public UserDashboardForm(int userID)
        {
            InitializeComponent();
            loggedUserID = userID;
            LoadDashboardInfo();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void UserDashboardForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadDashboardInfo()
        {
            UserDashboardService service =
                new UserDashboardService();

            // Load user profile data
            DataTable table =
                service.GetUserDashboardData(
                    loggedUserID);

            if (table.Rows.Count > 0)
            {
                DataRow row =
                    table.Rows[0];

                lblGreeting.Text = row["FirstName"].ToString();
                lblMemberID.Text =
                    row["MemberID"]
                    .ToString();

                lblFullName.Text =
                    row["FirstName"] +
                    " " +
                    row["LastName"];

                lblDateOfBirth.Text =
                    Convert.ToDateTime(
                        row["DateOfBirth"])
                    .ToString("MMM dd, yyyy");

                lblPhone.Text =
                    row["PhoneNumber"]
                    .ToString();

                lblAddress.Text =
                    row["Address"]
                    .ToString();

                // MEMBERSHIP PANEL
                lblMembershipID.Text =
                    row["MembershipID"]
                    .ToString();

                lblMembershipRole.Text =
                    row["MembershipRole"]
                    .ToString();

                lblStartDate.Text =
                    Convert.ToDateTime(
                        row["StartDate"])
                    .ToString("MMM dd, yyyy");

                lblExpiryDate.Text =
                    Convert.ToDateTime(
                        row["ExpiryDate"])
                    .ToString("MMM dd, yyyy");

                lblStatus.Text =
                    row["MembershipStatus"]
                    .ToString();

                //// ACCOUNT PANEL
                //lblUserID.Text =
                //    row["UserID"]
                //    .ToString();

                //lblUsername.Text =
                //    row["Username"]
                //    .ToString();

                //lblAccountRole.Text =
                //    row["AccountRole"]
                //    .ToString();
            }

            // Load tricycle data
            DataTable tricycleTable =
                service.GetUserTricycleData(
                    loggedUserID);

            if (tricycleTable.Rows.Count > 0)
            {
                DataRow tricycleRow =
                    tricycleTable.Rows[0];

                lblTricycleID.Text =
                    tricycleRow["TricycleID"]
                    .ToString();

                lblPlateNum.Text =
                    tricycleRow["PlateNumber"]
                    .ToString();

                lblModel.Text =
                    tricycleRow["Model"]
                    .ToString();
            }
            else
            {
                lblTricycleID.Text = "N/A";
                lblPlateNum.Text = "N/A";
                lblModel.Text = "N/A";
            }

            // Load route data
            DataTable routeTable =
                service.GetUserRouteData(
                    loggedUserID);

            if (routeTable.Rows.Count > 0)
            {
                DataRow routeRow =
                    routeTable.Rows[0];

                lblRouteName.Text =
                    routeRow["RouteName"]
                    .ToString();

                lblStartPoint.Text =
                    routeRow["StartPoint"]
                    .ToString();

                lblEndPoint.Text =
                    routeRow["EndPoint"]
                    .ToString();

                lblFare.Text =
                    routeRow["Fare"]
                    .ToString();
            }
            else
            {
                lblRouteName.Text = "N/A";
                lblStartPoint.Text = "N/A";
                lblEndPoint.Text = "N/A";
                lblFare.Text = "N/A";
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
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
