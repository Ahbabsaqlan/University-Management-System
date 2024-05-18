using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    internal class Curriculum
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_CITY;Integrated Security=True;");
        public Curriculum(string id) 
        {
            string Data = "select Course_ID from CURRICULUM where Program_ID='" + id + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(Data, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int index=0;
            CurricullumCourses = new Course[dt.Rows.Count];
            foreach (DataRow data in dt.Rows)
            {
                foreach(var ids in data.ItemArray)
                {
                    CurricullumCourses[index] = new Course(ids.ToString());
                    index++;
                }
                
            }
            Program.TotalCourse=dt.Rows.Count;
        }

        private Course[] _curricullum;

        public Course[] CurricullumCourses
        {
            get { return _curricullum; }
            set { _curricullum = value; }
        }

    }
}
