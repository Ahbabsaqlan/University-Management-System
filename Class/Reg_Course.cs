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
    internal partial class Reg_Course : UserControl
    {
        public Reg_Course(Section section)
        {
            InitializeComponent();
            Name_lb.Text=section.Courses.CourseName+"["+section.SectionName+"]";
            Teacher_lb.Text=section.Teachers.FirstName+" "+section.Teachers.LastName;
            Time_lb.Text = section.Schedules.ScheduleTime + " " + section.Schedules.ScheduleDay + "   " + section.RoomNo;
        }

        private void Time_lb_Click(object sender, EventArgs e)
        {

        }
    }
}
