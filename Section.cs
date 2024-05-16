using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace University_Management_System
{
    internal class Section
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANGEMENT_SYSTEM;Integrated Security=True;");

        public Section() 
        {

        }

        private string _id;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _SectionName;

        public string SectionName
        {
            get { return _SectionName; }
            set { _SectionName = value; }
        }

        private string _RoomNo;

        public string RoomNo
        {
            get { return _RoomNo; }
            set { _RoomNo = value; }
        }

        private string _semester;

        public string Semester
        {
            get { return _semester; }
            set { _semester = value; }
        }

        private Teacher _teacher;

        public Teacher Teachers
        {
            get { return _teacher; }
            set { _teacher = value; }
        }

        private Course _course;

        public Course Courses
        {
            get { return _course; }
            set { _course = value; }
        }

       /* private Schedule _schedule;

        public Schedule schedule
        {
            get { return _schedule; }
            set { _schedule = value; }
        }*/

    }
}
