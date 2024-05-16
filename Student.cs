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
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANGEMENT_SYSTEM;Integrated Security=True;");
        public Student(string id)
        {
            ID = id;
            //Fetch Data
            string studentData = "select First_Name,Last_Name,Father_Name,Mother_Name,Email,Mobile,NID,CGPA,Credit_Completed,Program_ID from STUDENT where Student_ID='" + id + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(studentData, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow dr = dt.Rows[0];
            setval(dr.Field<string>(0), dr.Field<string>(1), dr.Field<string>(2), dr.Field<string>(3), dr.Field<string>(4), dr.Field<string>(5), dr.Field<string>(6));
            CGPA=dr.Field<double>(7);
            CreditComplete = dr.Field<int>(8);
            Programs = new Program(dr.Field<string>(9));


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

        
    }

}
