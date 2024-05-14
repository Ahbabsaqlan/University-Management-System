namespace University_Management_System
{
    partial class Department
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
            this.panelborder = new System.Windows.Forms.Panel();
            this.Pgrm_Title_Panel = new System.Windows.Forms.Panel();
            this.Pgrm_Title_Label = new System.Windows.Forms.Label();
            this.Dept_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.layout1 = new University_Management_System.Layout();
            this.Minimize_btn = new System.Windows.Forms.Button();
            this.Pgrm_Title_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelborder
            // 
            this.panelborder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelborder.Location = new System.Drawing.Point(356, 201);
            this.panelborder.Name = "panelborder";
            this.panelborder.Size = new System.Drawing.Size(1336, 2);
            this.panelborder.TabIndex = 28;
            // 
            // Pgrm_Title_Panel
            // 
            this.Pgrm_Title_Panel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Pgrm_Title_Panel.Controls.Add(this.Pgrm_Title_Label);
            this.Pgrm_Title_Panel.Location = new System.Drawing.Point(356, 112);
            this.Pgrm_Title_Panel.Name = "Pgrm_Title_Panel";
            this.Pgrm_Title_Panel.Size = new System.Drawing.Size(1336, 88);
            this.Pgrm_Title_Panel.TabIndex = 27;
            // 
            // Pgrm_Title_Label
            // 
            this.Pgrm_Title_Label.AutoSize = true;
            this.Pgrm_Title_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Pgrm_Title_Label.Location = new System.Drawing.Point(72, 23);
            this.Pgrm_Title_Label.Name = "Pgrm_Title_Label";
            this.Pgrm_Title_Label.Size = new System.Drawing.Size(211, 39);
            this.Pgrm_Title_Label.TabIndex = 25;
            this.Pgrm_Title_Label.Text = "Departments";
            // 
            // Dept_Panel
            // 
            this.Dept_Panel.AutoScroll = true;
            this.Dept_Panel.AutoSize = true;
            this.Dept_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dept_Panel.Location = new System.Drawing.Point(356, 204);
            this.Dept_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Dept_Panel.MaximumSize = new System.Drawing.Size(1336, 860);
            this.Dept_Panel.MinimumSize = new System.Drawing.Size(1336, 210);
            this.Dept_Panel.Name = "Dept_Panel";
            this.Dept_Panel.Size = new System.Drawing.Size(1336, 210);
            this.Dept_Panel.TabIndex = 26;
            // 
            // layout1
            // 
            this.layout1.Location = new System.Drawing.Point(0, 0);
            this.layout1.Margin = new System.Windows.Forms.Padding(0);
            this.layout1.Name = "layout1";
            this.layout1.Size = new System.Drawing.Size(2049, 1065);
            this.layout1.TabIndex = 29;
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
            this.Minimize_btn.TabIndex = 15;
            this.Minimize_btn.UseVisualStyleBackColor = false;
            this.Minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2049, 1065);
            this.Controls.Add(this.panelborder);
            this.Controls.Add(this.Pgrm_Title_Panel);
            this.Controls.Add(this.Dept_Panel);
            this.Controls.Add(this.Minimize_btn);
            this.Controls.Add(this.layout1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Department";
            this.Text = "Department";
            this.Pgrm_Title_Panel.ResumeLayout(false);
            this.Pgrm_Title_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Minimize_btn;
        private System.Windows.Forms.Panel panelborder;
        private System.Windows.Forms.Panel Pgrm_Title_Panel;
        private System.Windows.Forms.Label Pgrm_Title_Label;
        private System.Windows.Forms.FlowLayoutPanel Dept_Panel;
        private Layout layout1;
    }
}