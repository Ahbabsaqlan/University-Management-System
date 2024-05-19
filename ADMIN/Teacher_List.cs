using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management_System
{
    internal partial class Teacher_List : Form
    {
        public Teacher_List(string dept)
        {
            InitializeComponent();
            Teacher_Reg_Label.Text = "Departments Teachers";
            department = new Departments(dept);
            department.getTeachers();
            Show_Students[] pg = new Show_Students[department.Teachers.Length];
            for(int i = 0;i< pg.Length; i++)
            {
                pg[i] = new Show_Students(department.Teachers[i]);
                Students_List_Panel.Controls.Add(pg[i]);
            }
        }
        public Teacher_List(Program programs)
        {
            InitializeComponent();
            Teacher_Reg_Label.Text = "Enrolled Students";
            program = programs;
            program.getStudents();
            Show_Students[] pg = new Show_Students[program.Students.Length];
            for (int i = 0; i < pg.Length; i++)
            {
                pg[i] = new Show_Students(program.Students[i]);
                Students_List_Panel.Controls.Add(pg[i]);
            }
        }

        // Minimize Button
        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        Departments department;
        Program program;
    }
}
