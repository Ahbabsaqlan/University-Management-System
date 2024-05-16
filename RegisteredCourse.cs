using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    internal class RegisteredCourse
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_CITY;Integrated Security=True;");
        public RegisteredCourse(string id) 
        {
            //Fetch Data
            string studentData = "select Section_ID from Registered_Students where Student_ID='" + id + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(studentData, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow dr = dt.Rows[0];
        }

        private Section[] _courses;

        public Section[] Courses
        {
            get { return _courses; }
            set { _courses = value; }
        }

    }
}
