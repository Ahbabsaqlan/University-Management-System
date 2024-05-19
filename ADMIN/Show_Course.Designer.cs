namespace University_Management_System
{
    partial class Show_Course
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
            this.Course_Name = new System.Windows.Forms.Label();
            this.Course_Code = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fir_pre = new System.Windows.Forms.Label();
            this.Sec_pre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Course_Name
            // 
            this.Course_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Course_Name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Course_Name.Location = new System.Drawing.Point(205, 49);
            this.Course_Name.Name = "Course_Name";
            this.Course_Name.Size = new System.Drawing.Size(1143, 46);
            this.Course_Name.TabIndex = 0;
            this.Course_Name.Text = "Course Name";
            // 
            // Course_Code
            // 
            this.Course_Code.AutoSize = true;
            this.Course_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Course_Code.Location = new System.Drawing.Point(32, 51);
            this.Course_Code.Name = "Course_Code";
            this.Course_Code.Size = new System.Drawing.Size(152, 36);
            this.Course_Code.TabIndex = 1;
            this.Course_Code.Text = "CSE 1120";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(386, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Pre-requised";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(821, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second Pre-requised";
            // 
            // fir_pre
            // 
            this.fir_pre.AutoSize = true;
            this.fir_pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fir_pre.Location = new System.Drawing.Point(591, 117);
            this.fir_pre.Name = "fir_pre";
            this.fir_pre.Size = new System.Drawing.Size(135, 25);
            this.fir_pre.TabIndex = 4;
            this.fir_pre.Text = "Course_Code";
            // 
            // Sec_pre
            // 
            this.Sec_pre.AutoSize = true;
            this.Sec_pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Sec_pre.Location = new System.Drawing.Point(1041, 117);
            this.Sec_pre.Name = "Sec_pre";
            this.Sec_pre.Size = new System.Drawing.Size(135, 25);
            this.Sec_pre.TabIndex = 5;
            this.Sec_pre.Text = "Course_Code";
            // 
            // Show_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Sec_pre);
            this.Controls.Add(this.fir_pre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Course_Code);
            this.Controls.Add(this.Course_Name);
            this.Name = "Show_Course";
            this.Size = new System.Drawing.Size(1477, 159);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Course_Name;
        private System.Windows.Forms.Label Course_Code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fir_pre;
        private System.Windows.Forms.Label Sec_pre;
    }
}
