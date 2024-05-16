using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    internal class Teacher : Person
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_CITY;Integrated Security=True;");
        public Teacher() { }
        public Teacher(string id) 
        {
            ID = id;
            //Fetch Personal Data
            string teacherData = "select First_Name,Last_Name,Father_Name,Mother_Name,Email,Mobile,NID,Position,Department_ID from TEACHER where Teacher_ID='" + id + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(teacherData, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow dr = dt.Rows[0];

            string query1 = "select House,Road,Area,City from ADDRESS where Person_ID='" + id + "'";
            SqlDataAdapter adapter1 = new SqlDataAdapter(query1, connection);
            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);
            DataRow dr1 = dt1.Rows[0];

            string query2 = "select Day,Month,Year from Date_of_Birth where Person_ID='" + id + "'";
            SqlDataAdapter adapter2 = new SqlDataAdapter(query2, connection);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            DataRow dr2 = dt2.Rows[0];

            

            setval(dr.Field<string>(0), dr.Field<string>(1), dr.Field<string>(2), dr.Field<string>(3), dr.Field<string>(4), dr.Field<string>(5), dr.Field<string>(6), dr1.Field<string>(0), dr1.Field<string>(1), dr1.Field<string>(2), dr1.Field<string>(3), dr2.Field<int>(0), dr2.Field<int>(1), dr2.Field<int>(2));
            Position = dr.Field<string>(7);

            DepartMents = new Departments(dr.Field<string>(8));

        }

        private string _id;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _position;

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }


        private Departments _departments;

        public Departments DepartMents
        {
            get { return _departments; }
            set { _departments = value; }
        }

        private Section[] _registeredCourses;

        public Section[] RegisteredCourses
        {
            get { return _registeredCourses; }
            set { _registeredCourses = value; }
        }
    }
}
