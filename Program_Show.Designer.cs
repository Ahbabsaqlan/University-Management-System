namespace University_Management_System
{
    partial class Program_Show
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
            this.Pgrm_Label = new System.Windows.Forms.Label();
            this.Pgrm_Crs_btn = new System.Windows.Forms.Button();
            this.Enrl_Std_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pgrm_Label
            // 
            this.Pgrm_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Pgrm_Label.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Pgrm_Label.Location = new System.Drawing.Point(45, 39);
            this.Pgrm_Label.Name = "Pgrm_Label";
            this.Pgrm_Label.Size = new System.Drawing.Size(789, 125);
            this.Pgrm_Label.TabIndex = 0;
            this.Pgrm_Label.Text = "Bachelor of Science in Computer Science and Engineering(CSE)";
            // 
            // Pgrm_Crs_btn
            // 
            this.Pgrm_Crs_btn.BackColor = System.Drawing.Color.Coral;
            this.Pgrm_Crs_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Pgrm_Crs_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Pgrm_Crs_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Pgrm_Crs_btn.Location = new System.Drawing.Point(925, 80);
            this.Pgrm_Crs_btn.Name = "Pgrm_Crs_btn";
            this.Pgrm_Crs_btn.Size = new System.Drawing.Size(132, 54);
            this.Pgrm_Crs_btn.TabIndex = 1;
            this.Pgrm_Crs_btn.Text = "Courses";
            this.Pgrm_Crs_btn.UseVisualStyleBackColor = false;
            this.Pgrm_Crs_btn.Click += new System.EventHandler(this.Pgrm_Crs_btn_Click);
            // 
            // Enrl_Std_btn
            // 
            this.Enrl_Std_btn.BackColor = System.Drawing.Color.Orange;
            this.Enrl_Std_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enrl_Std_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Enrl_Std_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Enrl_Std_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Enrl_Std_btn.Location = new System.Drawing.Point(1082, 80);
            this.Enrl_Std_btn.Name = "Enrl_Std_btn";
            this.Enrl_Std_btn.Size = new System.Drawing.Size(162, 54);
            this.Enrl_Std_btn.TabIndex = 2;
            this.Enrl_Std_btn.Text = "Enrolled Students";
            this.Enrl_Std_btn.UseVisualStyleBackColor = false;
            this.Enrl_Std_btn.Click += new System.EventHandler(this.Enrl_Std_btn_Click);
            // 
            // Program_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.Controls.Add(this.Enrl_Std_btn);
            this.Controls.Add(this.Pgrm_Crs_btn);
            this.Controls.Add(this.Pgrm_Label);
            this.Name = "Program_Show";
            this.Size = new System.Drawing.Size(1330, 204);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Pgrm_Label;
        private System.Windows.Forms.Button Pgrm_Crs_btn;
        private System.Windows.Forms.Button Enrl_Std_btn;
    }
}
