using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ride_Register.Services;
using Guna.UI2.WinForms;

namespace Ride_Register.Forms
{
    
    public partial class RouteForm : Form
    {
    private int selectedRouteID = -1;
        public RouteForm()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtRouteName.Text)) || (string.IsNullOrWhiteSpace(txtStartP.Text)) || (string.IsNullOrWhiteSpace(txtEndP.Text)))
            {
                MessageBox.Show("Please fill in all required route information");
                return;
            }
            if (numFare.Value <= 0)
            {
                MessageBox.Show("Fare must be greater than 0.");
                return;
            }

            try
            {
                RouteService service = new RouteService();

                service.AddRoute(txtRouteName.Text, txtStartP.Text, txtEndP.Text, numFare.Value);
                MessageBox.Show("Route successfully saved.");
                LoadRoutes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddRouteCard(
            int routeID,
            string routeName,
            string startPoint,
            string endPoint,
            decimal fare, int tricycleCount)
        {
            Guna2Panel card = new Guna2Panel();

            Color panelColor = Color.FromArgb(64, 24, 157);
            Color fontColor = Color.White;

            card.Width = 250;
            card.Height = 160;
            card.FillColor = panelColor;
            card.BorderRadius = 10;
            card.Margin = new Padding(10);
            card.Cursor = Cursors.Hand;

            Label lblRouteName = new Label();
            lblRouteName.Text = routeName;
            lblRouteName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblRouteName.Location = new Point(10, 10);
            lblRouteName.AutoSize = true;
            lblRouteName.ForeColor = fontColor;
            lblRouteName.BackColor = panelColor;

            Label lblStart = new Label();
            lblStart.Text = "•Start: " + startPoint;
            lblStart.Location = new Point(20, 45);
            lblStart.AutoSize = true;
            lblStart.ForeColor = fontColor;
            lblStart.BackColor = panelColor;
            Label lblEnd = new Label();
            lblEnd.Text = "•End: " + endPoint;
            lblEnd.Location = new Point(20, 70);
            lblEnd.AutoSize = true;
            lblEnd.ForeColor = fontColor;
            lblEnd.BackColor = panelColor;

            Label lblFare = new Label();
            lblFare.Text = "•Fare: ₱" + fare.ToString("0.00");
            lblFare.Location = new Point(20, 95);
            lblFare.AutoSize = true;
            lblFare.ForeColor = fontColor;
            lblFare.BackColor = panelColor;

            Label lblTricycleCount = new Label();
            lblTricycleCount.Text = "•Units Assigned:" + tricycleCount;
            lblTricycleCount.Location = new Point(20, 120);
            lblTricycleCount.AutoSize = true;
            lblTricycleCount.ForeColor = fontColor;
            lblTricycleCount.BackColor = panelColor;

            card.Controls.Add(lblRouteName);
            card.Controls.Add(lblStart);
            card.Controls.Add(lblEnd);
            card.Controls.Add(lblFare);
            card.Controls.Add(lblTricycleCount);


            card.Click += (s, e) =>
            {
                txtRouteName.Text = routeName;
                txtStartP.Text = startPoint;
                txtEndP.Text = endPoint;

                numFare.Value = fare;

                selectedRouteID = routeID;

                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            };

            flowRoutes.Controls.Add(card);
        }
        private void LoadRoutes()
        {
            flowRoutes.Controls.Clear();

            RouteService service =
                new RouteService();

            DataTable table =
                service.GetRoutes();

            foreach (DataRow row in table.Rows)
            {
                AddRouteCard(
                    Convert.ToInt32(row["RouteID"]),
                    row["RouteName"].ToString(),
                    row["StartPoint"].ToString(),
                    row["EndPoint"].ToString(),
                    Convert.ToDecimal(row["Fare"]),
                    Convert.ToInt32(row["TricycleCount"])
                );
            }
        }

        private void RouteForm_Load(object sender, EventArgs e)
        {
            LoadRoutes();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void ClearFields()
        {
            txtRouteName.Clear();
            txtStartP.Clear();
            txtEndP.Clear();

            numFare.Value = 0;

            selectedRouteID = -1;

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (selectedRouteID == -1)
            {
                MessageBox.Show("Select route first.");
                return;
            }

            RouteService service = new RouteService();

            service.UpdateRoute(selectedRouteID, txtRouteName.Text, txtStartP.Text, txtEndP.Text, numFare.Value);
            MessageBox.Show("Route updated successfully.");
            LoadRoutes();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRouteID == -1)
            {
                MessageBox.Show("Select a route first.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to delete this route? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                RouteService service = new RouteService();
                service.DeleteRoute(selectedRouteID);
                MessageBox.Show("Route deleted successfully.");
                LoadRoutes();
                ClearFields();
            }
        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
