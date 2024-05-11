namespace University_Management_System
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.Navber = new System.Windows.Forms.FlowLayoutPanel();
            this.sideber_btn = new System.Windows.Forms.Button();
            this.FASS_Panel_up = new System.Windows.Forms.Panel();
            this.FST_Panel_up = new System.Windows.Forms.Panel();
            this.FBA_Panel_up = new System.Windows.Forms.Panel();
            this.FE_Panel_up = new System.Windows.Forms.Panel();
            this.FASS_panel = new System.Windows.Forms.Panel();
            this.FASS_btn_pgrm = new System.Windows.Forms.Button();
            this.FASS_btn_dept = new System.Windows.Forms.Button();
            this.FBA_panel = new System.Windows.Forms.Panel();
            this.FBA_btn_pgrm = new System.Windows.Forms.Button();
            this.FBA_btn_dept = new System.Windows.Forms.Button();
            this.Fe_Panel = new System.Windows.Forms.Panel();
            this.FE_btn_pgrm = new System.Windows.Forms.Button();
            this.FE_btn_dept = new System.Windows.Forms.Button();
            this.FST_Panel = new System.Windows.Forms.Panel();
            this.FST_btn_pgrm = new System.Windows.Forms.Button();
            this.FST_btn_dept = new System.Windows.Forms.Button();
            this.Notification_btn = new System.Windows.Forms.Button();
            this.AddUser_btn = new System.Windows.Forms.Button();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Profile_btn = new System.Windows.Forms.Button();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Minimize_btn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Sidebar.SuspendLayout();
            this.Navber.SuspendLayout();
            this.FASS_panel.SuspendLayout();
            this.FBA_panel.SuspendLayout();
            this.Fe_Panel.SuspendLayout();
            this.FST_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.DarkCyan;
            this.Sidebar.Controls.Add(this.Notification_btn);
            this.Sidebar.Controls.Add(this.AddUser_btn);
            this.Sidebar.Controls.Add(this.Search_btn);
            this.Sidebar.Controls.Add(this.Profile_btn);
            this.Sidebar.Controls.Add(this.Logout_btn);
            this.Sidebar.Location = new System.Drawing.Point(0, 60);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(60, 805);
            this.Sidebar.TabIndex = 10;
            // 
            // Navber
            // 
            this.Navber.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Navber.Controls.Add(this.sideber_btn);
            this.Navber.Location = new System.Drawing.Point(0, 0);
            this.Navber.Name = "Navber";
            this.Navber.Size = new System.Drawing.Size(1414, 60);
            this.Navber.TabIndex = 13;
            // 
            // sideber_btn
            // 
            this.sideber_btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sideber_btn.BackgroundImage = global::University_Management_System.Properties.Resources.icons8_menu_35;
            this.sideber_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sideber_btn.FlatAppearance.BorderSize = 0;
            this.sideber_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideber_btn.Location = new System.Drawing.Point(15, 15);
            this.sideber_btn.Margin = new System.Windows.Forms.Padding(15, 15, 3, 3);
            this.sideber_btn.Name = "sideber_btn";
            this.sideber_btn.Size = new System.Drawing.Size(35, 35);
            this.sideber_btn.TabIndex = 11;
            this.sideber_btn.UseVisualStyleBackColor = false;
            this.sideber_btn.Click += new System.EventHandler(this.sideber_btn_Click);
            // 
            // FASS_Panel_up
            // 
            this.FASS_Panel_up.BackgroundImage = global::University_Management_System.Properties.Resources.Fass_baneer;
            this.FASS_Panel_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FASS_Panel_up.Location = new System.Drawing.Point(829, 487);
            this.FASS_Panel_up.Name = "FASS_Panel_up";
            this.FASS_Panel_up.Size = new System.Drawing.Size(560, 260);
            this.FASS_Panel_up.TabIndex = 3;
            this.FASS_Panel_up.MouseEnter += new System.EventHandler(this.FASS_Panel_up_MouseEnter);
            // 
            // FST_Panel_up
            // 
            this.FST_Panel_up.BackgroundImage = global::University_Management_System.Properties.Resources.FST_banner;
            this.FST_Panel_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FST_Panel_up.Location = new System.Drawing.Point(161, 143);
            this.FST_Panel_up.Name = "FST_Panel_up";
            this.FST_Panel_up.Size = new System.Drawing.Size(560, 260);
            this.FST_Panel_up.TabIndex = 2;
            this.FST_Panel_up.MouseEnter += new System.EventHandler(this.FST_Panel_up_MouseEnter);
            // 
            // FBA_Panel_up
            // 
            this.FBA_Panel_up.BackgroundImage = global::University_Management_System.Properties.Resources.Fba_Banner;
            this.FBA_Panel_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBA_Panel_up.Location = new System.Drawing.Point(161, 487);
            this.FBA_Panel_up.Name = "FBA_Panel_up";
            this.FBA_Panel_up.Size = new System.Drawing.Size(560, 260);
            this.FBA_Panel_up.TabIndex = 3;
            this.FBA_Panel_up.MouseEnter += new System.EventHandler(this.FBA_Panel_up_MouseEnter);
            // 
            // FE_Panel_up
            // 
            this.FE_Panel_up.BackgroundImage = global::University_Management_System.Properties.Resources.fe_bnr;
            this.FE_Panel_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FE_Panel_up.Location = new System.Drawing.Point(829, 143);
            this.FE_Panel_up.Name = "FE_Panel_up";
            this.FE_Panel_up.Size = new System.Drawing.Size(560, 260);
            this.FE_Panel_up.TabIndex = 3;
            this.FE_Panel_up.MouseEnter += new System.EventHandler(this.FE_Panel_up_MouseEnter);
            // 
            // FASS_panel
            // 
            this.FASS_panel.BackgroundImage = global::University_Management_System.Properties.Resources.Fass_baneer;
            this.FASS_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FASS_panel.Controls.Add(this.FASS_btn_pgrm);
            this.FASS_panel.Controls.Add(this.FASS_btn_dept);
            this.FASS_panel.Location = new System.Drawing.Point(829, 487);
            this.FASS_panel.Name = "FASS_panel";
            this.FASS_panel.Size = new System.Drawing.Size(560, 260);
            this.FASS_panel.TabIndex = 2;
            this.FASS_panel.MouseEnter += new System.EventHandler(this.FASS_panel_MouseEnter);
            this.FASS_panel.MouseLeave += new System.EventHandler(this.FASS_panel_MouseLeave);
            // 
            // FASS_btn_pgrm
            // 
            this.FASS_btn_pgrm.BackColor = System.Drawing.Color.Orange;
            this.FASS_btn_pgrm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FASS_btn_pgrm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FASS_btn_pgrm.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.FASS_btn_pgrm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FASS_btn_pgrm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FASS_btn_pgrm.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FASS_btn_pgrm.ForeColor = System.Drawing.Color.White;
            this.FASS_btn_pgrm.Location = new System.Drawing.Point(433, 184);
            this.FASS_btn_pgrm.Name = "FASS_btn_pgrm";
            this.FASS_btn_pgrm.Size = new System.Drawing.Size(95, 45);
            this.FASS_btn_pgrm.TabIndex = 1;
            this.FASS_btn_pgrm.Text = "Programs";
            this.FASS_btn_pgrm.UseVisualStyleBackColor = false;
            this.FASS_btn_pgrm.Click += new System.EventHandler(this.FASS_btn_pgrm_Click);
            this.FASS_btn_pgrm.MouseEnter += new System.EventHandler(this.FASS_btn_dept_MouseEnter);
            this.FASS_btn_pgrm.MouseLeave += new System.EventHandler(this.FASS_btn_dept_MouseLeave);
            // 
            // FASS_btn_dept
            // 
            this.FASS_btn_dept.BackColor = System.Drawing.Color.DarkCyan;
            this.FASS_btn_dept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FASS_btn_dept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FASS_btn_dept.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.FASS_btn_dept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FASS_btn_dept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FASS_btn_dept.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FASS_btn_dept.ForeColor = System.Drawing.Color.White;
            this.FASS_btn_dept.Location = new System.Drawing.Point(313, 184);
            this.FASS_btn_dept.Name = "FASS_btn_dept";
            this.FASS_btn_dept.Size = new System.Drawing.Size(95, 45);
            this.FASS_btn_dept.TabIndex = 0;
            this.FASS_btn_dept.Text = "Departments";
            this.FASS_btn_dept.UseVisualStyleBackColor = false;
            this.FASS_btn_dept.Click += new System.EventHandler(this.FASS_btn_dept_Click);
            this.FASS_btn_dept.MouseEnter += new System.EventHandler(this.FASS_btn_dept_MouseEnter);
            this.FASS_btn_dept.MouseLeave += new System.EventHandler(this.FASS_btn_dept_MouseLeave);
            // 
            // FBA_panel
            // 
            this.FBA_panel.BackgroundImage = global::University_Management_System.Properties.Resources.Fba_Banner;
            this.FBA_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBA_panel.Controls.Add(this.FBA_btn_pgrm);
            this.FBA_panel.Controls.Add(this.FBA_btn_dept);
            this.FBA_panel.Location = new System.Drawing.Point(161, 487);
            this.FBA_panel.Name = "FBA_panel";
            this.FBA_panel.Size = new System.Drawing.Size(560, 260);
            this.FBA_panel.TabIndex = 2;
            this.FBA_panel.MouseEnter += new System.EventHandler(this.FBA_panel_MouseEnter);
            this.FBA_panel.MouseLeave += new System.EventHandler(this.FBA_panel_MouseLeave);
            // 
            // FBA_btn_pgrm
            // 
            this.FBA_btn_pgrm.BackColor = System.Drawing.Color.Orange;
            this.FBA_btn_pgrm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FBA_btn_pgrm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FBA_btn_pgrm.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.FBA_btn_pgrm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FBA_btn_pgrm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FBA_btn_pgrm.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FBA_btn_pgrm.ForeColor = System.Drawing.Color.White;
            this.FBA_btn_pgrm.Location = new System.Drawing.Point(433, 184);
            this.FBA_btn_pgrm.Name = "FBA_btn_pgrm";
            this.FBA_btn_pgrm.Size = new System.Drawing.Size(95, 45);
            this.FBA_btn_pgrm.TabIndex = 1;
            this.FBA_btn_pgrm.Text = "Programs";
            this.FBA_btn_pgrm.UseVisualStyleBackColor = false;
            this.FBA_btn_pgrm.Click += new System.EventHandler(this.FBA_btn_pgrm_Click);
            this.FBA_btn_pgrm.MouseEnter += new System.EventHandler(this.FBA_btn_dept_MouseEnter);
            this.FBA_btn_pgrm.MouseLeave += new System.EventHandler(this.FBA_btn_dept_MouseLeave);
            // 
            // FBA_btn_dept
            // 
            this.FBA_btn_dept.BackColor = System.Drawing.Color.DarkCyan;
            this.FBA_btn_dept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FBA_btn_dept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FBA_btn_dept.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.FBA_btn_dept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FBA_btn_dept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FBA_btn_dept.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FBA_btn_dept.ForeColor = System.Drawing.Color.White;
            this.FBA_btn_dept.Location = new System.Drawing.Point(313, 184);
            this.FBA_btn_dept.Name = "FBA_btn_dept";
            this.FBA_btn_dept.Size = new System.Drawing.Size(95, 45);
            this.FBA_btn_dept.TabIndex = 0;
            this.FBA_btn_dept.Text = "Departments";
            this.FBA_btn_dept.UseVisualStyleBackColor = false;
            this.FBA_btn_dept.Click += new System.EventHandler(this.FBA_btn_dept_Click);
            this.FBA_btn_dept.MouseEnter += new System.EventHandler(this.FBA_btn_dept_MouseEnter);
            this.FBA_btn_dept.MouseLeave += new System.EventHandler(this.FBA_btn_dept_MouseLeave);
            // 
            // Fe_Panel
            // 
            this.Fe_Panel.BackgroundImage = global::University_Management_System.Properties.Resources.fe_bnr;
            this.Fe_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Fe_Panel.Controls.Add(this.FE_btn_pgrm);
            this.Fe_Panel.Controls.Add(this.FE_btn_dept);
            this.Fe_Panel.Location = new System.Drawing.Point(829, 143);
            this.Fe_Panel.Name = "Fe_Panel";
            this.Fe_Panel.Size = new System.Drawing.Size(560, 260);
            this.Fe_Panel.TabIndex = 2;
            this.Fe_Panel.MouseEnter += new System.EventHandler(this.Fe_Panel_MouseEnter);
            this.Fe_Panel.MouseLeave += new System.EventHandler(this.Fe_Panel_MouseLeave);
            // 
            // FE_btn_pgrm
            // 
            this.FE_btn_pgrm.BackColor = System.Drawing.Color.Orange;
            this.FE_btn_pgrm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FE_btn_pgrm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FE_btn_pgrm.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.FE_btn_pgrm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FE_btn_pgrm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FE_btn_pgrm.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FE_btn_pgrm.ForeColor = System.Drawing.Color.White;
            this.FE_btn_pgrm.Location = new System.Drawing.Point(433, 184);
            this.FE_btn_pgrm.Name = "FE_btn_pgrm";
            this.FE_btn_pgrm.Size = new System.Drawing.Size(95, 45);
            this.FE_btn_pgrm.TabIndex = 1;
            this.FE_btn_pgrm.Text = "Programs";
            this.FE_btn_pgrm.UseVisualStyleBackColor = false;
            this.FE_btn_pgrm.Click += new System.EventHandler(this.FE_btn_pgrm_Click);
            this.FE_btn_pgrm.MouseEnter += new System.EventHandler(this.FE_btn_Dept_MouseEnter);
            this.FE_btn_pgrm.MouseLeave += new System.EventHandler(this.FE_btn_Dept_MouseLeave);
            // 
            // FE_btn_dept
            // 
            this.FE_btn_dept.BackColor = System.Drawing.Color.DarkCyan;
            this.FE_btn_dept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FE_btn_dept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FE_btn_dept.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.FE_btn_dept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FE_btn_dept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FE_btn_dept.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FE_btn_dept.ForeColor = System.Drawing.Color.White;
            this.FE_btn_dept.Location = new System.Drawing.Point(313, 184);
            this.FE_btn_dept.Name = "FE_btn_dept";
            this.FE_btn_dept.Size = new System.Drawing.Size(95, 45);
            this.FE_btn_dept.TabIndex = 0;
            this.FE_btn_dept.Text = "Departments";
            this.FE_btn_dept.UseVisualStyleBackColor = false;
            this.FE_btn_dept.Click += new System.EventHandler(this.FE_btn_dept_Click);
            this.FE_btn_dept.MouseEnter += new System.EventHandler(this.FE_btn_Dept_MouseEnter);
            this.FE_btn_dept.MouseLeave += new System.EventHandler(this.FE_btn_Dept_MouseLeave);
            // 
            // FST_Panel
            // 
            this.FST_Panel.BackgroundImage = global::University_Management_System.Properties.Resources.FST_banner;
            this.FST_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FST_Panel.Controls.Add(this.FST_btn_pgrm);
            this.FST_Panel.Controls.Add(this.FST_btn_dept);
            this.FST_Panel.Location = new System.Drawing.Point(161, 143);
            this.FST_Panel.Name = "FST_Panel";
            this.FST_Panel.Size = new System.Drawing.Size(560, 260);
            this.FST_Panel.TabIndex = 0;
            this.FST_Panel.MouseEnter += new System.EventHandler(this.FST_Panel_MouseEnter);
            this.FST_Panel.MouseLeave += new System.EventHandler(this.FST_Panel_MouseLeave);
            // 
            // FST_btn_pgrm
            // 
            this.FST_btn_pgrm.BackColor = System.Drawing.Color.Orange;
            this.FST_btn_pgrm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FST_btn_pgrm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FST_btn_pgrm.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.FST_btn_pgrm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FST_btn_pgrm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FST_btn_pgrm.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FST_btn_pgrm.ForeColor = System.Drawing.Color.White;
            this.FST_btn_pgrm.Location = new System.Drawing.Point(433, 182);
            this.FST_btn_pgrm.Name = "FST_btn_pgrm";
            this.FST_btn_pgrm.Size = new System.Drawing.Size(95, 45);
            this.FST_btn_pgrm.TabIndex = 1;
            this.FST_btn_pgrm.Text = "Programs";
            this.FST_btn_pgrm.UseVisualStyleBackColor = false;
            this.FST_btn_pgrm.Click += new System.EventHandler(this.FST_btn_pgrm_Click);
            this.FST_btn_pgrm.MouseEnter += new System.EventHandler(this.FST_btn_dept_MouseEnter);
            this.FST_btn_pgrm.MouseLeave += new System.EventHandler(this.FST_btn_dept_MouseLeave);
            // 
            // FST_btn_dept
            // 
            this.FST_btn_dept.BackColor = System.Drawing.Color.DarkCyan;
            this.FST_btn_dept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FST_btn_dept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FST_btn_dept.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.FST_btn_dept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FST_btn_dept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FST_btn_dept.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FST_btn_dept.ForeColor = System.Drawing.Color.White;
            this.FST_btn_dept.Location = new System.Drawing.Point(313, 182);
            this.FST_btn_dept.Name = "FST_btn_dept";
            this.FST_btn_dept.Size = new System.Drawing.Size(95, 45);
            this.FST_btn_dept.TabIndex = 0;
            this.FST_btn_dept.Text = "Departments";
            this.FST_btn_dept.UseVisualStyleBackColor = false;
            this.FST_btn_dept.Click += new System.EventHandler(this.FST_btn_dept_Click);
            this.FST_btn_dept.MouseEnter += new System.EventHandler(this.FST_btn_dept_MouseEnter);
            this.FST_btn_dept.MouseLeave += new System.EventHandler(this.FST_btn_dept_MouseLeave);
            // 
            // Notification_btn
            // 
            this.Notification_btn.BackgroundImage = global::University_Management_System.Properties.Resources.icons8_notification_30;
            this.Notification_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Notification_btn.FlatAppearance.BorderSize = 0;
            this.Notification_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Notification_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Notification_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Notification_btn.Location = new System.Drawing.Point(0, 20);
            this.Notification_btn.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.Notification_btn.Name = "Notification_btn";
            this.Notification_btn.Size = new System.Drawing.Size(60, 60);
            this.Notification_btn.TabIndex = 12;
            this.Notification_btn.UseVisualStyleBackColor = true;
            // 
            // AddUser_btn
            // 
            this.AddUser_btn.BackgroundImage = global::University_Management_System.Properties.Resources.icons8_add_user_male_30;
            this.AddUser_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddUser_btn.FlatAppearance.BorderSize = 0;
            this.AddUser_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AddUser_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.AddUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUser_btn.Location = new System.Drawing.Point(0, 80);
            this.AddUser_btn.Margin = new System.Windows.Forms.Padding(0);
            this.AddUser_btn.Name = "AddUser_btn";
            this.AddUser_btn.Size = new System.Drawing.Size(60, 60);
            this.AddUser_btn.TabIndex = 13;
            this.AddUser_btn.UseVisualStyleBackColor = true;
            this.AddUser_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search_btn
            // 
            this.Search_btn.BackgroundImage = global::University_Management_System.Properties.Resources.icons8_search_more_30;
            this.Search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Search_btn.FlatAppearance.BorderSize = 0;
            this.Search_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Search_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Location = new System.Drawing.Point(0, 140);
            this.Search_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(60, 60);
            this.Search_btn.TabIndex = 15;
            this.Search_btn.UseVisualStyleBackColor = true;
            // 
            // Profile_btn
            // 
            this.Profile_btn.BackgroundImage = global::University_Management_System.Properties.Resources.icons8_test_account_30;
            this.Profile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Profile_btn.FlatAppearance.BorderSize = 0;
            this.Profile_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Profile_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile_btn.Location = new System.Drawing.Point(0, 200);
            this.Profile_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Profile_btn.Name = "Profile_btn";
            this.Profile_btn.Size = new System.Drawing.Size(60, 60);
            this.Profile_btn.TabIndex = 16;
            this.Profile_btn.UseVisualStyleBackColor = true;
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackgroundImage = global::University_Management_System.Properties.Resources.icons8_logout_rounded_30;
            this.Logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_btn.FlatAppearance.BorderSize = 0;
            this.Logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Location = new System.Drawing.Point(0, 260);
            this.Logout_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(60, 60);
            this.Logout_btn.TabIndex = 17;
            this.Logout_btn.UseVisualStyleBackColor = true;
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.BackColor = System.Drawing.Color.White;
            this.Minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_btn.FlatAppearance.BorderSize = 0;
            this.Minimize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Minimize_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_btn.ForeColor = System.Drawing.Color.White;
            this.Minimize_btn.Image = global::University_Management_System.Properties.Resources.icons8_minus_20;
            this.Minimize_btn.Location = new System.Drawing.Point(1415, 0);
            this.Minimize_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.Size = new System.Drawing.Size(60, 60);
            this.Minimize_btn.TabIndex = 8;
            this.Minimize_btn.UseVisualStyleBackColor = false;
            this.Minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.White;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Image = global::University_Management_System.Properties.Resources.icons8_cancel_20;
            this.Exit.Location = new System.Drawing.Point(1475, 0);
            this.Exit.Margin = new System.Windows.Forms.Padding(0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(60, 60);
            this.Exit.TabIndex = 7;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1537, 865);
            this.Controls.Add(this.Navber);
            this.Controls.Add(this.FASS_Panel_up);
            this.Controls.Add(this.FST_Panel_up);
            this.Controls.Add(this.FBA_Panel_up);
            this.Controls.Add(this.FE_Panel_up);
            this.Controls.Add(this.FASS_panel);
            this.Controls.Add(this.FBA_panel);
            this.Controls.Add(this.Fe_Panel);
            this.Controls.Add(this.FST_Panel);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.Minimize_btn);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Sidebar.ResumeLayout(false);
            this.Navber.ResumeLayout(false);
            this.FASS_panel.ResumeLayout(false);
            this.FBA_panel.ResumeLayout(false);
            this.Fe_Panel.ResumeLayout(false);
            this.FST_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Minimize_btn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Button sideber_btn;
        private System.Windows.Forms.Button FST_btn_dept;
        private System.Windows.Forms.Panel FST_Panel;
        private System.Windows.Forms.Button FST_btn_pgrm;
        private System.Windows.Forms.Panel Fe_Panel;
        private System.Windows.Forms.Button FE_btn_pgrm;
        private System.Windows.Forms.Button FE_btn_dept;
        private System.Windows.Forms.Panel FBA_panel;
        private System.Windows.Forms.Button FBA_btn_pgrm;
        private System.Windows.Forms.Button FBA_btn_dept;
        private System.Windows.Forms.Panel FASS_panel;
        private System.Windows.Forms.Button FASS_btn_pgrm;
        private System.Windows.Forms.Button FASS_btn_dept;
        private System.Windows.Forms.Panel FST_Panel_up;
        private System.Windows.Forms.Panel FE_Panel_up;
        private System.Windows.Forms.Panel FBA_Panel_up;
        private System.Windows.Forms.Panel FASS_Panel_up;
        private System.Windows.Forms.Button Notification_btn;
        private System.Windows.Forms.Button AddUser_btn;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Profile_btn;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.FlowLayoutPanel Navber;
    }
}