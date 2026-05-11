using System;
using System.Windows.Forms;
using Ride_Register.Services;

namespace Ride_Register.Forms
{
    public partial class RenewalForm : Form
    {
        private int _membershipID;
        private DateTime _currentExpiryDate;

        public RenewalForm(int membershipID, DateTime currentExpiryDate)
        {
            InitializeComponent();
            _membershipID = membershipID;
            _currentExpiryDate = currentExpiryDate;
        }

        private void RenewalForm_Load(object sender, EventArgs e)
        {
            lblCurrentExpiryDate.Text = _currentExpiryDate.ToString("yyyy-MM-dd");
            numDuration.Value = 6;
            CalculateNewExpiryDate();
        }

        private void numDuration_ValueChanged(object sender, EventArgs e)
        {
            CalculateNewExpiryDate();
        }

        private void CalculateNewExpiryDate()
        {
            int months = (int)numDuration.Value;
            DateTime newExpiryDate = _currentExpiryDate.AddMonths(months);
            lblNewExpiryDate.Text = newExpiryDate.ToString("yyyy-MM-dd");
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            try
            {
                int months = (int)numDuration.Value;
                DateTime newExpiryDate = _currentExpiryDate.AddMonths(months);

                MembersService service = new MembersService();
                service.RenewMembership(_membershipID, newExpiryDate);

                MessageBox.Show("Membership renewed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error renewing membership: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
