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
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_CITY;Integrated Security=True;");

        public Result(string sectionID,string studentID) 
        {
            //Fetch Data
            string Data1 = "select Result_ID,Attendance_Mid,Attendance_Final,Quiz_1,Quiz_2,Quiz_3,Quiz_4,Mid_Exam,Final_Exam,Mid_Term,Final_Term,Total from Result where Section_ID='" + sectionID + "' and student_ID='"+studentID+"'";
            SqlDataAdapter adapter2 = new SqlDataAdapter(Data1, connection);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            if(dt2.Rows.Count > 0)
            {
                DataRow dr = dt2.Rows[0];
                Result_ID = dr.Field<string>(0);
                AttendanceMid = dr.Field<double>(1);
                AttendanceFinal = dr.Field<double>(2);
                Quiz1 = dr.Field<double>(3);
                Quiz2 = dr.Field<double>(4);
                Quiz3 = dr.Field<double>(5);
                Quiz4 = dr.Field<double>(6);
                MidExam = dr.Field<double>(7);
                FinalExam = dr.Field<double>(8);
                MidResult = dr.Field<double>(9);
                FinalResult = dr.Field<double>(10);
                Grade = dr.Field<double>(11);
                StudentID = studentID;
                SectionID = sectionID;
            }
            else
            {
                Result_ID = null;
                AttendanceMid = 0;
                AttendanceFinal = 0;
                Quiz1 = 0;
                Quiz2 = 0;
                Quiz3 = 0;
                Quiz4 = 0;
                MidExam = 0;
                FinalExam = 0;
                MidResult = 0;
                FinalResult = 0;
                Grade = 0;
                StudentID = studentID;
                SectionID = sectionID;
            }
            
        }

        private string _result_id;
        public string Result_ID
        {
            get { return _result_id; }
            set { _result_id = value; }
        }

        private double _attendanceMid;
        public double AttendanceMid
        {
            get { return _attendanceMid; }
            set { _attendanceMid = value; }
        }

        private double _attendanceFinal;
        public double AttendanceFinal
        {
            get { return _attendanceFinal; }
            set { _attendanceFinal = value; }
        }

        private double _quiz1;

        public double Quiz1
        {
            get { return _quiz1; }
            set { _quiz1 = value; }
        }

        private double _quiz2;
        public double Quiz2
        {
            get { return _quiz2; }
            set { _quiz2 = value; }
        }

        private double _quiz3;
        public double Quiz3
        {
            get { return _quiz3; }
            set { _quiz3 = value; }
        }

        private double _quiz4;
        public double Quiz4
        {
            get { return _quiz4; }
            set { _quiz4 = value; }
        }

        private double _midExam;

        public double MidExam
        {
            get { return _midExam; }
            set { _midExam = value; }
        }

        private double _finalExam;

        public double FinalExam
        {
            get { return _finalExam; }
            set { _finalExam = value; }
        }

        private double _midResult;

        public double MidResult
        {
            get { return _midResult; }
            set { _midResult = value; }
        }

        private double _finalResult;

        public double FinalResult
        {
            get { return _finalResult; }
            set { _finalResult = value; }
        }


        private double _grade;

        public double Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        private string _sectionID;

        public string SectionID
        {
            get { return _sectionID; }
            set { _sectionID = value; }
        }

        private string _studentID;

        public string StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }
    }
}
