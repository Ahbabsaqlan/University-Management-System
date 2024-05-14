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
using System.IO;
namespace University_Management_System
{
    public partial class ProfileShow : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NHRHLTK;Initial Catalog=UNIVERSITY_MANAGEMENT_SYSTEM;Integrated Security=True");

        public string login_id;
        public ProfileShow(string id)
        {
            this.login_id = id;
            InitializeComponent();
        }

        private void ProfileShow_Load(object sender, EventArgs e)
        {
            string query = "select * from STUDENT where Student_ID='" + login_id + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection); //query executed
            DataTable dt = new DataTable();
            sda.Fill(dt);
         
            foreach (DataRow r in dt.Rows)
            {
                full_name_lbl.Text = r.Field<string>(1) +" "+ r.Field<string>(2);
                label1.Text = "Student ID :  " + r.Field<string>(0);
                label2.Text = "CGPA :  " + r.Field<double>(7);
                label3.Text = "Credit :  " + r.Field<int>(8);
                label4.Text = "Email :  " + r.Field<string>(3);
                label5.Text = "NID :  " + r.Field<string>(4);
                label6.Text = "Father Name :  " + r.Field<string>(5);
                label7.Text = "Mother Name : " + r.Field<string>(6);
                label8.Text = "Mobile :  " + r.Field<string>(9);
                label9.Text = "Password :  " + r.Field<string>(10);
                label10.Text = "Program :  " + r.Field<string>(12);

            }

            var query1 = "select * from STUDENT where Student_ID='" + login_id + "'";
            SqlCommand cmd = new SqlCommand(query, connection); //query executed
            connection.Open();

            var reader = cmd.ExecuteReader();
            while(reader.Read()==true)
            {
                
                byte[] img = (byte[])reader["Photo"];
                if(img == null)
                {
                    Person_photo.Image = null;
                }
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    Person_photo.Image = Image.FromStream(ms);
                }
                
            }
            



        }
        private void Back_Button_Click(object sender, EventArgs e)
        {
            Student_dashboard sd = new Student_dashboard(login_id);
            this.Hide();
            sd.Show();
        }
    }
}
