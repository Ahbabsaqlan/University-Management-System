
namespace University_Management_System
{
    partial class Login1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.User_Text_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Controls.Add(this.Password_TextBox);
            this.panel1.Controls.Add(this.User_Text_Box);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(581, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 373);
            this.panel1.TabIndex = 0;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(55, 249);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(240, 41);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.BackColor = System.Drawing.Color.White;
            this.Password_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password_TextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_TextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Password_TextBox.Location = new System.Drawing.Point(55, 189);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(240, 32);
            this.Password_TextBox.TabIndex = 2;
            this.Password_TextBox.Text = "Password";
            this.Password_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password_TextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Password_TextBox_MouseClick);
            // 
            // User_Text_Box
            // 
            this.User_Text_Box.BackColor = System.Drawing.Color.White;
            this.User_Text_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User_Text_Box.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Text_Box.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.User_Text_Box.Location = new System.Drawing.Point(55, 131);
            this.User_Text_Box.Name = "User_Text_Box";
            this.User_Text_Box.Size = new System.Drawing.Size(240, 32);
            this.User_Text_Box.TabIndex = 1;
            this.User_Text_Box.Text = "User ID";
            this.User_Text_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.User_Text_Box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.User_Text_Box_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "UNIVERSITY MANAGEMENT SYSTEM";
            // 
            // Login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1457, 993);
            this.Controls.Add(this.panel1);
            this.Name = "Login1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Login1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox User_Text_Box;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox Password_TextBox;
    }
}