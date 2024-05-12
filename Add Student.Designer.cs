namespace University_Management_System
{
    partial class Add_Student
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nav_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Minimize_btn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Navber = new System.Windows.Forms.Panel();
            this.Navber.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Nav_label
            // 
            this.Nav_label.AutoSize = true;
            this.Nav_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.Nav_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nav_label.Location = new System.Drawing.Point(72, 19);
            this.Nav_label.Name = "Nav_label";
            this.Nav_label.Size = new System.Drawing.Size(262, 29);
            this.Nav_label.TabIndex = 1;
            this.Nav_label.Text = "Student Registration";
            this.Nav_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(322, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.BackColor = System.Drawing.Color.White;
            this.Minimize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Minimize_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_btn.ForeColor = System.Drawing.Color.White;
            this.Minimize_btn.Image = global::University_Management_System.Properties.Resources.icons8_minus_20;
            this.Minimize_btn.Location = new System.Drawing.Point(710, 0);
            this.Minimize_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.Size = new System.Drawing.Size(45, 35);
            this.Minimize_btn.TabIndex = 8;
            this.Minimize_btn.UseVisualStyleBackColor = false;
            this.Minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Image = global::University_Management_System.Properties.Resources.icons8_cancel_20;
            this.Exit.Location = new System.Drawing.Point(755, 0);
            this.Exit.Margin = new System.Windows.Forms.Padding(0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 35);
            this.Exit.TabIndex = 7;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Navber
            // 
            this.Navber.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Navber.Controls.Add(this.Nav_label);
            this.Navber.Location = new System.Drawing.Point(0, 0);
            this.Navber.Name = "Navber";
            this.Navber.Size = new System.Drawing.Size(800, 65);
            this.Navber.TabIndex = 9;
            // 
            // Add_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Minimize_btn);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Navber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Student";
            this.Navber.ResumeLayout(false);
            this.Navber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nav_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Minimize_btn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel Navber;
    }
}