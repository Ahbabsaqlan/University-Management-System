using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace University_Management_System
{
    public partial class Student_dashboard : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NHRHLTK;Initial Catalog=UNIVERSITY_MANAGEMENT_SYSTEM;Integrated Security=True");

        private string login_id="";

        
        public Student_dashboard(string n)
        {
            this.login_id = n;
            InitializeComponent();
        }
        private void Student_dashboard_Load(object sender, EventArgs e)
        {
            string query = "select * from STUDENT where Student_ID='" + login_id + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection); //query executed
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow r in dt.Rows)
            {
                 Profile_link.Text = r.Field<string>(1);
    
            }
        }

        private void Profile_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProfileShow pfs = new ProfileShow(login_id);
            this.Hide();
            pfs.Show();

        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Login1 log = new Login1();
            this.Hide();
            log.Show();
        }
    }
}
