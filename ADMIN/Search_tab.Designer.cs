namespace University_Management_System
{
    partial class Search_tab
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ID_lb = new System.Windows.Forms.Label();
            this.Name_lb = new System.Windows.Forms.Label();
            this.Image_bx = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_bx)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.ID_lb);
            this.panel1.Controls.Add(this.Name_lb);
            this.panel1.Location = new System.Drawing.Point(126, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 109);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.Search_tab_Click);
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Location = new System.Drawing.Point(44, 74);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.Size = new System.Drawing.Size(44, 16);
            this.ID_lb.TabIndex = 3;
            this.ID_lb.Text = "label2";
            this.ID_lb.Click += new System.EventHandler(this.Search_tab_Click);
            // 
            // Name_lb
            // 
            this.Name_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name_lb.Location = new System.Drawing.Point(26, 19);
            this.Name_lb.Name = "Name_lb";
            this.Name_lb.Size = new System.Drawing.Size(206, 43);
            this.Name_lb.TabIndex = 2;
            this.Name_lb.Text = "label1";
            this.Name_lb.Click += new System.EventHandler(this.Search_tab_Click);
            // 
            // Image_bx
            // 
            this.Image_bx.Location = new System.Drawing.Point(26, 19);
            this.Image_bx.Name = "Image_bx";
            this.Image_bx.Size = new System.Drawing.Size(74, 71);
            this.Image_bx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image_bx.TabIndex = 0;
            this.Image_bx.TabStop = false;
            this.Image_bx.Click += new System.EventHandler(this.Search_tab_Click);
            // 
            // Search_tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Image_bx);
            this.Name = "Search_tab";
            this.Size = new System.Drawing.Size(376, 109);
            this.Click += new System.EventHandler(this.Search_tab_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_bx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Image_bx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.Label Name_lb;
    }
}
