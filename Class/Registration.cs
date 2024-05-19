using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management_System.Class
{
    internal partial class Registration : Form
    {
        Student student;
        public Registration(Student students)
        {
            InitializeComponent();
            this.student = students;
            student.getCoursesInfo();
            for (int i = 0; i < student.AvailableCourses.Length; i++)
            {
                for (int j = 0; j < student.AvailableCourses[i].)
            }
        }
    }
}
