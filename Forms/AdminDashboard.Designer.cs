namespace Ride_Register.Forms
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.pnlSideBar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.SideMenuLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnTricycles = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoutes = new Guna.UI2.WinForms.Guna2Button();
            this.btnMembers = new Guna.UI2.WinForms.Guna2Button();
            this.pnlChildForm = new Guna.UI2.WinForms.Guna2Panel();
            this.lblGreeting2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblGreeting1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblToda = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlSideBar.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SideMenuLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.White;
            this.pnlSideBar.BorderRadius = 20;
            this.pnlSideBar.Controls.Add(this.guna2GradientPanel1);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(24)))), ((int)(((byte)(157)))));
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(220, 936);
            this.pnlSideBar.TabIndex = 0;
            this.pnlSideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.SideMenu_Paint);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.SideMenuLogo);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GradientPanel1.Controls.Add(this.btnDashboard);
            this.guna2GradientPanel1.Controls.Add(this.btnTricycles);
            this.guna2GradientPanel1.Controls.Add(this.btnRoutes);
            this.guna2GradientPanel1.Controls.Add(this.btnMembers);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(24)))), ((int)(((byte)(157)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(72)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(220, 936);
            this.guna2GradientPanel1.TabIndex = 0;
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // SideMenuLogo
            // 
            this.SideMenuLogo.BackColor = System.Drawing.Color.Transparent;
            this.SideMenuLogo.Image = ((System.Drawing.Image)(resources.GetObject("SideMenuLogo.Image")));
            this.SideMenuLogo.ImageRotate = 0F;
            this.SideMenuLogo.Location = new System.Drawing.Point(81, 3);
            this.SideMenuLogo.Name = "SideMenuLogo";
            this.SideMenuLogo.Size = new System.Drawing.Size(58, 96);
            this.SideMenuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SideMenuLogo.TabIndex = 1;
            this.SideMenuLogo.TabStop = false;
            this.SideMenuLogo.UseTransparentBackground = true;
            this.SideMenuLogo.Click += new System.EventHandler(this.SideMenuLogo_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(43, 79);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(136, 30);
            this.guna2HtmlLabel1.TabIndex = 11;
            this.guna2HtmlLabel1.Text = "Ride&Register";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.Checked = true;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashboard.CheckedState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(24)))), ((int)(((byte)(157)))));
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(74)))), ((int)(((byte)(241)))));
            this.btnDashboard.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.Location = new System.Drawing.Point(0, 201);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(220, 66);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextOffset = new System.Drawing.Point(10, 0);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnTricycles
            // 
            this.btnTricycles.BackColor = System.Drawing.Color.Transparent;
            this.btnTricycles.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTricycles.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnTricycles.CheckedState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTricycles.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(24)))), ((int)(((byte)(157)))));
            this.btnTricycles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTricycles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTricycles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTricycles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTricycles.FillColor = System.Drawing.Color.Transparent;
            this.btnTricycles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTricycles.ForeColor = System.Drawing.Color.White;
            this.btnTricycles.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(74)))), ((int)(((byte)(241)))));
            this.btnTricycles.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTricycles.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnTricycles.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnTricycles.Image = ((System.Drawing.Image)(resources.GetObject("btnTricycles.Image")));
            this.btnTricycles.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTricycles.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnTricycles.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTricycles.Location = new System.Drawing.Point(0, 345);
            this.btnTricycles.Name = "btnTricycles";
            this.btnTricycles.Size = new System.Drawing.Size(220, 66);
            this.btnTricycles.TabIndex = 3;
            this.btnTricycles.Text = "Tricycles";
            this.btnTricycles.TextOffset = new System.Drawing.Point(10, 0);
            this.btnTricycles.Click += new System.EventHandler(this.btnTricycles_Click);
            // 
            // btnRoutes
            // 
            this.btnRoutes.BackColor = System.Drawing.Color.Transparent;
            this.btnRoutes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRoutes.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnRoutes.CheckedState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRoutes.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(24)))), ((int)(((byte)(157)))));
            this.btnRoutes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoutes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoutes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoutes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoutes.FillColor = System.Drawing.Color.Transparent;
            this.btnRoutes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRoutes.ForeColor = System.Drawing.Color.White;
            this.btnRoutes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(74)))), ((int)(((byte)(241)))));
            this.btnRoutes.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoutes.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRoutes.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnRoutes.Image = ((System.Drawing.Image)(resources.GetObject("btnRoutes.Image")));
            this.btnRoutes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRoutes.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnRoutes.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRoutes.Location = new System.Drawing.Point(-3, 417);
            this.btnRoutes.Name = "btnRoutes";
            this.btnRoutes.Size = new System.Drawing.Size(223, 66);
            this.btnRoutes.TabIndex = 4;
            this.btnRoutes.Text = "Routes";
            this.btnRoutes.TextOffset = new System.Drawing.Point(10, 0);
            this.btnRoutes.Click += new System.EventHandler(this.btnRoutes_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.BackColor = System.Drawing.Color.Transparent;
            this.btnMembers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMembers.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnMembers.CheckedState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMembers.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(24)))), ((int)(((byte)(157)))));
            this.btnMembers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMembers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMembers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMembers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMembers.FillColor = System.Drawing.Color.Transparent;
            this.btnMembers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMembers.ForeColor = System.Drawing.Color.White;
            this.btnMembers.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(74)))), ((int)(((byte)(241)))));
            this.btnMembers.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnMembers.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnMembers.Image")));
            this.btnMembers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMembers.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnMembers.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMembers.Location = new System.Drawing.Point(0, 273);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(220, 66);
            this.btnMembers.TabIndex = 2;
            this.btnMembers.Text = "Members";
            this.btnMembers.TextOffset = new System.Drawing.Point(10, 0);
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.Transparent;
            this.pnlChildForm.BorderRadius = 20;
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnlChildForm.Location = new System.Drawing.Point(220, 0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1158, 936);
            this.pnlChildForm.TabIndex = 11;
            this.pnlChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChildForm_Paint);
            // 
            // lblGreeting2
            // 
            this.lblGreeting2.BackColor = System.Drawing.Color.Transparent;
            this.lblGreeting2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(35)))), ((int)(((byte)(125)))));
            this.lblGreeting2.Location = new System.Drawing.Point(183, 61);
            this.lblGreeting2.Name = "lblGreeting2";
            this.lblGreeting2.Size = new System.Drawing.Size(274, 50);
            this.lblGreeting2.TabIndex = 2;
            this.lblGreeting2.Text = "Welcome Back!";
            this.lblGreeting2.Click += new System.EventHandler(this.lblGreeting2_Click);
            // 
            // lblGreeting1
            // 
            this.lblGreeting1.BackColor = System.Drawing.Color.Transparent;
            this.lblGreeting1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(35)))), ((int)(((byte)(125)))));
            this.lblGreeting1.Location = new System.Drawing.Point(183, 35);
            this.lblGreeting1.Name = "lblGreeting1";
            this.lblGreeting1.Size = new System.Drawing.Size(117, 34);
            this.lblGreeting1.TabIndex = 1;
            this.lblGreeting1.Text = "Hi, Admin,";
            this.lblGreeting1.Click += new System.EventHandler(this.lblGreeting1_Click);
            // 
            // lblToda
            // 
            this.lblToda.BackColor = System.Drawing.Color.Transparent;
            this.lblToda.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(35)))), ((int)(((byte)(125)))));
            this.lblToda.Location = new System.Drawing.Point(63, 134);
            this.lblToda.Name = "lblToda";
            this.lblToda.Size = new System.Drawing.Size(242, 47);
            this.lblToda.TabIndex = 7;
            this.lblToda.Text = "TODA Overview";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1378, 936);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1167, 992);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SideMenuLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlSideBar;
        private Guna.UI2.WinForms.Guna2PictureBox SideMenuLogo;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnRoutes;
        private Guna.UI2.WinForms.Guna2Button btnTricycles;
        private Guna.UI2.WinForms.Guna2Button btnMembers;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel pnlChildForm;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGreeting2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGreeting1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblToda;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}