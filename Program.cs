using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    internal class Program
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_CITY;Integrated Security=True;");
        public Program(string id) 
        {
            ID=id;
            string programData = "select Program_Name,Total_Credit,Total_course,Faculty_ID from PROGRAM where Program_ID='" + id + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(programData, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow dr = dt.Rows[0];

            ProgramName = dr.Field<string>(0);
            TotalCreadit = dr.Field<int>(1);
            //TotalCourse = dr.Field<int>(2);
            Facultys = new Faculty(dr.Field<string>(3));
            Curriculums= new Curriculum(id);
        }

        private string _Id;
        public string ID
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _programName;
        public string ProgramName
        {
            get { return _programName; }
            set { _programName = value; }
        }

        private int _totalCreadit;
        public int TotalCreadit
        {
            get { return _totalCreadit; }
            set { _totalCreadit = value; }
        }

        private static int _totalCourse;
        public static int TotalCourse
        {
            get { return _totalCourse; }
            set { _totalCourse = value; }
        }

        private Faculty _faculty;
        public Faculty Facultys
        {
            get { return _faculty; }
            set { _faculty = value; }
        }

 
        private Curriculum _curricullum ;

        public Curriculum Curriculums
        { 
            get { return _curricullum; }
            set { _curricullum = value; }
        }
        

    }
}
