using Ride_Register.Data;
using Ride_Register.Services;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ride_Register.Forms
{
    public partial class MembersForm : Form
    {
        private DataTable _allMembers;
        private int selectedMemberID = -1;
        private int selectedMembershipID = -1;

        public MembersForm()
        {
            InitializeComponent();
        }

        private void MembersForm_Load(object sender, EventArgs e)
        {
            this.membersTableAdapter.Fill(this.rideRegister_DBDataSet1.Members);
            this.usersTableAdapter.Fill(this.rideRegister_DBDataSet.Users);

            LoadMembers();
            InitializeFilterComboBox();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if ((string.IsNullOrWhiteSpace(txtFname.Text)) || (string.IsNullOrWhiteSpace(txtLname.Text)) ||
                (!dTBirthday.Checked) || (string.IsNullOrWhiteSpace(txtAddress.Text)))
            {
                MessageBox.Show("Please fill in all required personal information");
                return;
            }

            if ((!dateStartDate.Checked) || (!dateEndDate.Checked) || (cmbRole.SelectedIndex == -1))
            {
                MessageBox.Show("Please fill in all required membership information");
                return;
            }


            try
            {
                MembersService service = new MembersService();
                int memberID = service.AddMembers(txtFname.Text, txtLname.Text, dTBirthday.Value, txtPNumber.Text, txtAddress.Text, cmbRole.Text, dateStartDate.Value,dateEndDate.Value);
                LoadMembers();


                DialogResult result = MessageBox.Show("Member saved successfully! \n\nDo you want to create an account for this member?", "Create Account", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    AccountForm acc = new AccountForm(memberID, txtFname.Text, txtLname.Text);
                    acc.ShowDialog();
                    LoadMembers();
                }

                ClearFields();

            }



            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadMembers()
        {
            MembersService service = new MembersService();
            _allMembers = service.GetAllMembers();

            dgvMembers.DataSource = null;
            dgvMembers.DataSource = _allMembers;
            dgvMembers.Columns["MembershipID"].Visible = false;
            dgvMembers.Columns["StartDate"].Visible = false;

            if (dgvMembers.Columns.Contains("AccountStatus"))
            {
                dgvMembers.Columns["AccountStatus"].Visible = true;
            }
        }

        private void InitializeFilterComboBox()
        {
            if (cmbFilter.Items.Count == 0)
            {
                cmbFilter.Items.Add("All");
                cmbFilter.Items.Add("FirstName");
                cmbFilter.Items.Add("LastName");
                cmbFilter.SelectedIndex = 0;
            }

            if (cmbRoleFilter.Items.Count == 0)
            {
                cmbRoleFilter.Items.Add("All");
                cmbRoleFilter.Items.Add("Operator");
                cmbRoleFilter.Items.Add("Driver");
                cmbRoleFilter.Items.Add("Driver/Operator");
                cmbRoleFilter.SelectedIndex = 0;
            }

            if (cmbStatusFilter.Items.Count == 0)
            {
                cmbStatusFilter.Items.Add("All");
                cmbStatusFilter.Items.Add("Active");
                cmbStatusFilter.Items.Add("Expired");
                cmbStatusFilter.SelectedIndex = 0;
            }
        }

        private void ApplyFilter()
        {
            if (_allMembers == null)
                return;

            string filterText = txtSearch.Text.Trim();
            string filterColumn = cmbFilter.SelectedItem?.ToString() ?? "All";
            string roleFilter = cmbRoleFilter?.SelectedItem?.ToString();
            string statusFilter = cmbStatusFilter?.SelectedItem?.ToString();
            string accountFilter = cmbAccountFilter?.SelectedItem?.ToString();

            string filterExpression = string.Empty;

            if (!string.IsNullOrWhiteSpace(filterText) && filterColumn != "All")
            {
                try
                {
                    if (filterColumn == "FirstName")
                    {
                        filterExpression = $"FirstName LIKE '%{filterText}%'";
                    }
                    else if (filterColumn == "LastName")
                    {
                        filterExpression = $"LastName LIKE '%{filterText}%'";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in search filter: {ex.Message}");
                    filterExpression = string.Empty;
                }
            }

            if (!string.IsNullOrWhiteSpace(roleFilter) && roleFilter != "All")
            {
                string roleCondition = $"Role = '{roleFilter}'";
                filterExpression = string.IsNullOrEmpty(filterExpression)
                    ? roleCondition
                    : $"{filterExpression} AND {roleCondition}";
            }

            if (!string.IsNullOrWhiteSpace(statusFilter) && statusFilter != "All")
            {
                string statusCondition = $"Status = '{statusFilter}'";
                filterExpression = string.IsNullOrEmpty(filterExpression)
                    ? statusCondition
                    : $"{filterExpression} AND {statusCondition}";
            }

            if (!string.IsNullOrWhiteSpace(accountFilter) && accountFilter != "All")
            {
                string accountCondition = $"AccountStatus = '{accountFilter}'";
                filterExpression = string.IsNullOrEmpty(filterExpression)
                    ? accountCondition
                    : $"{filterExpression} AND {accountCondition}";
            }

            try
            {
                _allMembers.DefaultView.RowFilter = filterExpression;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying filter: {ex.Message}");
                _allMembers.DefaultView.RowFilter = string.Empty;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

         private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cmbRoleFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cmbAccountFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }


        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMembers.Rows[e.RowIndex];
                selectedMemberID = Convert.ToInt32(row.Cells["MemberId"].Value);
                selectedMembershipID = Convert.ToInt32(row.Cells["MembershipID"].Value);


                txtFname.Text = row.Cells["FirstName"].Value.ToString();
                txtLname.Text = row.Cells["LastName"].Value.ToString();
                dTBirthday.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                txtPNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                cmbRole.Text = row.Cells["Role"].Value.ToString();
                dateStartDate.Value = Convert.ToDateTime(row.Cells["StartDate"].Value);
                dateEndDate.Value = Convert.ToDateTime(row.Cells["ExpiryDate"].Value);

                string accountStatus = row.Cells["AccountStatus"].Value.ToString();
                btnCreateAccount.Enabled = (accountStatus == "No Account");

                btnSave.Enabled = false;
                btnRenew.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                dateStartDate.Enabled = false;
                dateEndDate.Enabled = false;
            }


        }

        private void ResetForm()
        {


            txtFname.Clear();
            txtLname.Clear();
            txtPNumber.Clear();
            txtAddress.Clear();

            cmbRole.SelectedIndex = -1;


            selectedMemberID = -1;
            selectedMembershipID = -1;


            dgvMembers.ClearSelection();

            btnSave.Enabled = true;
            btnSave.Text = "SAVE";
            btnCreateAccount.Enabled = false;
        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

  
        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void tableLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dTBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlParentCon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void filterTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClearFields()
        {
            txtFname.Clear();
            txtLname.Clear();
            txtPNumber.Clear();
            txtAddress.Clear();
            cmbRole.SelectedIndex = -1;
            dateStartDate.Value = DateTime.Today;
            dateEndDate.Value = DateTime.Today;

            selectedMemberID = -1;
            btnCreateAccount.Enabled = false;
            dateStartDate.Enabled = true;
            dateEndDate.Enabled = true;
            btnRenew.Enabled = false;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (selectedMemberID == -1)
            {
                MessageBox.Show("Select a member first.");
                return;
            }

            MembersService service = new MembersService();

            service.UpdateMembers(selectedMemberID, selectedMembershipID, txtFname.Text, txtLname.Text, dTBirthday.Value, txtPNumber.Text, txtAddress.Text, cmbRole.Text);
            MessageBox.Show("Update successfully!");

            LoadMembers();
            ClearFields();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void membersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void rideRegisterDBDataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void usersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void rideRegisterDBDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void usersBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void membersBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            ClearFields();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMemberID == -1)
            {
                MessageBox.Show("Select a member first.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to delete this member?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MembersService service = new MembersService();
                
                service.DeleteMembers(selectedMemberID);
                MessageBox.Show("Member deleted successfuly!");
                LoadMembers();
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            
            
            
            if (selectedMemberID == -1)
            {
                MessageBox.Show("Select a member first.");
                return;

            }

            if (dgvMembers.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Create account for this member?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvMembers.SelectedRows[0];
                    string accountStatus = row.Cells["AccountStatus"].Value.ToString();

                    if (accountStatus == "Has Account")
                    {
                        MessageBox.Show("This member already has an account!");
                        return;
                    }

                    string firstName = row.Cells["FirstName"].Value.ToString();
                    string lastName = row.Cells["LastName"].Value.ToString();

                    AccountForm accForm = new AccountForm(selectedMemberID, firstName, lastName);
                    accForm.ShowDialog();
                    LoadMembers();
                }
                else
                {
                    return;
                }


            }
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (selectedMembershipID == -1)
            {
                MessageBox.Show("Select a member to renew their membership.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DateTime currentExpiryDate = dateEndDate.Value;

            RenewalForm renewalForm = new RenewalForm(selectedMembershipID, currentExpiryDate);
            DialogResult result = renewalForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadMembers();
                ClearFields();
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
