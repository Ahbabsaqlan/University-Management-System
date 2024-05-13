using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace University_Management_System
{
    public partial class Programs : Form
    {
        public Programs()
        {
            InitializeComponent();
            showProgram();
        }

        // Minimize Button
        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
        // Data Showcasing
        private void showProgram()
        {
            Program_Show[] pg = new Program_Show[10];
            for (int i = 0; i < pg.Length; i++)
            {
                pg[i] = new Program_Show();
                Pgrm_Panel.Controls.Add(pg[i]);
            }
        }
    }
}
