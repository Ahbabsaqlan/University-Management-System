using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    internal class Course
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANGEMENT_SYSTEM;Integrated Security=True;");

        public Course(string id) 
        {
            ID = id;
            if (id is null)
            {
               
                CourseName = "No Pre-requised";
            }
            else
            {
                //Fetch Data
                string studentData = "select Course_Name,Credits,First_Pre_Req,Second_Pre_Req,Department_ID from COURSE where Course_ID='" + id + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(studentData, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DataRow dr = dt.Rows[0];
                CourseName = dr.Field<string>(0);
                Credit = dr.Field<int>(1);
                if (dr[2]==DBNull.Value)
                {
                    First_pre_req = new Course(dr.Field<string>(2));
                }
                else
                {
                    First_pre_req = new Course(null);
                }

                if (dr[3] ==DBNull.Value)
                {
                    Second_pre_req = new Course(dr.Field<string>(3));
                }
                else
                {
                    Second_pre_req = new Course(null);
                }
                Departments = new Departments(dr.Field<string>(4));
            }
        }

        private string _id;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _coursename;

        public string CourseName
        {
            get { return _coursename; }
            set { _coursename = value; }
        }

        private int _credit;

        public int Credit
        {
            get { return _credit; }
            set { _credit = value; }
        }

        private Course _first_pre_req;

         public Course First_pre_req
         {
             get { return _first_pre_req; }
             set { _first_pre_req = value; }
         }

         private Course _second_pre_req;

         public Course Second_pre_req
         {
             get { return _second_pre_req; }
             set { _second_pre_req = value; }
         }

        private Departments _department;

        public Departments Departments
        {
            get { return _department; }
            set { _department = value; }
        }
    }
}
