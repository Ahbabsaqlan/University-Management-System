using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using University_Management_System;

namespace University_Management_System
{
    internal class Student : Person
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_CITY;Integrated Security=True;");
        public Student(string id)
        {
            ID = id;
            //Fetch Personal Data
            string studentData = "select First_Name,Last_Name,Father_Name,Mother_Name,Email,Mobile,NID,CGPA,Credit_Completed,Program_ID from STUDENT where Student_ID='" + id + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(studentData, connection);
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
            CGPA = dr.Field<double>(7);
            CreditComplete = dr.Field<int>(8);
            Programs = new Program(dr.Field<string>(9));

            //Fetch Course Data
            string studentData1 = "select Section_ID from Registered_Students where Student_ID='" + id + "'";
            SqlDataAdapter adapter3 = new SqlDataAdapter(studentData1, connection);
            DataTable dt3 = new DataTable();
            adapter3.Fill(dt3);
            int index = 0;
            RegisteredCourses = new Section[dt3.Rows.Count];
            foreach (DataRow data in dt3.Rows)
            {
                foreach (var ids in data.ItemArray)
                {
                    RegisteredCourses[index] = new Section(ids.ToString());
                    index++;
                }
            }

        }

        private string _id;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private double _cgpa;

        public double CGPA
        {
            get { return _cgpa; }
            set { _cgpa = value; }
        }

        private int _creditComplete;

        public int CreditComplete
        {
            get { return _creditComplete; }
            set { _creditComplete = value; }
        }

        private Program _program;

        public Program Programs
        {
            get { return _program; }
            set { _program = value; }
        }

        private Section[] _registeredCourses;

        public Section[] RegisteredCourses
        {
            get { return _registeredCourses; }
            set { _registeredCourses = value; }
        }

        private Course[] _availableCourses;

        public Course[] AvailableCourses
        {
            get { return _availableCourses; }
            set { _availableCourses = value; }
        }



    }

}
