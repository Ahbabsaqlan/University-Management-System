namespace University_Management_System
{
    partial class Admin_Profile
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
            this.components = new System.ComponentModel.Container();
            this.Minimize_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Update_Form_Container = new System.Windows.Forms.Panel();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Email_tb = new University_Management_System.TextBox_Admin();
            this.Road_tb = new University_Management_System.TextBox_Admin();
            this.City_tb = new University_Management_System.TextBox_Admin();
            this.Area_tb = new University_Management_System.TextBox_Admin();
            this.Positon_lb = new System.Windows.Forms.Label();
            this.Position_cmbx = new System.Windows.Forms.ComboBox();
            this.NID_tb = new University_Management_System.TextBox_Admin();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.House_tb = new University_Management_System.TextBox_Admin();
            this.Mobile_tb = new University_Management_System.TextBox_Admin();
            this.MotherName_tb = new University_Management_System.TextBox_Admin();
            this.FatherName_tb = new University_Management_System.TextBox_Admin();
            this.LastName_tb = new University_Management_System.TextBox_Admin();
            this.FirstName_tb = new University_Management_System.TextBox_Admin();
            this.DOB_Label = new System.Windows.Forms.Label();
            this.DOB_pkr = new System.Windows.Forms.DateTimePicker();
            this.Update_lb = new System.Windows.Forms.Label();
            this.Pass_Change_tb = new System.Windows.Forms.TextBox();
            this.Change_pass = new System.Windows.Forms.Label();
            this.Change_btn = new System.Windows.Forms.Button();
            this.Profile_picture = new System.Windows.Forms.PictureBox();
            this.Profile_Name_lb = new System.Windows.Forms.Label();
            this.Info_Container = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.layout1 = new University_Management_System.Layout();
            this.uNIVERSITY_MANAGEMENT_CITYDataSet = new University_Management_System.UNIVERSITY_MANAGEMENT_CITYDataSet();
            this.lOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOGINTableAdapter = new University_Management_System.UNIVERSITY_MANAGEMENT_CITYDataSetTableAdapters.LOGINTableAdapter();
            this.panel1.SuspendLayout();
            this.Update_Form_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_picture)).BeginInit();
            this.Info_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uNIVERSITY_MANAGEMENT_CITYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.Minimize_btn.Location = new System.Drawing.Point(1887, 0);
            this.Minimize_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.Size = new System.Drawing.Size(80, 74);
            this.Minimize_btn.TabIndex = 20;
            this.Minimize_btn.UseVisualStyleBackColor = false;
            this.Minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Update_lb);
            this.panel1.Controls.Add(this.Pass_Change_tb);
            this.panel1.Controls.Add(this.Change_pass);
            this.panel1.Controls.Add(this.Change_btn);
            this.panel1.Controls.Add(this.Profile_picture);
            this.panel1.Controls.Add(this.Profile_Name_lb);
            this.panel1.Controls.Add(this.Info_Container);
            this.panel1.Controls.Add(this.Update_Form_Container);
            this.panel1.Location = new System.Drawing.Point(325, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1504, 881);
            this.panel1.TabIndex = 24;
            // 
            // Update_Form_Container
            // 
            this.Update_Form_Container.BackColor = System.Drawing.Color.White;
            this.Update_Form_Container.Controls.Add(this.Update_btn);
            this.Update_Form_Container.Controls.Add(this.Email_tb);
            this.Update_Form_Container.Controls.Add(this.Road_tb);
            this.Update_Form_Container.Controls.Add(this.City_tb);
            this.Update_Form_Container.Controls.Add(this.Area_tb);
            this.Update_Form_Container.Controls.Add(this.Positon_lb);
            this.Update_Form_Container.Controls.Add(this.Position_cmbx);
            this.Update_Form_Container.Controls.Add(this.NID_tb);
            this.Update_Form_Container.Controls.Add(this.button2);
            this.Update_Form_Container.Controls.Add(this.pictureBox1);
            this.Update_Form_Container.Controls.Add(this.House_tb);
            this.Update_Form_Container.Controls.Add(this.Mobile_tb);
            this.Update_Form_Container.Controls.Add(this.MotherName_tb);
            this.Update_Form_Container.Controls.Add(this.FatherName_tb);
            this.Update_Form_Container.Controls.Add(this.LastName_tb);
            this.Update_Form_Container.Controls.Add(this.FirstName_tb);
            this.Update_Form_Container.Controls.Add(this.DOB_Label);
            this.Update_Form_Container.Controls.Add(this.DOB_pkr);
            this.Update_Form_Container.Location = new System.Drawing.Point(0, 145);
            this.Update_Form_Container.Margin = new System.Windows.Forms.Padding(0);
            this.Update_Form_Container.Name = "Update_Form_Container";
            this.Update_Form_Container.Size = new System.Drawing.Size(1504, 704);
            this.Update_Form_Container.TabIndex = 25;
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Update_btn.Location = new System.Drawing.Point(1075, 292);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(375, 62);
            this.Update_btn.TabIndex = 27;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Email_tb
            // 
            this.Email_tb.Location = new System.Drawing.Point(716, 199);
            this.Email_tb.Name = "Email_tb";
            this.Email_tb.NAme = "E-mail";
            this.Email_tb.Placeholder = "";
            this.Email_tb.Size = new System.Drawing.Size(279, 139);
            this.Email_tb.TabIndex = 49;
            this.Email_tb.TExt = "";
            // 
            // Road_tb
            // 
            this.Road_tb.Location = new System.Drawing.Point(716, 344);
            this.Road_tb.Name = "Road_tb";
            this.Road_tb.NAme = "Road";
            this.Road_tb.Placeholder = "";
            this.Road_tb.Size = new System.Drawing.Size(279, 139);
            this.Road_tb.TabIndex = 48;
            this.Road_tb.TExt = "";
            // 
            // City_tb
            // 
            this.City_tb.Location = new System.Drawing.Point(410, 494);
            this.City_tb.Name = "City_tb";
            this.City_tb.NAme = "City";
            this.City_tb.Placeholder = "";
            this.City_tb.Size = new System.Drawing.Size(279, 139);
            this.City_tb.TabIndex = 47;
            this.City_tb.TExt = "";
            // 
            // Area_tb
            // 
            this.Area_tb.Location = new System.Drawing.Point(100, 494);
            this.Area_tb.Name = "Area_tb";
            this.Area_tb.NAme = "Area";
            this.Area_tb.Placeholder = "";
            this.Area_tb.Size = new System.Drawing.Size(279, 139);
            this.Area_tb.TabIndex = 46;
            this.Area_tb.TExt = "";
            // 
            // Positon_lb
            // 
            this.Positon_lb.AutoSize = true;
            this.Positon_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Positon_lb.Location = new System.Drawing.Point(747, 514);
            this.Positon_lb.Name = "Positon_lb";
            this.Positon_lb.Size = new System.Drawing.Size(123, 36);
            this.Positon_lb.TabIndex = 45;
            this.Positon_lb.Text = "Position";
            // 
            // Position_cmbx
            // 
            this.Position_cmbx.FormattingEnabled = true;
            this.Position_cmbx.Items.AddRange(new object[] {
            "Lecturer",
            "Associate Professor",
            "Assistant Prefessor",
            "Professor",
            "Department Head",
            "Director",
            "Associate Dean",
            "Dean",
            "Proctor",
            "Additional Proctor",
            "Register",
            "Additional Register",
            "Vice Chancellor",
            "Pro Vice Chancellor"});
            this.Position_cmbx.Location = new System.Drawing.Point(729, 574);
            this.Position_cmbx.Name = "Position_cmbx";
            this.Position_cmbx.Size = new System.Drawing.Size(236, 24);
            this.Position_cmbx.TabIndex = 42;
            // 
            // NID_tb
            // 
            this.NID_tb.Location = new System.Drawing.Point(716, 62);
            this.NID_tb.Name = "NID_tb";
            this.NID_tb.NAme = "NID";
            this.NID_tb.Placeholder = "";
            this.NID_tb.Size = new System.Drawing.Size(279, 139);
            this.NID_tb.TabIndex = 41;
            this.NID_tb.TExt = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1283, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 48);
            this.button2.TabIndex = 39;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1166, -110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 268);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // House_tb
            // 
            this.House_tb.Location = new System.Drawing.Point(410, 349);
            this.House_tb.Name = "House_tb";
            this.House_tb.NAme = "House";
            this.House_tb.Placeholder = "";
            this.House_tb.Size = new System.Drawing.Size(279, 139);
            this.House_tb.TabIndex = 37;
            this.House_tb.TExt = "";
            // 
            // Mobile_tb
            // 
            this.Mobile_tb.Location = new System.Drawing.Point(100, 349);
            this.Mobile_tb.Name = "Mobile_tb";
            this.Mobile_tb.NAme = "Mobile";
            this.Mobile_tb.Placeholder = "";
            this.Mobile_tb.Size = new System.Drawing.Size(279, 139);
            this.Mobile_tb.TabIndex = 36;
            this.Mobile_tb.TExt = "";
            // 
            // MotherName_tb
            // 
            this.MotherName_tb.Location = new System.Drawing.Point(410, 199);
            this.MotherName_tb.Name = "MotherName_tb";
            this.MotherName_tb.NAme = "Mother Name";
            this.MotherName_tb.Placeholder = "";
            this.MotherName_tb.Size = new System.Drawing.Size(279, 139);
            this.MotherName_tb.TabIndex = 35;
            this.MotherName_tb.TExt = "";
            // 
            // FatherName_tb
            // 
            this.FatherName_tb.Location = new System.Drawing.Point(100, 199);
            this.FatherName_tb.Name = "FatherName_tb";
            this.FatherName_tb.NAme = "Father Name";
            this.FatherName_tb.Placeholder = "";
            this.FatherName_tb.Size = new System.Drawing.Size(279, 139);
            this.FatherName_tb.TabIndex = 34;
            this.FatherName_tb.TExt = "";
            // 
            // LastName_tb
            // 
            this.LastName_tb.Location = new System.Drawing.Point(410, 62);
            this.LastName_tb.Name = "LastName_tb";
            this.LastName_tb.NAme = "Last Name";
            this.LastName_tb.Placeholder = "";
            this.LastName_tb.Size = new System.Drawing.Size(279, 139);
            this.LastName_tb.TabIndex = 33;
            this.LastName_tb.TExt = "";
            // 
            // FirstName_tb
            // 
            this.FirstName_tb.Location = new System.Drawing.Point(100, 62);
            this.FirstName_tb.Name = "FirstName_tb";
            this.FirstName_tb.NAme = "First Name";
            this.FirstName_tb.Placeholder = "";
            this.FirstName_tb.Size = new System.Drawing.Size(279, 131);
            this.FirstName_tb.TabIndex = 32;
            this.FirstName_tb.TExt = "";
            // 
            // DOB_Label
            // 
            this.DOB_Label.AutoSize = true;
            this.DOB_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.DOB_Label.Location = new System.Drawing.Point(1087, 416);
            this.DOB_Label.Name = "DOB_Label";
            this.DOB_Label.Size = new System.Drawing.Size(179, 36);
            this.DOB_Label.TabIndex = 28;
            this.DOB_Label.Text = "Date of Birth";
            // 
            // DOB_pkr
            // 
            this.DOB_pkr.Location = new System.Drawing.Point(1055, 478);
            this.DOB_pkr.Name = "DOB_pkr";
            this.DOB_pkr.Size = new System.Drawing.Size(245, 22);
            this.DOB_pkr.TabIndex = 23;
            // 
            // Update_lb
            // 
            this.Update_lb.AutoSize = true;
            this.Update_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Update_lb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Update_lb.Location = new System.Drawing.Point(1197, 462);
            this.Update_lb.Name = "Update_lb";
            this.Update_lb.Size = new System.Drawing.Size(173, 29);
            this.Update_lb.TabIndex = 28;
            this.Update_lb.Text = "Update Profile";
            this.Update_lb.Click += new System.EventHandler(this.Update_lb_Click);
            // 
            // Pass_Change_tb
            // 
            this.Pass_Change_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Pass_Change_tb.Location = new System.Drawing.Point(1191, 635);
            this.Pass_Change_tb.Name = "Pass_Change_tb";
            this.Pass_Change_tb.Size = new System.Drawing.Size(237, 30);
            this.Pass_Change_tb.TabIndex = 26;
            // 
            // Change_pass
            // 
            this.Change_pass.AutoSize = true;
            this.Change_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Change_pass.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Change_pass.Location = new System.Drawing.Point(1197, 580);
            this.Change_pass.Name = "Change_pass";
            this.Change_pass.Size = new System.Drawing.Size(219, 29);
            this.Change_pass.TabIndex = 25;
            this.Change_pass.Text = "Change Password";
            this.Change_pass.Click += new System.EventHandler(this.Change_pass_Click);
            // 
            // Change_btn
            // 
            this.Change_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Change_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Change_btn.Location = new System.Drawing.Point(1187, 680);
            this.Change_btn.Name = "Change_btn";
            this.Change_btn.Size = new System.Drawing.Size(248, 40);
            this.Change_btn.TabIndex = 24;
            this.Change_btn.Text = "Change";
            this.Change_btn.UseVisualStyleBackColor = false;
            this.Change_btn.Click += new System.EventHandler(this.Change_btn_Click);
            // 
            // Profile_picture
            // 
            this.Profile_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Profile_picture.Location = new System.Drawing.Point(1187, 51);
            this.Profile_picture.Margin = new System.Windows.Forms.Padding(300, 50, 3, 20);
            this.Profile_picture.Name = "Profile_picture";
            this.Profile_picture.Size = new System.Drawing.Size(242, 231);
            this.Profile_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profile_picture.TabIndex = 0;
            this.Profile_picture.TabStop = false;
            // 
            // Profile_Name_lb
            // 
            this.Profile_Name_lb.AutoSize = true;
            this.Profile_Name_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Profile_Name_lb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Profile_Name_lb.Location = new System.Drawing.Point(150, 72);
            this.Profile_Name_lb.Name = "Profile_Name_lb";
            this.Profile_Name_lb.Size = new System.Drawing.Size(108, 39);
            this.Profile_Name_lb.TabIndex = 23;
            this.Profile_Name_lb.Text = "Name";
            // 
            // Info_Container
            // 
            this.Info_Container.BackColor = System.Drawing.SystemColors.Info;
            this.Info_Container.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.Info_Container.ColumnCount = 1;
            this.Info_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Info_Container.Controls.Add(this.label9, 0, 8);
            this.Info_Container.Controls.Add(this.label8, 0, 7);
            this.Info_Container.Controls.Add(this.label7, 0, 6);
            this.Info_Container.Controls.Add(this.label6, 0, 5);
            this.Info_Container.Controls.Add(this.label5, 0, 4);
            this.Info_Container.Controls.Add(this.label4, 0, 3);
            this.Info_Container.Controls.Add(this.label3, 0, 2);
            this.Info_Container.Controls.Add(this.label2, 0, 1);
            this.Info_Container.Controls.Add(this.label1, 0, 0);
            this.Info_Container.Location = new System.Drawing.Point(85, 188);
            this.Info_Container.Margin = new System.Windows.Forms.Padding(70, 0, 3, 50);
            this.Info_Container.Name = "Info_Container";
            this.Info_Container.RowCount = 9;
            this.Info_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Info_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Info_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Info_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Info_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Info_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Info_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Info_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Info_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Info_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Info_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Info_Container.Size = new System.Drawing.Size(1040, 618);
            this.Info_Container.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(5, 546);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 29);
            this.label9.TabIndex = 32;
            this.label9.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(5, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 29);
            this.label8.TabIndex = 31;
            this.label8.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(5, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(5, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(5, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(5, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(5, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(5, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name";
            // 
            // layout1
            // 
            this.layout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout1.Location = new System.Drawing.Point(0, 0);
            this.layout1.Name = "layout1";
            this.layout1.Size = new System.Drawing.Size(2049, 1065);
            this.layout1.TabIndex = 0;
            // 
            // uNIVERSITY_MANAGEMENT_CITYDataSet
            // 
            this.uNIVERSITY_MANAGEMENT_CITYDataSet.DataSetName = "UNIVERSITY_MANAGEMENT_CITYDataSet";
            this.uNIVERSITY_MANAGEMENT_CITYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOGINBindingSource
            // 
            this.lOGINBindingSource.DataMember = "LOGIN";
            this.lOGINBindingSource.DataSource = this.uNIVERSITY_MANAGEMENT_CITYDataSet;
            // 
            // lOGINTableAdapter
            // 
            this.lOGINTableAdapter.ClearBeforeFill = true;
            // 
            // Admin_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2049, 1065);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Minimize_btn);
            this.Controls.Add(this.layout1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Profile";
            this.Text = "Admin_Profile";
            this.Load += new System.EventHandler(this.Admin_Profile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Update_Form_Container.ResumeLayout(false);
            this.Update_Form_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_picture)).EndInit();
            this.Info_Container.ResumeLayout(false);
            this.Info_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uNIVERSITY_MANAGEMENT_CITYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Minimize_btn;
        private Layout layout1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel Info_Container;
        private System.Windows.Forms.PictureBox Profile_picture;
        private System.Windows.Forms.Label Profile_Name_lb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pass_Change_tb;
        private System.Windows.Forms.Label Change_pass;
        private System.Windows.Forms.Button Change_btn;
        private System.Windows.Forms.Label Update_lb;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Panel Update_Form_Container;
        private TextBox_Admin Email_tb;
        private TextBox_Admin Road_tb;
        private TextBox_Admin City_tb;
        private TextBox_Admin Area_tb;
        private System.Windows.Forms.Label Positon_lb;
        private System.Windows.Forms.ComboBox Position_cmbx;
        private TextBox_Admin NID_tb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TextBox_Admin House_tb;
        private TextBox_Admin Mobile_tb;
        private TextBox_Admin MotherName_tb;
        private TextBox_Admin FatherName_tb;
        private TextBox_Admin LastName_tb;
        private TextBox_Admin FirstName_tb;
        private System.Windows.Forms.Label DOB_Label;
        private System.Windows.Forms.DateTimePicker DOB_pkr;
        private UNIVERSITY_MANAGEMENT_CITYDataSet uNIVERSITY_MANAGEMENT_CITYDataSet;
        private System.Windows.Forms.BindingSource lOGINBindingSource;
        private UNIVERSITY_MANAGEMENT_CITYDataSetTableAdapters.LOGINTableAdapter lOGINTableAdapter;
    }
}