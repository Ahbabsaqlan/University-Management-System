using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    internal class Departments
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANGEMENT_SYSTEM;Integrated Security=True;");
        public Departments(string id) 
        {
            ID = id;
            string departmentData = "select Department_Name,Faculty_ID from DEPARTMENT where Department_ID='" + id + "'";
            SqlDataAdapter adapter1 = new SqlDataAdapter(departmentData, connection);
            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);
            DataRow dr1 = dt1.Rows[0];

            DepartmentName=dr1.Field<string>(0);
            Facultys = new Faculty(dr1.Field<string>(1));
        }

        private string _Id;

        public string ID
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _departmentName;

        public string DepartmentName
        {
            get { return _departmentName; }
            set { _departmentName = value; }
        }

        private Faculty _facultys;

        public Faculty Facultys
        {
            get { return _facultys; }
            set { _facultys = value; }
        }

    }
}
