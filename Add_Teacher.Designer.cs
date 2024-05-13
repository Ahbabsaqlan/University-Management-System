namespace University_Management_System
{
    partial class Add_Teacher
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
            this.Adt_Head_Panel = new System.Windows.Forms.Panel();
            this.Minimize_btn = new System.Windows.Forms.Button();
            this.Teacher_Reg_Label = new System.Windows.Forms.Label();
            this.bar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.First_Name_Tbx = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Adt_Form_Container = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.layout1 = new University_Management_System.Layout();
            this.Adt_Head_Panel.SuspendLayout();
            this.Adt_Form_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // Adt_Head_Panel
            // 
            this.Adt_Head_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Adt_Head_Panel.Controls.Add(this.panel2);
            this.Adt_Head_Panel.Controls.Add(this.bar);
            this.Adt_Head_Panel.Controls.Add(this.Teacher_Reg_Label);
            this.Adt_Head_Panel.Location = new System.Drawing.Point(280, 109);
            this.Adt_Head_Panel.Name = "Adt_Head_Panel";
            this.Adt_Head_Panel.Size = new System.Drawing.Size(1564, 72);
            this.Adt_Head_Panel.TabIndex = 1;
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
            this.Minimize_btn.Location = new System.Drawing.Point(1886, 0);
            this.Minimize_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.Size = new System.Drawing.Size(80, 74);
            this.Minimize_btn.TabIndex = 20;
            this.Minimize_btn.UseVisualStyleBackColor = false;
            this.Minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // Teacher_Reg_Label
            // 
            this.Teacher_Reg_Label.AutoSize = true;
            this.Teacher_Reg_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Teacher_Reg_Label.Location = new System.Drawing.Point(134, 12);
            this.Teacher_Reg_Label.Name = "Teacher_Reg_Label";
            this.Teacher_Reg_Label.Size = new System.Drawing.Size(333, 39);
            this.Teacher_Reg_Label.TabIndex = 0;
            this.Teacher_Reg_Label.Text = "Teacher Registration";
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bar.Location = new System.Drawing.Point(1440, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(10, 72);
            this.bar.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(1740, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 72);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1564, 10);
            this.panel2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(110, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 36);
            this.label1.TabIndex = 21;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // First_Name_Tbx
            // 
            this.First_Name_Tbx.BackColor = System.Drawing.Color.White;
            this.First_Name_Tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.First_Name_Tbx.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.First_Name_Tbx.Location = new System.Drawing.Point(94, 114);
            this.First_Name_Tbx.Margin = new System.Windows.Forms.Padding(0);
            this.First_Name_Tbx.Name = "First_Name_Tbx";
            this.First_Name_Tbx.Size = new System.Drawing.Size(255, 24);
            this.First_Name_Tbx.TabIndex = 22;
            this.First_Name_Tbx.Text = "       First Name";
            this.First_Name_Tbx.TextChanged += new System.EventHandler(this.First_Name_Tbx_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1341, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // Adt_Form_Container
            // 
            this.Adt_Form_Container.BackColor = System.Drawing.Color.White;
            this.Adt_Form_Container.Controls.Add(this.dateTimePicker1);
            this.Adt_Form_Container.Controls.Add(this.First_Name_Tbx);
            this.Adt_Form_Container.Controls.Add(this.label1);
            this.Adt_Form_Container.Controls.Add(this.panel3);
            this.Adt_Form_Container.Location = new System.Drawing.Point(280, 182);
            this.Adt_Form_Container.Margin = new System.Windows.Forms.Padding(0);
            this.Adt_Form_Container.Name = "Adt_Form_Container";
            this.Adt_Form_Container.Size = new System.Drawing.Size(1564, 791);
            this.Adt_Form_Container.TabIndex = 24;
            this.Adt_Form_Container.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(94, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 30);
            this.panel3.TabIndex = 24;
            // 
            // layout1
            // 
            this.layout1.Location = new System.Drawing.Point(0, 0);
            this.layout1.Margin = new System.Windows.Forms.Padding(0);
            this.layout1.Name = "layout1";
            this.layout1.Size = new System.Drawing.Size(2049, 1065);
            this.layout1.TabIndex = 2;
            // 
            // Add_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2049, 1065);
            this.Controls.Add(this.Adt_Form_Container);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Minimize_btn);
            this.Controls.Add(this.Adt_Head_Panel);
            this.Controls.Add(this.layout1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Teacher";
            this.Text = "Add_Teacher";
            this.Adt_Head_Panel.ResumeLayout(false);
            this.Adt_Head_Panel.PerformLayout();
            this.Adt_Form_Container.ResumeLayout(false);
            this.Adt_Form_Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Adt_Head_Panel;
        private Layout layout1;
        private System.Windows.Forms.Button Minimize_btn;
        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.Label Teacher_Reg_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox First_Name_Tbx;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel Adt_Form_Container;
        private System.Windows.Forms.Panel panel3;
    }
}