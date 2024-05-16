using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace University_Management_System
{
    internal class Result
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANGEMENT_SYSTEM;Integrated Security=True;");

        public Result() 
        {

        }

        private string _result_id;
        public string Result_ID
        {
            get { return _result_id; }
            set { _result_id = value; }
        }

        private string _AssessmentName;
        public string AssessmentName
        {
            get { return _AssessmentName; }
            set { _AssessmentName = value; }
        }

        private double _ObtainedMark;

        public double ObtainedMark
        {
            get { return _ObtainedMark; }
            set { _ObtainedMark = value; }
        }

        private Section _section;
 
        public Section Sections
        {
            get { return _section; }
            set { _section = value; }
        }
        private Student _student;
 
        public Student Students
        {
            get { return _student; }
            set { _student = value; }
        }
    }
}
