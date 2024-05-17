using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    internal class Departments
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_CITY;Integrated Security=True;");
        
        public Departments(string id) 
        {
            ID = id;
            string departmentData = "select Department_Name,Faculty_ID from DEPARTMENT where Department_ID='" + id + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(departmentData, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow dr = dt.Rows[0];

            DepartmentName=dr.Field<string>(0);
            Facultys = new Faculty(dr.Field<string>(1));

            

        }

        private string _Id;

        public string ID
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _departmentName;

        public string DepartmentName
        {
            get { return _departmentName; }
            set { _departmentName = value; }
        }

        private Course[] _courses;

        public Course[] Courses
        {
            get { return _courses; }
            set { _courses = value; }
        }


        private Faculty _facultys;

        public Faculty Facultys
        {
            get { return _facultys; }
            set { _facultys = value; }
        }

        public void getDepartmentalCourses()
        {
            string departmentData1 = "select Course_ID from COURSE where Department_ID='" + ID + "'";
            SqlDataAdapter adapter1 = new SqlDataAdapter(departmentData1, connection);
            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);
            Courses = new Course[dt1.Rows.Count];
            int index = 0;
            foreach (DataRow dr1 in dt1.Rows)
            {
                Courses[index++] = new Course(dr1.Field<string>(0));
            }
        }
    }
}
