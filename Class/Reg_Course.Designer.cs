namespace University_Management_System.Class
{
    partial class Reg_Course
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
            this.Name_lb = new System.Windows.Forms.Label();
            this.radioButtoncheck = new System.Windows.Forms.RadioButton();
            this.Time_lb = new System.Windows.Forms.Label();
            this.Teacher_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name_lb
            // 
            this.Name_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Name_lb.ForeColor = System.Drawing.Color.DarkSalmon;
            this.Name_lb.Location = new System.Drawing.Point(265, 43);
            this.Name_lb.Name = "Name_lb";
            this.Name_lb.Size = new System.Drawing.Size(968, 66);
            this.Name_lb.TabIndex = 0;
            this.Name_lb.Text = "label1";
            // 
            // radioButtoncheck
            // 
            this.radioButtoncheck.AutoSize = true;
            this.radioButtoncheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.radioButtoncheck.Location = new System.Drawing.Point(63, 57);
            this.radioButtoncheck.Name = "radioButtoncheck";
            this.radioButtoncheck.Size = new System.Drawing.Size(17, 16);
            this.radioButtoncheck.TabIndex = 1;
            this.radioButtoncheck.TabStop = true;
            this.radioButtoncheck.UseVisualStyleBackColor = true;
            // 
            // Time_lb
            // 
            this.Time_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Time_lb.Location = new System.Drawing.Point(524, 109);
            this.Time_lb.Name = "Time_lb";
            this.Time_lb.Size = new System.Drawing.Size(767, 66);
            this.Time_lb.TabIndex = 2;
            this.Time_lb.Text = "label1";
            this.Time_lb.Click += new System.EventHandler(this.Time_lb_Click);
            // 
            // Teacher_lb
            // 
            this.Teacher_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Teacher_lb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Teacher_lb.Location = new System.Drawing.Point(29, 109);
            this.Teacher_lb.Name = "Teacher_lb";
            this.Teacher_lb.Size = new System.Drawing.Size(433, 49);
            this.Teacher_lb.TabIndex = 3;
            this.Teacher_lb.Text = "label1";
            // 
            // Reg_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Teacher_lb);
            this.Controls.Add(this.Time_lb);
            this.Controls.Add(this.radioButtoncheck);
            this.Controls.Add(this.Name_lb);
            this.Name = "Reg_Course";
            this.Size = new System.Drawing.Size(1335, 182);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_lb;
        private System.Windows.Forms.RadioButton radioButtoncheck;
        private System.Windows.Forms.Label Time_lb;
        private System.Windows.Forms.Label Teacher_lb;
    }
}
