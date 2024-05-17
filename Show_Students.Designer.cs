namespace University_Management_System
{
    partial class Show_Students
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
            this.Person_First_Name = new System.Windows.Forms.Label();
            this.Person_Image = new System.Windows.Forms.PictureBox();
            this.Person_ID = new System.Windows.Forms.Label();
            this.Person_Last_Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Person_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Person_First_Name
            // 
            this.Person_First_Name.AutoSize = true;
            this.Person_First_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Person_First_Name.Location = new System.Drawing.Point(298, 36);
            this.Person_First_Name.Name = "Person_First_Name";
            this.Person_First_Name.Size = new System.Drawing.Size(234, 39);
            this.Person_First_Name.TabIndex = 0;
            this.Person_First_Name.Text = "Student Name";
            // 
            // Person_Image
            // 
            this.Person_Image.Location = new System.Drawing.Point(57, 17);
            this.Person_Image.Name = "Person_Image";
            this.Person_Image.Size = new System.Drawing.Size(157, 115);
            this.Person_Image.TabIndex = 1;
            this.Person_Image.TabStop = false;
            // 
            // Person_ID
            // 
            this.Person_ID.AutoSize = true;
            this.Person_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Person_ID.Location = new System.Drawing.Point(353, 85);
            this.Person_ID.Name = "Person_ID";
            this.Person_ID.Size = new System.Drawing.Size(141, 29);
            this.Person_ID.TabIndex = 2;
            this.Person_ID.Text = "22-48108-2";
            this.Person_ID.Click += new System.EventHandler(this.Person_ID_Click);
            // 
            // Person_Last_Name
            // 
            this.Person_Last_Name.AutoSize = true;
            this.Person_Last_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Person_Last_Name.Location = new System.Drawing.Point(579, 36);
            this.Person_Last_Name.Name = "Person_Last_Name";
            this.Person_Last_Name.Size = new System.Drawing.Size(234, 39);
            this.Person_Last_Name.TabIndex = 3;
            this.Person_Last_Name.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(309, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // Show_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Person_Last_Name);
            this.Controls.Add(this.Person_ID);
            this.Controls.Add(this.Person_Image);
            this.Controls.Add(this.Person_First_Name);
            this.Name = "Show_Students";
            this.Size = new System.Drawing.Size(1002, 150);
            this.Click += new System.EventHandler(this.Show_Students_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Person_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Person_First_Name;
        private System.Windows.Forms.PictureBox Person_Image;
        private System.Windows.Forms.Label Person_ID;
        private System.Windows.Forms.Label Person_Last_Name;
        private System.Windows.Forms.Label label2;
    }
}
