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
    internal partial class Program_Course : Form
    {
        Departments department;
        Program programs;
        public Program_Course(string deptID)
        {
            department = new Departments(deptID);
            department.getDepartmentalCourses();
            InitializeComponent();
            Show_Course[] pg = new Show_Course[department.Courses.Length];
            for (int i = 0; i < pg.Length; i++)
            {
                pg[i] = new Show_Course();
                pg[i].Courses = department.Courses[i];
                pg[i].showCourseInfo();
                Course_LIst.Controls.Add(pg[i]);
            }
        }
        public Program_Course(Program program)
        {
            programs = program;

            InitializeComponent();
            Show_Course[] pg = new Show_Course[programs.Curriculums.CurricullumCourses.Length];
            for (int i=0;i< programs.Curriculums.CurricullumCourses.Length;i++)
            {
                pg[i] = new Show_Course();
                pg[i].Courses = programs.Curriculums.CurricullumCourses[i];
                pg[i].showCourseInfo();
                Course_LIst.Controls.Add(pg[i]);
            }
        }

        private void Adt_Head_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
