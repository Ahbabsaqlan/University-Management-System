namespace University_Management_System
{
    partial class Dept_Show
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
            this.Dept_Name_Label = new System.Windows.Forms.Label();
            this.Dept_ShowTeacher_btn = new System.Windows.Forms.Button();
            this.Dept_ShowCourse_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dept_Name_Label
            // 
            this.Dept_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Dept_Name_Label.Location = new System.Drawing.Point(61, 56);
            this.Dept_Name_Label.Name = "Dept_Name_Label";
            this.Dept_Name_Label.Size = new System.Drawing.Size(676, 101);
            this.Dept_Name_Label.TabIndex = 0;
            this.Dept_Name_Label.Text = "Department of Computer Science";
            // 
            // Dept_ShowTeacher_btn
            // 
            this.Dept_ShowTeacher_btn.BackColor = System.Drawing.Color.DarkKhaki;
            this.Dept_ShowTeacher_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Dept_ShowTeacher_btn.Location = new System.Drawing.Point(821, 79);
            this.Dept_ShowTeacher_btn.Name = "Dept_ShowTeacher_btn";
            this.Dept_ShowTeacher_btn.Size = new System.Drawing.Size(202, 49);
            this.Dept_ShowTeacher_btn.TabIndex = 1;
            this.Dept_ShowTeacher_btn.Text = "Show Teacher List";
            this.Dept_ShowTeacher_btn.UseVisualStyleBackColor = false;
            // 
            // Dept_ShowCourse_btn
            // 
            this.Dept_ShowCourse_btn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Dept_ShowCourse_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Dept_ShowCourse_btn.Location = new System.Drawing.Point(1058, 79);
            this.Dept_ShowCourse_btn.Name = "Dept_ShowCourse_btn";
            this.Dept_ShowCourse_btn.Size = new System.Drawing.Size(224, 49);
            this.Dept_ShowCourse_btn.TabIndex = 2;
            this.Dept_ShowCourse_btn.Text = "Departmental Courses ";
            this.Dept_ShowCourse_btn.UseVisualStyleBackColor = false;
            this.Dept_ShowCourse_btn.Click += new System.EventHandler(this.Dept_ShowCourse_btn_Click);
            // 
            // Dept_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Controls.Add(this.Dept_ShowCourse_btn);
            this.Controls.Add(this.Dept_ShowTeacher_btn);
            this.Controls.Add(this.Dept_Name_Label);
            this.Name = "Dept_Show";
            this.Size = new System.Drawing.Size(1330, 204);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Dept_Name_Label;
        private System.Windows.Forms.Button Dept_ShowTeacher_btn;
        private System.Windows.Forms.Button Dept_ShowCourse_btn;
    }
}
