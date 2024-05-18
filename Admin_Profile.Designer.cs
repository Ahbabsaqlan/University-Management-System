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
            this.Minimize_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Profile_picture = new System.Windows.Forms.PictureBox();
            this.Profile_Name_lb = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.Change_btn = new System.Windows.Forms.Button();
            this.Change_pass = new System.Windows.Forms.Label();
            this.Pass_Change_tb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_picture)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.Pass_Change_tb);
            this.panel1.Controls.Add(this.Change_pass);
            this.panel1.Controls.Add(this.Change_btn);
            this.panel1.Controls.Add(this.Profile_picture);
            this.panel1.Controls.Add(this.Profile_Name_lb);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(325, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1504, 881);
            this.panel1.TabIndex = 24;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(85, 188);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(70, 0, 3, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1040, 618);
            this.tableLayoutPanel1.TabIndex = 22;
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
            // Pass_Change_tb
            // 
            this.Pass_Change_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Pass_Change_tb.Location = new System.Drawing.Point(1191, 635);
            this.Pass_Change_tb.Name = "Pass_Change_tb";
            this.Pass_Change_tb.Size = new System.Drawing.Size(237, 30);
            this.Pass_Change_tb.TabIndex = 26;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_picture)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Minimize_btn;
        private Layout layout1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
    }
}