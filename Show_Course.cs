using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management_System
{
    internal partial class Show_Course : UserControl
    {
        public Show_Course()
        {
            InitializeComponent();
            
        }

        private Course _courses;

        public Course Courses
        {
            get { return _courses; }
            set { _courses = value; }
        }
        public void showCourseInfo()
        {
            Course_Name.Text = Courses.CourseName;
            Course_Code.Text = Courses.ID;
            fir_pre.Text = Courses.First_pre_req.ID;
            Sec_pre.Text = Courses.Second_pre_req.ID;
        }
    }
}
