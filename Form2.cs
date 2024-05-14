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

           // for routine

           string query1 = "select * from SECTION where Student_ID='" + login_id + "' and Day='sunday-tuesday'";
           SqlDataAdapter sda1 = new SqlDataAdapter(query1, connection); //query executed
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            // for sunday and tuesday section
            linkSunday1.Hide(); linkSunday2.Hide(); linkSunday3.Hide(); linkSunday4.Hide(); linkSunday5.Hide();
            linkTuesday5.Hide(); linkTuesday4.Hide(); linkTuesday3.Hide(); linkTuesday2.Hide(); linkTuesday1.Hide();
            int count = 0;
            foreach (DataRow r1 in dt1.Rows)
            {
                count++;
                if (count == 1 && r1.Field<string>(8) == "sunday-tuesday")
                {
                    linkTuesday1.Text = linkSunday1.Text = r1.Field<string>(9) + "[" + r1.Field<string>(1) + "] (" + r1.Field<string>(3) + ") -" + r1.Field<string>(4);
                    linkSunday1.Show();
                    linkTuesday1.Show();
                }
                else if (count == 2 && r1.Field<string>(8) == "sunday-tuesday")
                {
                    linkTuesday2.Text = linkSunday2.Text = r1.Field<string>(9) + "[" + r1.Field<string>(1) + "] (" + r1.Field<string>(3) + ") -" + r1.Field<string>(4);
                    linkSunday2.Show();
                    linkTuesday2.Show();
                }
                else if (count == 3 && r1.Field<string>(8) == "sunday-tuesday")
                {
                    linkTuesday3.Text = linkSunday3.Text = r1.Field<string>(9) + "[" + r1.Field<string>(1) + "] (" + r1.Field<string>(3) + ") -" + r1.Field<string>(4);
                    linkSunday3.Show();
                    linkTuesday3.Show();
                }
                else if (count == 4 && r1.Field<string>(8) == "sunday-tuesday")
                {
                    linkTuesday4.Text = linkSunday4.Text = r1.Field<string>(9) + "[" + r1.Field<string>(1) + "] (" + r1.Field<string>(3) + ") -" + r1.Field<string>(4);
                    linkSunday4.Show();
                    linkTuesday4.Show();
                }
                else if (count == 5 && r1.Field<string>(8) == "sunday-tuesday")
                {
                    linkTuesday5.Text = linkSunday5.Text = r1.Field<string>(9) + "[" + r1.Field<string>(1) + "] (" + r1.Field<string>(3) + ") -" + r1.Field<string>(4);
                    linkSunday5.Show();
                    linkTuesday5.Show();
                }

            }

           // for monday and wednesday
            string query2 = "select * from SECTION where Student_ID='" + login_id + "' and Day='monday-wednesday'";
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, connection); //query executed
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            linkMonday1.Hide(); linkMonday2.Hide(); linkMonday3.Hide(); linkMonday4.Hide(); linkMonday5.Hide();
            linkwednesday1.Hide(); linkwednesday2.Hide(); linkwednesday3.Hide(); linkwednesday4.Hide(); linkwednesday5.Hide();
            int count1 = 0;
            foreach (DataRow r2 in dt2.Rows)
            {
                count1++;
                if (count1 == 1 && r2.Field<string>(8) == "monday-wednesday")
                {
                    linkMonday1.Text = linkwednesday1.Text = r2.Field<string>(9) + "[" + r2.Field<string>(1) + "] (" + r2.Field<string>(3) + ") -" + r2.Field<string>(4);
                    linkMonday1.Show();
                    linkwednesday1.Show();
                }
                else if (count1 == 2 && r2.Field<string>(8) == "monday-wednesday")
                {
                    linkMonday2.Text = linkwednesday2.Text = r2.Field<string>(9) + "[" + r2.Field<string>(1) + "] (" + r2.Field<string>(3) + ") -" + r2.Field<string>(4);
                    linkMonday2.Show();
                    linkwednesday2.Show();
                }
                else if (count1 == 3 && r2.Field<string>(8) == "monday-wednesday")
                {
                    linkMonday3.Text = linkwednesday3.Text = r2.Field<string>(9) + "[" + r2.Field<string>(1) + "] (" + r2.Field<string>(3) + ") -" + r2.Field<string>(4);
                    linkMonday3.Show();
                    linkwednesday3.Show();
                }
                else if (count1 == 4 && r2.Field<string>(8) == "monday-wednesday")
                {
                    linkMonday4.Text = linkwednesday4.Text = r2.Field<string>(9) + "[" + r2.Field<string>(1) + "] (" + r2.Field<string>(3) + ") -" + r2.Field<string>(4);
                    linkMonday4.Show();
                    linkwednesday4.Show();
                }
                else if (count1 == 5 && r2.Field<string>(8) == "monday-wednesday")
                {
                    linkMonday5.Text = linkwednesday5.Text = r2.Field<string>(9) + "[" + r2.Field<string>(1) + "] (" + r2.Field<string>(3) + ") -" + r2.Field<string>(4);
                    linkMonday5.Show();
                    linkwednesday5.Show();
                }
            }

            string query3 = "select * from SECTION where Student_ID='" + login_id + "'";
            SqlDataAdapter sda3 = new SqlDataAdapter(query3, connection); //query executed
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);

            int cnt = 0;
            foreach(DataRow r3 in dt3.Rows)
            {
                cnt++;
                if(cnt == 1)
                {
                    course1.Text = r3.Field<string>(9);
                    room1.Text="Room:-  "+ r3.Field<string>(4);
                    time1.Text="Time:-  "+ r3.Field<string>(3);
                }
                else if (cnt == 2)
                {
                    course2.Text = r3.Field<string>(9);
                    room2.Text = "Room:-  " + r3.Field<string>(4);
                    time2.Text = "Time:-  " + r3.Field<string>(3);
                }
                else if (cnt == 3)
                {
                    course3.Text = r3.Field<string>(9);
                    room3.Text = "Room:-  " + r3.Field<string>(4);
                    time3.Text = "Time:-  " + r3.Field<string>(3);
                }
                else if (cnt == 4)
                {
                    course4.Text = r3.Field<string>(9);
                    room4.Text = "Room:-  " + r3.Field<string>(4);
                    time4.Text = "Time:-  " + r3.Field<string>(3);
                }
                else if (cnt == 5)
                {
                    course5.Text = r3.Field<string>(9);
                    room5.Text = "Room:-  " + r3.Field<string>(4);
                    time5.Text = "Time:-  " + r3.Field<string>(3);
                }
                else if (cnt == 6)
                {
                    course6.Text = r3.Field<string>(9);
                    room6.Text = "Room:-  " + r3.Field<string>(4);
                    time6.Text = "Time:-  " + r3.Field<string>(3);
                }

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
