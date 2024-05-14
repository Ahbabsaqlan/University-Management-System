namespace University_Management_System
{
    partial class TextBox_Admin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox = new System.Windows.Forms.TextBox();
            this.TextBox_Label = new System.Windows.Forms.Label();
            this.Textbox_bg_Panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.White;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.TextBox.Location = new System.Drawing.Point(12, 85);
            this.TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(255, 24);
            this.TextBox.TabIndex = 26;
            this.TextBox.Click += new System.EventHandler(this.TextBox_Click);
            // 
            // TextBox_Label
            // 
            this.TextBox_Label.AutoSize = true;
            this.TextBox_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TextBox_Label.Location = new System.Drawing.Point(28, 25);
            this.TextBox_Label.Name = "TextBox_Label";
            this.TextBox_Label.Size = new System.Drawing.Size(205, 36);
            this.TextBox_Label.TabIndex = 25;
            this.TextBox_Label.Text = "TextBox Label";
            // 
            // Textbox_bg_Panel
            // 
            this.Textbox_bg_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Textbox_bg_Panel.Location = new System.Drawing.Point(12, 83);
            this.Textbox_bg_Panel.Name = "Textbox_bg_Panel";
            this.Textbox_bg_Panel.Size = new System.Drawing.Size(255, 30);
            this.Textbox_bg_Panel.TabIndex = 27;
            // 
            // TextBox_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.TextBox_Label);
            this.Controls.Add(this.Textbox_bg_Panel);
            this.Name = "TextBox_Admin";
            this.Size = new System.Drawing.Size(279, 139);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label TextBox_Label;
        private System.Windows.Forms.Panel Textbox_bg_Panel;
    }
}
