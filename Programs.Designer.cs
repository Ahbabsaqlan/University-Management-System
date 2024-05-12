namespace University_Management_System
{
    partial class Programs
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
            this.Navber = new System.Windows.Forms.FlowLayoutPanel();
            this.sideber_btn = new System.Windows.Forms.Button();
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.Home_btn = new System.Windows.Forms.Button();
            this.AddUser_btn = new System.Windows.Forms.Button();
            this.AddTeacher_btn = new System.Windows.Forms.Button();
            this.AddStudent_btn = new System.Windows.Forms.Button();
            this.Profile_btn = new System.Windows.Forms.Button();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Minimize_btn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Navber.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Navber
            // 
            this.Navber.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Navber.Controls.Add(this.sideber_btn);
            this.Navber.Location = new System.Drawing.Point(1, 0);
            this.Navber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Navber.Name = "Navber";
            this.Navber.Size = new System.Drawing.Size(1885, 74);
            this.Navber.TabIndex = 17;
            // 
            // sideber_btn
            // 
            this.sideber_btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sideber_btn.BackgroundImage = global::University_Management_System.Properties.Resources.icons8_menu_35;
            this.sideber_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sideber_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideber_btn.FlatAppearance.BorderSize = 0;
            this.sideber_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideber_btn.Location = new System.Drawing.Point(20, 18);
            this.sideber_btn.Margin = new System.Windows.Forms.Padding(20, 18, 4, 4);
            this.sideber_btn.Name = "sideber_btn";
            this.sideber_btn.Size = new System.Drawing.Size(47, 43);
            this.sideber_btn.TabIndex = 11;
            this.sideber_btn.UseVisualStyleBackColor = false;
            this.sideber_btn.Click += new System.EventHandler(this.sideber_btn_Click);
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.DarkCyan;
            this.Sidebar.Controls.Add(this.Home_btn);
            this.Sidebar.Controls.Add(this.AddUser_btn);
            this.Sidebar.Controls.Add(this.AddTeacher_btn);
            this.Sidebar.Controls.Add(this.AddStudent_btn);
            this.Sidebar.Controls.Add(this.Profile_btn);
            this.Sidebar.Controls.Add(this.Search_btn);
            this.Sidebar.Controls.Add(this.Logout_btn);
            this.Sidebar.Location = new System.Drawing.Point(1, 74);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(80, 991);
            this.Sidebar.TabIndex = 16;
            // 
            // Home_btn
            // 
            this.Home_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Home_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home_btn.FlatAppearance.BorderSize = 0;
            this.Home_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Home_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.Home_btn.ForeColor = System.Drawing.Color.White;
            this.Home_btn.Image = global::University_Management_System.Properties.Resources.icons8_notification_30;
            this.Home_btn.Location = new System.Drawing.Point(0, 25);
            this.Home_btn.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(80, 74);
            this.Home_btn.TabIndex = 12;
            this.Home_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // AddUser_btn
            // 
            this.AddUser_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddUser_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUser_btn.FlatAppearance.BorderSize = 0;
            this.AddUser_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AddUser_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.AddUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUser_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.AddUser_btn.ForeColor = System.Drawing.Color.White;
            this.AddUser_btn.Image = global::University_Management_System.Properties.Resources.icons8_add_user_male_30;
            this.AddUser_btn.Location = new System.Drawing.Point(0, 99);
            this.AddUser_btn.Margin = new System.Windows.Forms.Padding(0);
            this.AddUser_btn.Name = "AddUser_btn";
            this.AddUser_btn.Size = new System.Drawing.Size(80, 74);
            this.AddUser_btn.TabIndex = 13;
            this.AddUser_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddUser_btn.UseVisualStyleBackColor = true;
            this.AddUser_btn.Click += new System.EventHandler(this.AddUser_btn_Click);
            // 
            // AddTeacher_btn
            // 
            this.AddTeacher_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AddTeacher_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddTeacher_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTeacher_btn.FlatAppearance.BorderSize = 0;
            this.AddTeacher_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AddTeacher_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.AddTeacher_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeacher_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.AddTeacher_btn.ForeColor = System.Drawing.Color.White;
            this.AddTeacher_btn.Image = global::University_Management_System.Properties.Resources.icons8_add_user_male_30;
            this.AddTeacher_btn.Location = new System.Drawing.Point(0, 173);
            this.AddTeacher_btn.Margin = new System.Windows.Forms.Padding(0);
            this.AddTeacher_btn.Name = "AddTeacher_btn";
            this.AddTeacher_btn.Size = new System.Drawing.Size(80, 74);
            this.AddTeacher_btn.TabIndex = 18;
            this.AddTeacher_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddTeacher_btn.UseVisualStyleBackColor = false;
            // 
            // AddStudent_btn
            // 
            this.AddStudent_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AddStudent_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddStudent_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStudent_btn.FlatAppearance.BorderSize = 0;
            this.AddStudent_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AddStudent_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.AddStudent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudent_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.AddStudent_btn.ForeColor = System.Drawing.Color.White;
            this.AddStudent_btn.Image = global::University_Management_System.Properties.Resources.icons8_add_user_male_30;
            this.AddStudent_btn.Location = new System.Drawing.Point(0, 247);
            this.AddStudent_btn.Margin = new System.Windows.Forms.Padding(0);
            this.AddStudent_btn.Name = "AddStudent_btn";
            this.AddStudent_btn.Size = new System.Drawing.Size(80, 74);
            this.AddStudent_btn.TabIndex = 19;
            this.AddStudent_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddStudent_btn.UseVisualStyleBackColor = false;
            this.AddStudent_btn.Click += new System.EventHandler(this.AddStudent_btn_Click);
            // 
            // Profile_btn
            // 
            this.Profile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Profile_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profile_btn.FlatAppearance.BorderSize = 0;
            this.Profile_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Profile_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.Profile_btn.ForeColor = System.Drawing.Color.White;
            this.Profile_btn.Image = global::University_Management_System.Properties.Resources.icons8_test_account_30;
            this.Profile_btn.Location = new System.Drawing.Point(0, 321);
            this.Profile_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Profile_btn.Name = "Profile_btn";
            this.Profile_btn.Size = new System.Drawing.Size(80, 74);
            this.Profile_btn.TabIndex = 16;
            this.Profile_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Profile_btn.UseVisualStyleBackColor = true;
            // 
            // Search_btn
            // 
            this.Search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_btn.FlatAppearance.BorderSize = 0;
            this.Search_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Search_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.Search_btn.ForeColor = System.Drawing.Color.White;
            this.Search_btn.Image = global::University_Management_System.Properties.Resources.icons8_search_more_30;
            this.Search_btn.Location = new System.Drawing.Point(0, 395);
            this.Search_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(80, 74);
            this.Search_btn.TabIndex = 15;
            this.Search_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Search_btn.UseVisualStyleBackColor = true;
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_btn.FlatAppearance.BorderSize = 0;
            this.Logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.Image = global::University_Management_System.Properties.Resources.icons8_logout_rounded_30;
            this.Logout_btn.Location = new System.Drawing.Point(0, 469);
            this.Logout_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(80, 74);
            this.Logout_btn.TabIndex = 17;
            this.Logout_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.Minimize_btn.Location = new System.Drawing.Point(1888, 0);
            this.Minimize_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.Size = new System.Drawing.Size(80, 74);
            this.Minimize_btn.TabIndex = 15;
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
            this.Exit.Location = new System.Drawing.Point(1968, 0);
            this.Exit.Margin = new System.Windows.Forms.Padding(0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(80, 74);
            this.Exit.TabIndex = 14;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Programs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2049, 1065);
            this.Controls.Add(this.Navber);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.Minimize_btn);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Programs";
            this.Text = "Programs";
            this.Navber.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Navber;
        private System.Windows.Forms.Button sideber_btn;
        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Button AddUser_btn;
        private System.Windows.Forms.Button AddTeacher_btn;
        private System.Windows.Forms.Button AddStudent_btn;
        private System.Windows.Forms.Button Profile_btn;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Button Minimize_btn;
        private System.Windows.Forms.Button Exit;
    }
}