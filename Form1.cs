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

        int User_ID_count = 0;
        private void User_Text_Box_MouseClick(object sender, MouseEventArgs e)
        {
           
            User_Text_Box.Enabled = true;
            if (User_Text_Box.Text == "User ID" && User_ID_count==0)
            {
                User_Text_Box.Text = " ";
                User_Text_Box.ForeColor = Color.Black;
                User_ID_count++;
            }
        }

        int Password_count = 0;
        private void Password_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (Password_TextBox.Text == "Password" && Password_count==0)
            {
                Password_TextBox.Text = " ";
                Password_TextBox.ForeColor = Color.Black;
                Password_count++;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            string query = "select * from LOGIN where user_id='" + User_Text_Box.Text + "'and password ='" + Password_TextBox.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection); //query executed
           // connection.Open();
            DataTable dt = new DataTable(); //dynamic table 
            sda.Fill(dt);
            //string ss="select role from dt where user_id='"+ User_Text_Box.Text+"'";

            if (dt.Rows.Count == 1)
            {
                foreach (DataRow r in dt.Rows)
                {
                    // foreach(var rol in r.ItemArray)
                    //{
                    string userrole = r.Field<string>(2);
                    //string userrole=(string)rol;
                    if (userrole == "student")
                        {
                            Student_dashboard st_dash = new Student_dashboard(User_Text_Box.Text);
                            this.Hide();
                            st_dash.Show();
                        }
                        else if (userrole == "Admin")
                        {
                            Student_dashboard st_dash = new Student_dashboard(User_Text_Box.Text);
                            this.Hide();
                            st_dash.Show();
                        }
                        else if (userrole == "Lecturer")
                        {
                            Student_dashboard st_dash = new Student_dashboard(User_Text_Box.Text);
                            this.Hide();
                            st_dash.Show();
                        }
                        else if (userrole == "CS_Head")
                        {
                            Student_dashboard st_dash = new Student_dashboard(User_Text_Box.Text);
                            this.Hide();
                            st_dash.Show();
                        }


                   // }
                }
            }
            else if(User_Text_Box.Text ==" " || Password_TextBox.Text==" ")
            {
                MessageBox.Show("Please write your ID and Password");
            }
            else
            {
                MessageBox.Show("Wrong Credentials!!\n Please Try Again");
            }
            connection.Close();

            //string query= "select role from LOGIN where user_id='" + User_Text_Box.Text + "'and password ='" + Password_TextBox.Text + "'";




        }


        private void Login1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
