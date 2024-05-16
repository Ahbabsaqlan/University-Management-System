using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    internal class Faculty
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_CITY;Integrated Security=True;");
        public Faculty(string id)
		{
			ID = id;
            string Data = "select Faculty_Name  from FACULTY where Faculty_ID='" + id + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(Data, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow dr = dt.Rows[0];
			FacultyName = dr.Field<string>(0);

        }

		private string _Id;

		public string ID
		{
			get { return _Id; }
			set { _Id = value; }
		}

		private string _facultyName;

		public string FacultyName
		{
			get { return _facultyName; }
			set { _facultyName = value; }
		}
		
	}
}
