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
    public partial class Add_Student : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_CITY;Integrated Security=True;");
        Student person = new Student();
        public Add_Student()
        {
            InitializeComponent();
            
        }
        
        
        
        // Minimize Button
        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        //

        private int idGenerator()
        {
            Random randomNum = new Random();
            int num = randomNum.Next(10, 99);
            return num;
        }
        private int idGenerator1()
        {
            Random randomNum = new Random();
            int num = randomNum.Next(10000, 99999);
            return num;
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            person.FirstName = FirstName_tb.Text;
            person.LastName = LastName_tb.Text;
            person.Email = Email_tb.Text;
            person.NID = NID_tb.Text;
            person.FatherName = FatherName_tb.Text;
            person.MotherName = MotherName_tb.Text;
            person.Mobile = Mobile_tb.Text;

            bool flag = false;
            while (flag == false)
            {
                Random randomNum1 = new Random();
                int num1 = randomNum1.Next(1, 3);
                string id = idGenerator() + "-" + idGenerator1() + "-" + num1;
                person.ID = id;

                string Data = "select user_id from LOGIN where user_id='" + id + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(Data, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    flag = true;
                }
            }


            if (!(path.Text == "" || FirstName_tb.Text == "" || LastName_tb.Text == "" || Email_tb.Text == "" || NID_tb.Text == "" || FatherName_tb.Text == "" || MotherName_tb.Text == "" ||  Mobile_tb.Text == "" ||  Department_cmbx.Text == "" ||
                House_tb.Text == "" || Road_tb.Text == "" || Area_tb.Text == "" || City_tb.Text == "" || Day_tb.Text == "" || Month_tb.Text == "" || Year_tb.Text == "") && (int.TryParse(Day_tb.Text, out _) || int.TryParse(Month_tb.Text, out _) || int.TryParse(Year_tb.Text, out _)))
            {

                byte[] fileBytes = System.IO.File.ReadAllBytes(path.Text);
                Random randomNum = new Random();
                int num = randomNum.Next(1000, 9999);
                string query;
                int result = 0;
                query = "insert into STUDENT (Photo,Student_ID,First_Name,Last_Name,Email,NID,Father_Name,Mother_Name,Mobile,Program_ID,CGPA,Credit_Completed) values (@Photo,@Teacher_ID,@First_Name,@Last_Name,@Email,@NID,@Father_Name,@Mother_Name,@Mobile,@Department_ID,@CGPA,@Credit_Completed)";/*@Password,@Photo,@Department_ID)";*/
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection); //query executed
                cmd.Parameters.AddWithValue("@Teacher_ID", person.ID);
                cmd.Parameters.AddWithValue("@First_Name", person.FirstName);
                cmd.Parameters.AddWithValue("@Last_Name", person.LastName);
                cmd.Parameters.AddWithValue("@Email", person.Email);
                cmd.Parameters.AddWithValue("@NID", person.NID);
                cmd.Parameters.AddWithValue("@Father_Name", person.FirstName);
                cmd.Parameters.AddWithValue("@Mother_Name", person.MotherName);
                cmd.Parameters.AddWithValue("@Mobile", person.Mobile);
                cmd.Parameters.AddWithValue("@Department_ID", Department_cmbx.Text);
                cmd.Parameters.AddWithValue("@Photo", fileBytes);
                cmd.Parameters.AddWithValue("@CGPA", 0.0);
                cmd.Parameters.AddWithValue("@Credit_Completed", 0);
                //cmd.Parameters.AddWithValue("@Last_Name", person.FirstName);
                if (connection.State == ConnectionState.Open)
                {
                    result = cmd.ExecuteNonQuery();

                }

                connection.Close();

                query = "insert into ADDRESS (Person_ID,House,Road,Area,City) values (@Person_ID,@House,@Road,@Area,@City)";
                connection.Open();
                SqlCommand cmd2 = new SqlCommand(query, connection); //query executed
                cmd2.Parameters.AddWithValue("@House", House_tb.Text);
                cmd2.Parameters.AddWithValue("@Road", Road_tb.Text);
                cmd2.Parameters.AddWithValue("@Area", Area_tb.Text);
                cmd2.Parameters.AddWithValue("@City", City_tb.Text);
                cmd2.Parameters.AddWithValue("@Person_ID", person.ID);
                if (connection.State == ConnectionState.Open)
                {
                    result = cmd2.ExecuteNonQuery();
                }
                connection.Close();

                query = "insert into Date_of_Birth (Person_ID,Day,Month,Year) values (@Person_ID,@Day,@Month,@Year)";
                connection.Open();
                SqlCommand cmd3 = new SqlCommand(query, connection); //query executed
                cmd3.Parameters.AddWithValue("@Day", Int32.Parse(Day_tb.Text));
                cmd3.Parameters.AddWithValue("@Month", Int32.Parse(Month_tb.Text));
                cmd3.Parameters.AddWithValue("@Year", Int32.Parse(Year_tb.Text));
                cmd3.Parameters.AddWithValue("@Person_ID", person.ID);
                result = cmd3.ExecuteNonQuery();
                connection.Close();

                query = "insert into LOGIN (user_id,password,role) values (@User,@pass,@role)";
                connection.Open();
                SqlCommand cmd1 = new SqlCommand(query, connection); //query executed
                cmd1.Parameters.AddWithValue("@User", person.ID);
                cmd1.Parameters.AddWithValue("@pass", num);
                cmd1.Parameters.AddWithValue("@role", "Lecturer");
                if (connection.State == ConnectionState.Open)
                {
                    result = cmd1.ExecuteNonQuery();
                }
                connection.Close();
                MessageBox.Show("User Created Successfully.\nUser ID:" + person.ID + "\nUser Password:" + num);
            }
            else
            {
                MessageBox.Show("To User Created Successfully You Have To Insert Value For All The Field OR Inser Data In Correct Formet.e.g.Dates Only Integter");
            }
        }
        private void path_Click(object sender, EventArgs e)
        {
            file.ShowDialog();
            path.Text = file.FileName;
        }
    }
}
