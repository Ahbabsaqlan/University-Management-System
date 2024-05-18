using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    internal class RegisteredStudent
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_CITY;Integrated Security=True;");
        public RegisteredStudent(string id) 
        {
            //Fetch Data
            string studentData = "select Student_ID from Registered_Students where Section_ID='" + id + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(studentData, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);   
            if (dt.Rows.Count > 0)
            {
                Students = new Student[dt.Rows.Count];
                int index = 0;
                foreach (DataRow data in dt.Rows)
                {
                    foreach (var ids in data.ItemArray)
                    {
                        Students[index] = new Student(ids.ToString());
                        index++;
                    }
                }
            }
            else
            {
                Students = new Student[dt.Rows.Count];
            }
            
        }

        private Student[] _students;

        public Student[] Students
        {
            get { return _students; }
            set { _students = value; }
        }

        
    }
}
