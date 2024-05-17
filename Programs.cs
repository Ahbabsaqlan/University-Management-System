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
        Faculty faculty;
        public Programs(string facultyID)
        {
            faculty=new Faculty(facultyID);
            faculty.getPrograms();
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
            Program_Show[] pg = new Program_Show[faculty.Programs.Length];
            for (int i = 0; i < pg.Length; i++)
            {
                pg[i] = new Program_Show();
                pg[i].Programss = faculty.Programs[i];
                pg[i].showProgramCourses();
                Pgrm_Panel.Controls.Add(pg[i]);
            }
        }
    }
}
