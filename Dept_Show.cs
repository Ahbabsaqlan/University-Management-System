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
    public partial class Dept_Show : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_SYSTEM 2;Integrated Security=True;");
        DataRow r = null;
        public Dept_Show(string name)
        {
            InitializeComponent();
            Dept_Name_Label.Text = name;
            //Fetch Data
            string query = "select Department_ID from DEPARTMENT where Department_Name='" + name + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            r = dt.Rows[0];

        }

        private void Dept_ShowCourse_btn_Click(object sender, EventArgs e)
        {
            Program_Course program_Course = new Program_Course(r.Field<string>(0));
            Department.ActiveForm.Hide();
            program_Course.Show();
        }

        private void Dept_ShowTeacher_btn_Click(object sender, EventArgs e)
        {
            Student_List student_List = new Student_List(r.Field<string>(0));
            Department.ActiveForm.Hide();
            student_List.Show();
        }
    }
}
