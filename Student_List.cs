using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management_System
{
    public partial class Student_List : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_SYSTEM 2;Integrated Security=True;");
        public Student_List(string dept)
        {
            InitializeComponent();
            //Data Fetch
            string query1 = "select First_Name,Last_Name,Teacher_ID  from TEACHER  where Department_ID='" + dept + "'";
            SqlDataAdapter adapter1 = new SqlDataAdapter(query1, connection);
            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);

            Show_Students[] pg = new Show_Students[dt1.Rows.Count];
            int i = 0;
            foreach (DataRow r in dt1.Rows)
            {
                pg[i] = new Show_Students(r.Field<string>(0), r.Field<string>(1), r.Field<string>(2));
                Students_List_Panel.Controls.Add(pg[i]);
                i++;
            }
            
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {

        }

        

        private void Students_List_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
