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
        Admin User;
        public Admin_Profile()
        {
            User = DashBoard.admin;
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
            Update_Form_Container.Hide();
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

        private void Update_lb_Click(object sender, EventArgs e)
        {
            Update_Form_Container.Show();
            MessageBox.Show("PLEASE ENTER INFO CAREFULLY...!");
            Profile_picture.Hide();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if(FirstName_tb.gettxt() is null && LastName_tb.gettxt() is null&& Email_tb.gettxt() is null&&MotherName_tb.gettxt() is null&& FatherName_tb.gettxt() is null&& NID_tb.gettxt() is null&& House_tb.gettxt() is null&& Road_tb.gettxt()  is null&& Area_tb.gettxt() is null&& City_tb.gettxt() is null&& Position_cmbx.SelectedItem is null)
            {
                MessageBox.Show("PLEASE ENTER WHAT DO YOU WANT TO UPDATE...!");
            }
            else
            {
                if (!(FirstName_tb.gettxt() is null))
                {
                    User.FirstName = FirstName_tb.gettxt();
                }
                if (!(LastName_tb.gettxt() is null))
                {
                    User.LastName = LastName_tb.gettxt();
                }
                if (!(Email_tb.gettxt() is null))
                {
                    User.Email = Email_tb.gettxt();
                }
                if (!(MotherName_tb.gettxt() is null))
                {
                    User.MotherName = MotherName_tb.gettxt();
                }
                if (!(FatherName_tb.gettxt() is null))
                {
                    User.FatherName = FatherName_tb.gettxt();
                }
                if (!(NID_tb.gettxt() is null))
                {
                    User.NID = NID_tb.gettxt();
                }
                if (!(House_tb.gettxt() is null))
                {
                    User.Address.House = House_tb.gettxt();
                }
                if (!(Road_tb.gettxt() is null))
                {
                    User.Address.Road = Road_tb.gettxt();
                }
                if (!(Area_tb.gettxt() is null))
                {
                    User.Address.Area = Area_tb.gettxt();
                }
                if (!(City_tb.gettxt() is null))
                {
                    User.Address.City = City_tb.gettxt();
                }
                if (!(Position_cmbx.SelectedItem is null))
                {
                    User.Position = (string)Position_cmbx.SelectedItem;
                }
                //if (!(DOB_pkr.ValueChanged == false))
                //{
                //    User.Position = (string)Position_cmbx.SelectedItem;

                DashBoard.admin = User;
                DashBoard.admin.updateInfo(User);
                MessageBox.Show("INOFORMATION UPDATED SUCCESSFULLY...");
                Admin_Profile admin_Profile = new Admin_Profile();
                admin_Profile.Show();
                this.Hide();
            }
        }

        private void Admin_Profile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uNIVERSITY_MANAGEMENT_CITYDataSet.LOGIN' table. You can move, or remove it, as needed.
            this.lOGINTableAdapter.Fill(this.uNIVERSITY_MANAGEMENT_CITYDataSet.LOGIN);

        }
    }
}
