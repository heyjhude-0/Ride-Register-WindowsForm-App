using Ride_Register.Data;
using Ride_Register.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ride_Register.Forms
{
    public partial class TricycleForm : Form
    {
        private int selectedTricycleID = -1;
        private DataTable _allTricycles;
        public TricycleForm()
        {
            InitializeComponent();
            LoadComboBoxes();
        }
        private void TricycleForm_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            LoadTricycles();
        }
        private int GetOwnerID()
        {
            int ownerID = Convert.ToInt32(cmbOwner.SelectedValue);
            return ownerID;
        }

        private int? GetDriverID()
        {
            if (cmbDriver.SelectedValue == DBNull.Value)
            {
                return null;
            }

            return Convert.ToInt32(cmbDriver.SelectedValue);
        }

        private int? GetRouteID()
        {
            if (cmbRoute.SelectedValue == DBNull.Value)
            {
                return null;
            }
            return Convert.ToInt32(cmbRoute.SelectedValue);
        }


        private void LoadComboBoxes()
        {
            MembersService service = new MembersService();

            DataTable owners = service.GetAllMembersForCmb();

            DataRow ownerRow = owners.NewRow();
            ownerRow["MemberID"] = DBNull.Value;
            ownerRow["FullName"] = "Select Owner";
            owners.Rows.InsertAt(ownerRow, 0);
            cmbOwner.DataSource = owners;
            cmbOwner.DisplayMember = "FullName";
            cmbOwner.ValueMember = "MemberID";

            DataTable drivers = service.GetDriversForCmb();

            DataRow driverRow = drivers.NewRow();
            driverRow["MemberID"] = DBNull.Value;
            driverRow["FullName"] = "No Driver";
            drivers.Rows.InsertAt(driverRow, 0);
            cmbDriver.DataSource = drivers;
            cmbDriver.DisplayMember = "FullName";
            cmbDriver.ValueMember = "MemberID";

            RouteService routeService = new RouteService();

            DataTable routes = routeService.GetRoutesforCmb();
            DataRow rowRoute = routes.NewRow();
            rowRoute["RouteID"] = DBNull.Value;
            rowRoute["RouteName"] = "No Route";
            routes.Rows.InsertAt(rowRoute, 0);
            cmbRoute.DataSource = routes;
            cmbRoute.DisplayMember = "RouteName";
            cmbRoute.ValueMember = "RouteID";

            PopulateFilterComboBoxes();
        }

        private void PopulateFilterComboBoxes()
        {
            MembersService service = new MembersService();
            RouteService routeService = new RouteService();

            DataTable owners = service.GetAllMembersForCmb();
            DataRow allOwnersRow = owners.NewRow();
            allOwnersRow["MemberID"] = DBNull.Value;
            allOwnersRow["FullName"] = "All Owners";
            owners.Rows.InsertAt(allOwnersRow, 0);
            cmbOwnerFilter.DataSource = owners;
            cmbOwnerFilter.DisplayMember = "FullName";
            cmbOwnerFilter.ValueMember = "MemberID";
            cmbOwnerFilter.SelectedIndex = 0;

            DataTable drivers = service.GetDriversForCmb();
            DataRow allDriversRow = drivers.NewRow();
            allDriversRow["MemberID"] = DBNull.Value;
            allDriversRow["FullName"] = "All Drivers";
            drivers.Rows.InsertAt(allDriversRow, 0);
            cmbDriverFilter.DataSource = drivers;
            cmbDriverFilter.DisplayMember = "FullName";
            cmbDriverFilter.ValueMember = "MemberID";
            cmbDriverFilter.SelectedIndex = 0;

            DataTable routes = routeService.GetRoutesforCmb();
            DataRow allRoutesRow = routes.NewRow();
            allRoutesRow["RouteID"] = DBNull.Value;
            allRoutesRow["RouteName"] = "All Routes";
            routes.Rows.InsertAt(allRoutesRow, 0);
            cmbRouteFilter.DataSource = routes;
            cmbRouteFilter.DisplayMember = "RouteName";
            cmbRouteFilter.ValueMember = "RouteID";
            cmbRouteFilter.SelectedIndex = 0;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {


            if ((string.IsNullOrWhiteSpace(txtPlate.Text)) || (string.IsNullOrWhiteSpace(txtModel.Text)) ||
                (cmbOwner.SelectedIndex == -1) || cmbOwner.SelectedIndex == 0)
            {
                MessageBox.Show("Plate number, Model, and Owner can't be empty.");
                return;
            }

            try
            {

                TricycleService service = new TricycleService();
                service.AddTricycle(txtPlate.Text, txtModel.Text, GetOwnerID(), GetDriverID(), GetRouteID());
                MessageBox.Show("Tricycle saved successfully.");
                LoadTricycles();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadTricycles()
        {
            TricycleService service = new TricycleService();
            _allTricycles = service.GetAllTricycles();

            dgvTricycles.DataSource = null;
            dgvTricycles.DataSource = _allTricycles;
            dgvTricycles.Columns["OwnerMemberID"].Visible = false;
            dgvTricycles.Columns["DriverMemberID"].Visible = false;
            dgvTricycles.Columns["RouteID"].Visible = false;


        }

        private void cmbOwner_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ApplyFilters()
        {
            if (_allTricycles == null)
                return;

            DataTable filteredTable = _allTricycles.Copy();

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                filteredTable.DefaultView.RowFilter = $"Plate_Number LIKE '%{txtSearch.Text}%'";
                filteredTable = filteredTable.DefaultView.ToTable();
            }

            if (cmbOwnerFilter.SelectedValue != null && cmbOwnerFilter.SelectedValue != DBNull.Value)
            {
                int ownerID = Convert.ToInt32(cmbOwnerFilter.SelectedValue);
                DataTable ownerFiltered = filteredTable.Copy();
                ownerFiltered.DefaultView.RowFilter = $"OwnerMemberID = {ownerID}";
                filteredTable = ownerFiltered.DefaultView.ToTable();
            }


            if (cmbDriverFilter.SelectedValue != null && cmbDriverFilter.SelectedValue != DBNull.Value)
            {
                int driverID = Convert.ToInt32(cmbDriverFilter.SelectedValue);
                DataTable driverFiltered = filteredTable.Copy();
                driverFiltered.DefaultView.RowFilter = $"DriverMemberID = {driverID}";
                filteredTable = driverFiltered.DefaultView.ToTable();
            }


            if (cmbRouteFilter.SelectedValue != null && cmbRouteFilter.SelectedValue != DBNull.Value)
            {
                int routeID = Convert.ToInt32(cmbRouteFilter.SelectedValue);
                DataTable routeFiltered = filteredTable.Copy();
                routeFiltered.DefaultView.RowFilter = $"RouteID = {routeID}";
                filteredTable = routeFiltered.DefaultView.ToTable();
            }

            dgvTricycles.DataSource = null;
            dgvTricycles.DataSource = filteredTable;
            dgvTricycles.Columns["OwnerMemberID"].Visible = false;
            dgvTricycles.Columns["DriverMemberID"].Visible = false;
            dgvTricycles.Columns["RouteID"].Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedTricycleID == -1)
            {
                MessageBox.Show("Select a tricycle first.");
                return;
            }

            TricycleService service = new TricycleService();

            service.UpdateTricycle(selectedTricycleID, txtPlate.Text, txtModel.Text, GetOwnerID(), GetDriverID(), GetRouteID());
            MessageBox.Show("Route updated successfully.");
            LoadTricycles();
            ClearFields();
        }
        private void ClearFields()
        {
            txtPlate.Clear();
            txtModel.Clear();
            cmbOwner.SelectedIndex = 0;
            cmbDriver.SelectedIndex = 0;
            cmbRoute.SelectedIndex = 0;

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
   

        private void dgvTricycles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTricycles_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTricycles.Rows[e.RowIndex];
                selectedTricycleID = Convert.ToInt32(row.Cells["TricycleID"].Value);

                txtPlate.Text = row.Cells["Plate_Number"].Value.ToString();
                txtModel.Text = row.Cells["Model"].Value.ToString();
                cmbOwner.SelectedValue = row.Cells["OwnerMemberID"].Value;
                cmbDriver.SelectedValue = row.Cells["DriverMemberID"].Value == DBNull.Value ? DBNull.Value : row.Cells["DriverMemberID"].Value;
                cmbRoute.SelectedValue = row.Cells["RouteID"].Value == DBNull.Value ? DBNull.Value : row.Cells["RouteID"].Value;


                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedTricycleID == -1)
            {
                MessageBox.Show("Select a tricycle record first.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to delete this tricycle record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                TricycleService service = new TricycleService();

                service.DeleteTricycles(selectedTricycleID);
                MessageBox.Show("Tricycle deleted successfuly!");
                LoadTricycles();
                ClearFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbOwnerFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbDriverFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbRouteFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }
}
