namespace Ride_Register.Forms
{
    partial class RenewalForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenewalForm));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurrentExpiryLabel = new System.Windows.Forms.Label();
            this.lblCurrentExpiryDate = new System.Windows.Forms.Label();
            this.lblDurationLabel = new System.Windows.Forms.Label();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblNewExpiryLabel = new System.Windows.Forms.Label();
            this.lblNewExpiryDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.SideMenuLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SideMenuLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tableLayoutPanel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.pnlMain.Size = new System.Drawing.Size(750, 462);
            this.pnlMain.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.guna2GradientPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 31);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(690, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(51, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Renew Membership";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.lblCurrentExpiryLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCurrentExpiryDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDurationLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.numDuration, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblYears, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblNewExpiryLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblNewExpiryDate, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 67);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(682, 236);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblCurrentExpiryLabel
            // 
            this.lblCurrentExpiryLabel.AutoSize = true;
            this.lblCurrentExpiryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentExpiryLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCurrentExpiryLabel.Location = new System.Drawing.Point(4, 0);
            this.lblCurrentExpiryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentExpiryLabel.Name = "lblCurrentExpiryLabel";
            this.lblCurrentExpiryLabel.Size = new System.Drawing.Size(264, 70);
            this.lblCurrentExpiryLabel.TabIndex = 0;
            this.lblCurrentExpiryLabel.Text = "Current Expiry Date:";
            this.lblCurrentExpiryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentExpiryDate
            // 
            this.lblCurrentExpiryDate.AutoSize = true;
            this.lblCurrentExpiryDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentExpiryDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCurrentExpiryDate.Location = new System.Drawing.Point(276, 0);
            this.lblCurrentExpiryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentExpiryDate.Name = "lblCurrentExpiryDate";
            this.lblCurrentExpiryDate.Size = new System.Drawing.Size(402, 70);
            this.lblCurrentExpiryDate.TabIndex = 1;
            this.lblCurrentExpiryDate.Text = "2024-12-31";
            this.lblCurrentExpiryDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDurationLabel
            // 
            this.lblDurationLabel.AutoSize = true;
            this.lblDurationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDurationLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDurationLabel.Location = new System.Drawing.Point(4, 70);
            this.lblDurationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurationLabel.Name = "lblDurationLabel";
            this.lblDurationLabel.Size = new System.Drawing.Size(264, 70);
            this.lblDurationLabel.TabIndex = 2;
            this.lblDurationLabel.Text = "Renewal Duration:";
            this.lblDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numDuration
            // 
            this.numDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numDuration.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numDuration.Increment = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numDuration.Location = new System.Drawing.Point(4, 145);
            this.numDuration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(264, 34);
            this.numDuration.TabIndex = 3;
            this.numDuration.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numDuration.ValueChanged += new System.EventHandler(this.numDuration_ValueChanged);
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYears.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblYears.Location = new System.Drawing.Point(276, 70);
            this.lblYears.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYears.Name = "lblYears";
            this.lblYears.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblYears.Size = new System.Drawing.Size(402, 70);
            this.lblYears.TabIndex = 4;
            this.lblYears.Text = "year(s)";
            this.lblYears.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNewExpiryLabel
            // 
            this.lblNewExpiryLabel.AutoSize = true;
            this.lblNewExpiryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewExpiryLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNewExpiryLabel.Location = new System.Drawing.Point(276, 140);
            this.lblNewExpiryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewExpiryLabel.Name = "lblNewExpiryLabel";
            this.lblNewExpiryLabel.Size = new System.Drawing.Size(402, 70);
            this.lblNewExpiryLabel.TabIndex = 5;
            this.lblNewExpiryLabel.Text = "New Expiry Date:";
            this.lblNewExpiryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNewExpiryDate
            // 
            this.lblNewExpiryDate.AutoSize = true;
            this.lblNewExpiryDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewExpiryDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNewExpiryDate.ForeColor = System.Drawing.Color.Green;
            this.lblNewExpiryDate.Location = new System.Drawing.Point(4, 210);
            this.lblNewExpiryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewExpiryDate.Name = "lblNewExpiryDate";
            this.lblNewExpiryDate.Size = new System.Drawing.Size(264, 26);
            this.lblNewExpiryDate.TabIndex = 6;
            this.lblNewExpiryDate.Text = "2025-12-31";
            this.lblNewExpiryDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnRenew, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 313);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(682, 82);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnRenew
            // 
            this.btnRenew.BackColor = System.Drawing.Color.Green;
            this.btnRenew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRenew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRenew.ForeColor = System.Drawing.Color.White;
            this.btnRenew.Location = new System.Drawing.Point(4, 5);
            this.btnRenew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(333, 72);
            this.btnRenew.TabIndex = 0;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = false;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(345, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(333, 72);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 8;
            this.guna2GradientPanel1.Controls.Add(this.SideMenuLogo);
            this.guna2GradientPanel1.Controls.Add(this.lblTitle);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(24)))), ((int)(((byte)(157)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(72)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(684, 56);
            this.guna2GradientPanel1.TabIndex = 3;
            // 
            // SideMenuLogo
            // 
            this.SideMenuLogo.BackColor = System.Drawing.Color.Transparent;
            this.SideMenuLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuLogo.Image = ((System.Drawing.Image)(resources.GetObject("SideMenuLogo.Image")));
            this.SideMenuLogo.ImageRotate = 0F;
            this.SideMenuLogo.Location = new System.Drawing.Point(0, 0);
            this.SideMenuLogo.Name = "SideMenuLogo";
            this.SideMenuLogo.Size = new System.Drawing.Size(62, 56);
            this.SideMenuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SideMenuLogo.TabIndex = 2;
            this.SideMenuLogo.TabStop = false;
            this.SideMenuLogo.UseTransparentBackground = true;
            // 
            // RenewalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 462);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RenewalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Renew Membership";
            this.Load += new System.EventHandler(this.RenewalForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SideMenuLogo)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblCurrentExpiryLabel;
        private System.Windows.Forms.Label lblCurrentExpiryDate;
        private System.Windows.Forms.Label lblDurationLabel;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblNewExpiryLabel;
        private System.Windows.Forms.Label lblNewExpiryDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btnCancel;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox SideMenuLogo;
    }
}
