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
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
            showDepartment();
        }
        
        // Minimize Button
        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
        
        //Data Showing
        private void showDepartment()
        {
            Dept_Show[] pg = new Dept_Show[10];
            for (int i = 0; i < pg.Length; i++)
            {
                pg[i] = new Dept_Show();
                Dept_Panel.Controls.Add(pg[i]);
            }
        }
    }
}
