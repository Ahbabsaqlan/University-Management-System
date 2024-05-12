using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace University_Management_System
{

    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NHRHLTK;Initial Catalog=UNIVERSITY_MANAGEMENT_SYSTEM;Integrated Security=True");

        private void User_Text_Box_MouseClick(object sender, MouseEventArgs e)
        {
            if (User_Text_Box.Text == "User ID")
            {
                User_Text_Box.Text = " ";
                User_Text_Box.ForeColor = Color.Black;
            }
        }
        private void Password_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Password_TextBox.Text == "Password")
            {
                Password_TextBox.Text = " ";
                Password_TextBox.ForeColor = Color.Black;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            string query = "select role from LOGIN where user_id='" + User_Text_Box.Text + "'and password ='" + Password_TextBox.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection); //query executed
            connection.Open();
            DataTable dt = new DataTable(); //dynamic table 
            sda.Fill(dt);
            //string ss="select role from dt where user_id='"+ User_Text_Box.Text+"'";

            if (dt.Rows.Count == 1)
            {
                foreach (DataRow r in dt.Rows)
                {
                    foreach(var roles in r.ItemArray)
                    {
                        string userrole=(string)roles;
                        if (userrole == "Lecturer")
                        {
                            Student_dashboard st_dash = new Student_dashboard();
                            this.Hide();
                            st_dash.Show();
                        }
                       
                    }
                }

                
            }
            connection.Close();

            //string query= "select role from LOGIN where user_id='" + User_Text_Box.Text + "'and password ='" + Password_TextBox.Text + "'";




        }

        private void Password_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
