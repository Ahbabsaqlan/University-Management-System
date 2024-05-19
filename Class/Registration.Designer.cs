namespace University_Management_System.Class
{
    partial class Registration
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
            this.Pgrm_Title_Panel = new System.Windows.Forms.Panel();
            this.Pgrm_Title_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pgrm_Title_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pgrm_Title_Panel
            // 
            this.Pgrm_Title_Panel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Pgrm_Title_Panel.Controls.Add(this.Pgrm_Title_Label);
            this.Pgrm_Title_Panel.Location = new System.Drawing.Point(392, 112);
            this.Pgrm_Title_Panel.Name = "Pgrm_Title_Panel";
            this.Pgrm_Title_Panel.Size = new System.Drawing.Size(1336, 70);
            this.Pgrm_Title_Panel.TabIndex = 28;
            // 
            // Pgrm_Title_Label
            // 
            this.Pgrm_Title_Label.AutoSize = true;
            this.Pgrm_Title_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Pgrm_Title_Label.Location = new System.Drawing.Point(72, 15);
            this.Pgrm_Title_Label.Name = "Pgrm_Title_Label";
            this.Pgrm_Title_Label.Size = new System.Drawing.Size(293, 39);
            this.Pgrm_Title_Label.TabIndex = 25;
            this.Pgrm_Title_Label.Text = "Available Courses";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(392, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1335, 182);
            this.panel1.TabIndex = 29;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2031, 1018);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pgrm_Title_Panel);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Pgrm_Title_Panel.ResumeLayout(false);
            this.Pgrm_Title_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pgrm_Title_Panel;
        private System.Windows.Forms.Label Pgrm_Title_Label;
        private System.Windows.Forms.Panel panel1;
    }
}