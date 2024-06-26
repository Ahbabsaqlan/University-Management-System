﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.CompilerServices;

namespace University_Management_System
{
    internal class Section
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_CITY;Integrated Security=True;");

        public Section(string id) 
        {
            ID = id;
            //Fetch Data
            string query = "select Section_Name,Semester,Schedule,Room_No,Course_ID,Teacher_ID,Day from SECTION where Section_ID='" + id + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow dr = dt.Rows[0];
            SectionName = dr.Field<string>(0);
            Semester = dr.Field<string>(1);
            Schedules=new Schedule(dr.Field<string>(2),dr.Field<string>(6));
            RoomNo= dr.Field<string>(3);
            Courses = new Course(dr.Field<string>(4));
            Teachers=new Teacher(dr.Field<string>(5));
            RegisteredStudents = new RegisteredStudent(id);
            Results = new Result[RegisteredStudents.Students.Length];
            for (int i = 0; i < Results.Length; i++)
            {
                Results[i] = new Result(ID, RegisteredStudents.Students[i].ID);
            }
            Notices=new Notice(ID);
        }

        private string _id;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _SectionName;

        public string SectionName
        {
            get { return _SectionName; }
            set { _SectionName = value; }
        }

        private string _RoomNo;

        public string RoomNo
        {
            get { return _RoomNo; }
            set { _RoomNo = value; }
        }

        private string _semester;

        public string Semester
        {
            get { return _semester; }
            set { _semester = value; }
        }

        private Teacher _teacher;

        public Teacher Teachers
        {
            get { return _teacher; }
            set { _teacher = value; }
        }

        private Course _course;

        public Course Courses
        {
            get { return _course; }
            set { _course = value; }
        }

        private Schedule _schedule;

        public Schedule Schedules
        {
            get { return _schedule; }
            set { _schedule = value; }
        }

        private RegisteredStudent _registeredStudents;

        public RegisteredStudent RegisteredStudents
        {
            get { return _registeredStudents; }
            set { _registeredStudents = value; }
        }

        private Result[] _results;

        public Result[] Results
        {
            get { return _results; }
            set { _results = value; }
        }

        private Notice _notices;

        public Notice Notices
        {
            get { return _notices; }
            set { _notices = value; }
        }

    }
}
