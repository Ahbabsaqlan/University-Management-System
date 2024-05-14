namespace University_Management_System
{
    partial class Program_Course
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
            this.layout1 = new University_Management_System.Layout();
            this.Adt_Head_Panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bar = new System.Windows.Forms.Panel();
            this.Teacher_Reg_Label = new System.Windows.Forms.Label();
            this.Minimize_btn = new System.Windows.Forms.Button();
            this.Course_LIst = new System.Windows.Forms.FlowLayoutPanel();
            this.Adt_Head_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout1
            // 
            this.layout1.Location = new System.Drawing.Point(0, 0);
            this.layout1.Margin = new System.Windows.Forms.Padding(0);
            this.layout1.Name = "layout1";
            this.layout1.Size = new System.Drawing.Size(2049, 1065);
            this.layout1.TabIndex = 30;
            this.layout1.Load += new System.EventHandler(this.layout1_Load);
            // 
            // Adt_Head_Panel
            // 
            this.Adt_Head_Panel.BackColor = System.Drawing.Color.MintCream;
            this.Adt_Head_Panel.Controls.Add(this.panel2);
            this.Adt_Head_Panel.Controls.Add(this.bar);
            this.Adt_Head_Panel.Controls.Add(this.Teacher_Reg_Label);
            this.Adt_Head_Panel.Location = new System.Drawing.Point(357, 134);
            this.Adt_Head_Panel.Name = "Adt_Head_Panel";
            this.Adt_Head_Panel.Size = new System.Drawing.Size(1477, 72);
            this.Adt_Head_Panel.TabIndex = 32;
            this.Adt_Head_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Adt_Head_Panel_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1564, 10);
            this.panel2.TabIndex = 23;
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bar.Location = new System.Drawing.Point(1440, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(10, 72);
            this.bar.TabIndex = 22;
            // 
            // Teacher_Reg_Label
            // 
            this.Teacher_Reg_Label.AutoSize = true;
            this.Teacher_Reg_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Teacher_Reg_Label.Location = new System.Drawing.Point(134, 12);
            this.Teacher_Reg_Label.Name = "Teacher_Reg_Label";
            this.Teacher_Reg_Label.Size = new System.Drawing.Size(144, 39);
            this.Teacher_Reg_Label.TabIndex = 0;
            this.Teacher_Reg_Label.Text = "Courses";
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
            this.Minimize_btn.Location = new System.Drawing.Point(1888, 0);
            this.Minimize_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.Size = new System.Drawing.Size(80, 74);
            this.Minimize_btn.TabIndex = 31;
            this.Minimize_btn.UseVisualStyleBackColor = false;
            // 
            // Course_LIst
            // 
            this.Course_LIst.AutoScroll = true;
            this.Course_LIst.AutoSize = true;
            this.Course_LIst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Course_LIst.Location = new System.Drawing.Point(357, 207);
            this.Course_LIst.Margin = new System.Windows.Forms.Padding(0);
            this.Course_LIst.MaximumSize = new System.Drawing.Size(1477, 831);
            this.Course_LIst.MinimumSize = new System.Drawing.Size(1477, 159);
            this.Course_LIst.Name = "Course_LIst";
            this.Course_LIst.Size = new System.Drawing.Size(1477, 159);
            this.Course_LIst.TabIndex = 34;
            // 
            // Program_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2049, 1065);
            this.Controls.Add(this.Course_LIst);
            this.Controls.Add(this.Adt_Head_Panel);
            this.Controls.Add(this.Minimize_btn);
            this.Controls.Add(this.layout1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Program_Course";
            this.Text = "Program_Course";
            this.Adt_Head_Panel.ResumeLayout(false);
            this.Adt_Head_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Layout layout1;
        private System.Windows.Forms.Button Minimize_btn;
        private System.Windows.Forms.Panel Adt_Head_Panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.Label Teacher_Reg_Label;
        private System.Windows.Forms.FlowLayoutPanel Course_LIst;
    }
}