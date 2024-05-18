using System;
using System.Collections;
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
    public partial class Admin_Profile : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_CITY;Integrated Security=True;");
        public Admin_Profile()
        {
            Admin User = DashBoard.admin;
            InitializeComponent();
            Profile_picture.Image = Image.FromStream(User.Images);
            Profile_Name_lb.Text="Hey..."+User.FirstName+" "+User.LastName;
            label1.Text = "ID                     : " + User.ID;
            label2.Text = "Position           : " + User.Position;
            label3.Text = "Email               : " + User.Email;
            label4.Text = "Mobile             : " + User.Mobile;
            label5.Text = "DOB                : " + User.DOB.Day+"/"+User.DOB.Month+"/"+User.DOB.Year;
            label6.Text = "NID                  : " + User.NID;
            label7.Text = "Father Name  : " + User.FatherName;
            label8.Text = "Mother Name : " + User.MotherName;
            label9.Text = "Address          : " + "House/" + User.Address.House + "   Road: " + User.Address.Road + "   Area:" + User.Address.Area + "   City:" + User.Address.City;
            Change_btn.Hide();
            Pass_Change_tb.Hide();
        }

        // Minimize Button
        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void Change_pass_Click(object sender, EventArgs e)
        {
            Change_btn.Show();
            Pass_Change_tb.Show();
        }

        private void Change_btn_Click(object sender, EventArgs e)
        {
            if(Pass_Change_tb.Text.Length>=4)
            {
                string query = "update LOGIN set password='" + Pass_Change_tb.Text + "'  where user_id='" + DashBoard.admin.ID + "'";
                SqlCommand cmd14 = new SqlCommand(query, connection); //query executed
                connection.Open();
                int result = cmd14.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("YOUR PASSWORD CHANGED SUCCESSFULLY...");
                Change_btn.Hide();
                Pass_Change_tb.Hide();
            }
            else
            {
                MessageBox.Show("PLEASE ENTER A PASSWORD ATLEAST 4 CHARECTERS...!");
            }
            
        }
    }
}
