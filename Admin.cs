using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace University_Management_System
{
    internal class Admin : Person
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANGEMENT_SYSTEM;Integrated Security=True;");
        public Admin(string id) 
		{
			ID = id;
            //Fetch Data
            string query = "select First_Name,Last_Name,Father_Name,Mother_Name,Email,Mobile,NID,Position from ADMIN where Admin_ID='" + id + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
			DataRow dr = dt.Rows[0];
			setval(dr.Field<string>(0), dr.Field<string>(1), dr.Field<string>(2), dr.Field<string>(3), dr.Field<string>(4), dr.Field<string>(5), dr.Field<string>(6));
			Position=dr.Field<string>(7);
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

	}
}
