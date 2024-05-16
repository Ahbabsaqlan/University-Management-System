using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    internal class Grade
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_CITY;Integrated Security=True;");

        public Grade(string id) 
        { 

        }

        private Course _course;   
        public Course Courses
        {
            get { return _course; }
            set { _course = value; }
        }
        private Section _section;
 
        public Section Sections
        {
            get { return _section; }
            set { _section = value; }
        }
        private double _result;
 
        public double Results
        {
            get { return _result; }
            set { _result = value; }
        }
 
         private Student _student;
 
        public Student Students
        {
            get { return _student; }
            set { _student = value; }
        }
         
    }
}
