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
            this.Navbar = new System.Windows.Forms.FlowLayoutPanel();
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.FASS_panel = new System.Windows.Forms.Panel();
            this.FASS_btn_prgm = new System.Windows.Forms.Button();
            this.FASS_btn_dept = new System.Windows.Forms.Button();
            this.FBA_panel = new System.Windows.Forms.Panel();
            this.FBA_btn_pgrm = new System.Windows.Forms.Button();
            this.FBA_btn_dept = new System.Windows.Forms.Button();
            this.Fe_Panel = new System.Windows.Forms.Panel();
            this.FE_btn_prgm = new System.Windows.Forms.Button();
            this.FE_btn_Dept = new System.Windows.Forms.Button();
            this.Dashboard_FST_Banner = new System.Windows.Forms.Panel();
            this.fst_bnr_Btn_Prgm = new System.Windows.Forms.Button();
            this.fst_bnr_Dpt_btn = new System.Windows.Forms.Button();
            this.sideber_btn = new System.Windows.Forms.Button();
            this.Minimize_btn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.FASS_panel.SuspendLayout();
            this.FBA_panel.SuspendLayout();
            this.Fe_Panel.SuspendLayout();
            this.Dashboard_FST_Banner.SuspendLayout();
            this.SuspendLayout();
            // 
            // Navbar
            // 
            this.Navbar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Navbar.Location = new System.Drawing.Point(0, 0);
            this.Navbar.Name = "Navbar";
            this.Navbar.Size = new System.Drawing.Size(1414, 60);
            this.Navbar.TabIndex = 9;
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.DarkCyan;
            this.Sidebar.Location = new System.Drawing.Point(0, 60);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(60, 805);
            this.Sidebar.TabIndex = 10;
            // 
            // FASS_panel
            // 
            this.FASS_panel.BackgroundImage = global::University_Management_System.Properties.Resources.Fass_baneer;
            this.FASS_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FASS_panel.Controls.Add(this.FASS_btn_prgm);
            this.FASS_panel.Controls.Add(this.FASS_btn_dept);
            this.FASS_panel.Location = new System.Drawing.Point(829, 487);
            this.FASS_panel.Name = "FASS_panel";
            this.FASS_panel.Size = new System.Drawing.Size(560, 260);
            this.FASS_panel.TabIndex = 2;
            this.FASS_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.FASS_panel.MouseEnter += new System.EventHandler(this.banner_Hover);
            this.FASS_panel.MouseLeave += new System.EventHandler(this.Dashboard_FST_Banner_MouseLeave);
            // 
            // FASS_btn_prgm
            // 
            this.FASS_btn_prgm.BackColor = System.Drawing.Color.Orange;
            this.FASS_btn_prgm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FASS_btn_prgm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FASS_btn_prgm.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.FASS_btn_prgm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FASS_btn_prgm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FASS_btn_prgm.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FASS_btn_prgm.ForeColor = System.Drawing.Color.White;
            this.FASS_btn_prgm.Location = new System.Drawing.Point(433, 194);
            this.FASS_btn_prgm.Name = "FASS_btn_prgm";
            this.FASS_btn_prgm.Size = new System.Drawing.Size(95, 31);
            this.FASS_btn_prgm.TabIndex = 1;
            this.FASS_btn_prgm.Text = "Programs";
            this.FASS_btn_prgm.UseVisualStyleBackColor = false;
            this.FASS_btn_prgm.MouseEnter += new System.EventHandler(this.bnr_btn_MHover);
            this.FASS_btn_prgm.MouseLeave += new System.EventHandler(this.bnr_btn_Mleave);
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
            this.FASS_btn_dept.Location = new System.Drawing.Point(313, 194);
            this.FASS_btn_dept.Name = "FASS_btn_dept";
            this.FASS_btn_dept.Size = new System.Drawing.Size(95, 31);
            this.FASS_btn_dept.TabIndex = 0;
            this.FASS_btn_dept.Text = "Departments";
            this.FASS_btn_dept.UseVisualStyleBackColor = false;
            this.FASS_btn_dept.MouseEnter += new System.EventHandler(this.bnr_btn_MHover);
            this.FASS_btn_dept.MouseLeave += new System.EventHandler(this.bnr_btn_Mleave);
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
            this.FBA_panel.MouseEnter += new System.EventHandler(this.banner_Hover);
            this.FBA_panel.MouseLeave += new System.EventHandler(this.Dashboard_FST_Banner_MouseLeave);
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
            this.FBA_btn_pgrm.Location = new System.Drawing.Point(433, 194);
            this.FBA_btn_pgrm.Name = "FBA_btn_pgrm";
            this.FBA_btn_pgrm.Size = new System.Drawing.Size(95, 31);
            this.FBA_btn_pgrm.TabIndex = 1;
            this.FBA_btn_pgrm.Text = "Programs";
            this.FBA_btn_pgrm.UseVisualStyleBackColor = false;
            this.FBA_btn_pgrm.MouseEnter += new System.EventHandler(this.bnr_btn_MHover);
            this.FBA_btn_pgrm.MouseLeave += new System.EventHandler(this.bnr_btn_Mleave);
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
            this.FBA_btn_dept.Location = new System.Drawing.Point(313, 194);
            this.FBA_btn_dept.Name = "FBA_btn_dept";
            this.FBA_btn_dept.Size = new System.Drawing.Size(95, 31);
            this.FBA_btn_dept.TabIndex = 0;
            this.FBA_btn_dept.Text = "Departments";
            this.FBA_btn_dept.UseVisualStyleBackColor = false;
            this.FBA_btn_dept.MouseEnter += new System.EventHandler(this.bnr_btn_MHover);
            this.FBA_btn_dept.MouseLeave += new System.EventHandler(this.bnr_btn_Mleave);
            // 
            // Fe_Panel
            // 
            this.Fe_Panel.BackgroundImage = global::University_Management_System.Properties.Resources.fe_bnr;
            this.Fe_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Fe_Panel.Controls.Add(this.FE_btn_prgm);
            this.Fe_Panel.Controls.Add(this.FE_btn_Dept);
            this.Fe_Panel.Location = new System.Drawing.Point(829, 143);
            this.Fe_Panel.Name = "Fe_Panel";
            this.Fe_Panel.Size = new System.Drawing.Size(560, 260);
            this.Fe_Panel.TabIndex = 2;
            this.Fe_Panel.MouseEnter += new System.EventHandler(this.banner_Hover);
            this.Fe_Panel.MouseLeave += new System.EventHandler(this.Dashboard_FST_Banner_MouseLeave);
            // 
            // FE_btn_prgm
            // 
            this.FE_btn_prgm.BackColor = System.Drawing.Color.Orange;
            this.FE_btn_prgm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FE_btn_prgm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FE_btn_prgm.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.FE_btn_prgm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FE_btn_prgm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FE_btn_prgm.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FE_btn_prgm.ForeColor = System.Drawing.Color.White;
            this.FE_btn_prgm.Location = new System.Drawing.Point(433, 194);
            this.FE_btn_prgm.Name = "FE_btn_prgm";
            this.FE_btn_prgm.Size = new System.Drawing.Size(95, 31);
            this.FE_btn_prgm.TabIndex = 1;
            this.FE_btn_prgm.Text = "Programs";
            this.FE_btn_prgm.UseVisualStyleBackColor = false;
            this.FE_btn_prgm.MouseEnter += new System.EventHandler(this.bnr_btn_MHover);
            this.FE_btn_prgm.MouseLeave += new System.EventHandler(this.bnr_btn_Mleave);
            // 
            // FE_btn_Dept
            // 
            this.FE_btn_Dept.BackColor = System.Drawing.Color.DarkCyan;
            this.FE_btn_Dept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FE_btn_Dept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FE_btn_Dept.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.FE_btn_Dept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FE_btn_Dept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FE_btn_Dept.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FE_btn_Dept.ForeColor = System.Drawing.Color.White;
            this.FE_btn_Dept.Location = new System.Drawing.Point(313, 194);
            this.FE_btn_Dept.Name = "FE_btn_Dept";
            this.FE_btn_Dept.Size = new System.Drawing.Size(95, 31);
            this.FE_btn_Dept.TabIndex = 0;
            this.FE_btn_Dept.Text = "Departments";
            this.FE_btn_Dept.UseVisualStyleBackColor = false;
            this.FE_btn_Dept.MouseEnter += new System.EventHandler(this.bnr_btn_MHover);
            this.FE_btn_Dept.MouseLeave += new System.EventHandler(this.bnr_btn_Mleave);
            // 
            // Dashboard_FST_Banner
            // 
            this.Dashboard_FST_Banner.BackgroundImage = global::University_Management_System.Properties.Resources.FST_banner;
            this.Dashboard_FST_Banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dashboard_FST_Banner.Controls.Add(this.fst_bnr_Btn_Prgm);
            this.Dashboard_FST_Banner.Controls.Add(this.fst_bnr_Dpt_btn);
            this.Dashboard_FST_Banner.Location = new System.Drawing.Point(161, 143);
            this.Dashboard_FST_Banner.Name = "Dashboard_FST_Banner";
            this.Dashboard_FST_Banner.Size = new System.Drawing.Size(560, 260);
            this.Dashboard_FST_Banner.TabIndex = 0;
            this.Dashboard_FST_Banner.MouseEnter += new System.EventHandler(this.banner_Hover);
            this.Dashboard_FST_Banner.MouseLeave += new System.EventHandler(this.Dashboard_FST_Banner_MouseLeave);
            // 
            // fst_bnr_Btn_Prgm
            // 
            this.fst_bnr_Btn_Prgm.BackColor = System.Drawing.Color.Orange;
            this.fst_bnr_Btn_Prgm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fst_bnr_Btn_Prgm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fst_bnr_Btn_Prgm.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.fst_bnr_Btn_Prgm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fst_bnr_Btn_Prgm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fst_bnr_Btn_Prgm.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fst_bnr_Btn_Prgm.ForeColor = System.Drawing.Color.White;
            this.fst_bnr_Btn_Prgm.Location = new System.Drawing.Point(433, 194);
            this.fst_bnr_Btn_Prgm.Name = "fst_bnr_Btn_Prgm";
            this.fst_bnr_Btn_Prgm.Size = new System.Drawing.Size(95, 31);
            this.fst_bnr_Btn_Prgm.TabIndex = 1;
            this.fst_bnr_Btn_Prgm.Text = "Programs";
            this.fst_bnr_Btn_Prgm.UseVisualStyleBackColor = false;
            this.fst_bnr_Btn_Prgm.Click += new System.EventHandler(this.fst_bnr_Dpt_btn_Click);
            this.fst_bnr_Btn_Prgm.MouseEnter += new System.EventHandler(this.bnr_btn_MHover);
            this.fst_bnr_Btn_Prgm.MouseLeave += new System.EventHandler(this.bnr_btn_Mleave);
            // 
            // fst_bnr_Dpt_btn
            // 
            this.fst_bnr_Dpt_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.fst_bnr_Dpt_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fst_bnr_Dpt_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fst_bnr_Dpt_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.fst_bnr_Dpt_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fst_bnr_Dpt_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fst_bnr_Dpt_btn.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fst_bnr_Dpt_btn.ForeColor = System.Drawing.Color.White;
            this.fst_bnr_Dpt_btn.Location = new System.Drawing.Point(313, 194);
            this.fst_bnr_Dpt_btn.Name = "fst_bnr_Dpt_btn";
            this.fst_bnr_Dpt_btn.Size = new System.Drawing.Size(95, 31);
            this.fst_bnr_Dpt_btn.TabIndex = 0;
            this.fst_bnr_Dpt_btn.Text = "Departments";
            this.fst_bnr_Dpt_btn.UseVisualStyleBackColor = false;
            this.fst_bnr_Dpt_btn.Click += new System.EventHandler(this.fst_bnr_Dpt_btn_Click);
            this.fst_bnr_Dpt_btn.MouseEnter += new System.EventHandler(this.bnr_btn_MHover);
            this.fst_bnr_Dpt_btn.MouseLeave += new System.EventHandler(this.bnr_btn_Mleave);
            // 
            // sideber_btn
            // 
            this.sideber_btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sideber_btn.BackgroundImage = global::University_Management_System.Properties.Resources.icons8_menu_35;
            this.sideber_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sideber_btn.FlatAppearance.BorderSize = 0;
            this.sideber_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideber_btn.Location = new System.Drawing.Point(13, 12);
            this.sideber_btn.Name = "sideber_btn";
            this.sideber_btn.Size = new System.Drawing.Size(35, 35);
            this.sideber_btn.TabIndex = 11;
            this.sideber_btn.UseVisualStyleBackColor = false;
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
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1537, 865);
            this.Controls.Add(this.FASS_panel);
            this.Controls.Add(this.FBA_panel);
            this.Controls.Add(this.Fe_Panel);
            this.Controls.Add(this.Dashboard_FST_Banner);
            this.Controls.Add(this.sideber_btn);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.Navbar);
            this.Controls.Add(this.Minimize_btn);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.FASS_panel.ResumeLayout(false);
            this.FBA_panel.ResumeLayout(false);
            this.Fe_Panel.ResumeLayout(false);
            this.Dashboard_FST_Banner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Minimize_btn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.FlowLayoutPanel Navbar;
        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Button sideber_btn;
        private System.Windows.Forms.Button fst_bnr_Dpt_btn;
        private System.Windows.Forms.Panel Dashboard_FST_Banner;
        private System.Windows.Forms.Button fst_bnr_Btn_Prgm;
        private System.Windows.Forms.Panel Fe_Panel;
        private System.Windows.Forms.Button FE_btn_prgm;
        private System.Windows.Forms.Button FE_btn_Dept;
        private System.Windows.Forms.Panel FBA_panel;
        private System.Windows.Forms.Button FBA_btn_pgrm;
        private System.Windows.Forms.Button FBA_btn_dept;
        private System.Windows.Forms.Panel FASS_panel;
        private System.Windows.Forms.Button FASS_btn_prgm;
        private System.Windows.Forms.Button FASS_btn_dept;
    }
}