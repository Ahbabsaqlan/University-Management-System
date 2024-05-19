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
    internal partial class Admin_Profile : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_CITY;Integrated Security=True;");
        Admin User;
        Student User1;
        Teacher User2;
        string type = null;
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
            type = "admin";
        }
        public Admin_Profile(Student User)
        {
            User1 = User;
            User.getCoursesInfo();
            InitializeComponent();
            Change_pass.Hide();
            Positon_lb.Text = "Program";
            User.Programs.Facultys.getPrograms();
            Position_cmbx.Items.Clear();
            for (int i = 0; i < User.Programs.Facultys.Programs.Length; i++)
            {
                Position_cmbx.Items.Add(User.Programs.Facultys.Programs[i].ProgramName);
            }
            //Info_Container.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            Profile_picture.Image = Image.FromStream(User.Images);
            Profile_Name_lb.Text = "Hey..." + User.FirstName + " " + User.LastName;
            label1.Text = "ID                     : " + User.ID;
            label2.Text = "Program           : " + User.Programs.ProgramName;
            label3.Text = "Email               : " + User.Email;
            label4.Text = "Credit Completed      : " + User.CreditComplete;
            label5.Text = "DOB                : " + User.DOB.Day + "/" + User.DOB.Month + "/" + User.DOB.Year;
            label6.Text = "CGPA               : " + User.CGPA;
            //Info_Container.Controls.Add(new Label() { Text="Credit Completed:      "+User.CreditComplete},0,6);
            label7.Text = "Father Name  : " + User.FatherName;
            label8.Text = "Mother Name : " + User.MotherName;
            label9.Text = "Address          : " + "House/" + User.Address.House + "   Road: " + User.Address.Road + "   Area:" + User.Address.Area + "   City:" + User.Address.City;
            Change_btn.Hide();
            Pass_Change_tb.Hide();
            Update_Form_Container.Hide();
            type="student";
        }

        public Admin_Profile(Teacher User)
        {
            User2= User;
            InitializeComponent();
            Change_pass.Hide();
            //Info_Container.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            Profile_picture.Image = Image.FromStream(User.Images);
            Profile_Name_lb.Text = "Hey..." + User.FirstName + " " + User.LastName;
            label1.Text = "ID                     : " + User.ID;
            label2.Text = "Department           : " + User.DepartMents.DepartmentName;
            label3.Text = "Email               : " + User.Email;
            label4.Text = "Mobile             : " + User.Mobile;
            label5.Text = "DOB                : " + User.DOB.Day + "/" + User.DOB.Month + "/" + User.DOB.Year;
            label6.Text = "Position               : " + User.Position;
            //Info_Container.Controls.Add(new Label() { Text = "NID:      " + User.NID }, 6, 0);
            label7.Text = "Father Name  : " + User.FatherName;
            label8.Text = "Mother Name : " + User.MotherName;
            label9.Text = "Address          : " + "House/" + User.Address.House + "   Road: " + User.Address.Road + "   Area:" + User.Address.Area + "   City:" + User.Address.City;
            Change_btn.Hide();
            Pass_Change_tb.Hide();
            Update_Form_Container.Hide();
            type = "teacher";
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
            if (type is "student")
            {
                if (FirstName_tb.gettxt() is "" && LastName_tb.gettxt() is "" && Email_tb.gettxt() is "" && MotherName_tb.gettxt() is "" && FatherName_tb.gettxt() is "" && NID_tb.gettxt() is "" && House_tb.gettxt() is "" && Road_tb.gettxt() is "" && Area_tb.gettxt() is "" && City_tb.gettxt() is "" && Position_cmbx.SelectedItem is "" )
                {
                    MessageBox.Show("PLEASE ENTER WHAT DO YOU WANT TO UPDATE...!");
                }
                else
                {
                    if(int.TryParse(Day_tb.Text, out _) || int.TryParse(Month_tb.Text, out _) || int.TryParse(Year_tb.Text, out _))
                    {
                        if (!(FirstName_tb.gettxt() is ""))
                        {
                            User1.FirstName = FirstName_tb.gettxt();
                        }
                        if (!(LastName_tb.gettxt() is ""))
                        {
                            User1.LastName = LastName_tb.gettxt();
                        }
                        if (!(Email_tb.gettxt() is ""))
                        {
                            User1.Email = Email_tb.gettxt();
                        }
                        if (!(MotherName_tb.gettxt() is ""))
                        {
                            User1.MotherName = MotherName_tb.gettxt();
                        }
                        if (!(FatherName_tb.gettxt() is ""))
                        {
                            User1.FatherName = FatherName_tb.gettxt();
                        }
                        if (!(NID_tb.gettxt() is ""))
                        {
                            User1.NID = NID_tb.gettxt();
                        }
                        if (!(House_tb.gettxt() is ""))
                        {
                            User1.Address.House = House_tb.gettxt();
                        }
                        if (!(Road_tb.gettxt() is ""))
                        {
                            User1.Address.Road = Road_tb.gettxt();
                        }
                        if (!(Area_tb.gettxt() is ""))
                        {
                            User1.Address.Area = Area_tb.gettxt();
                        }
                        if (!(City_tb.gettxt() is ""))
                        {
                            User1.Address.City = City_tb.gettxt();
                        }

                        if (!(Position_cmbx.SelectedItem is ""))
                        {
                            User1.Programs.ProgramName = (string)Position_cmbx.SelectedItem;
                        }
                        if (!(Day_tb.Text is ""))
                        {
                            User1.DOB.Day = Int32.Parse(Day_tb.Text);
                        }
                        if (!(Month_tb.Text is ""))
                        {
                            User1.DOB.Month = Int32.Parse(Month_tb.Text);
                        }
                        if (!(Year_tb.Text is ""))
                        {
                            User1.DOB.Year = Int32.Parse(Year_tb.Text);
                        }
                        

                        DashBoard.admin.updateInfo(User1);
                        MessageBox.Show("INOFORMATION UPDATED SUCCESSFULLY...");
                        Admin_Profile admin_Profile = new Admin_Profile();
                        admin_Profile.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Neumeric Value for Date OF Birth...");
                    }
                }  
            }
            else if(type is "admin")
            {
                if (FirstName_tb.gettxt() is "" && LastName_tb.gettxt() is "" && Email_tb.gettxt() is "" && MotherName_tb.gettxt() is "" && FatherName_tb.gettxt() is "" && NID_tb.gettxt() is "" && House_tb.gettxt() is "" && Road_tb.gettxt() is "" && Area_tb.gettxt() is "" && City_tb.gettxt() is "" && Position_cmbx.SelectedItem is "" )
                {
                    MessageBox.Show("PLEASE ENTER WHAT DO YOU WANT TO UPDATE...!");
                }
                else
                {
                    if (int.TryParse(Day_tb.Text, out _) || int.TryParse(Month_tb.Text, out _) || int.TryParse(Year_tb.Text, out _))
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
                        if (!(Day_tb.Text is ""))
                        {
                            User.DOB.Day = Int32.Parse(Day_tb.Text);
                        }
                        if (!(Month_tb.Text is ""))
                        {
                            User.DOB.Month = Int32.Parse(Month_tb.Text);
                        }
                        if (!(Year_tb.Text is ""))
                        {
                            User.DOB.Year = Int32.Parse(Year_tb.Text);
                        }
                        
                        DashBoard.admin.updateInfo(User);
                        MessageBox.Show("INOFORMATION UPDATED SUCCESSFULLY...");
                        Admin_Profile admin_Profile = new Admin_Profile();
                        admin_Profile.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Neumeric Value for Date OF Birth...");
                    }
                }
            }
            else
            {
                if (FirstName_tb.gettxt() is "" && LastName_tb.gettxt() is "" && Email_tb.gettxt() is "" && MotherName_tb.gettxt() is "" && FatherName_tb.gettxt() is "" && NID_tb.gettxt() is "" && House_tb.gettxt() is "" && Road_tb.gettxt() is "" && Area_tb.gettxt() is "" && City_tb.gettxt() is "" && Position_cmbx.SelectedItem is "")
                {
                    MessageBox.Show("PLEASE ENTER WHAT DO YOU WANT TO UPDATE...!");
                }
                else
                {
                    if (int.TryParse(Day_tb.Text, out _) || int.TryParse(Month_tb.Text, out _) || int.TryParse(Year_tb.Text, out _))
                    {
                        if (!(FirstName_tb.gettxt() is null))
                        {
                            User2.FirstName = FirstName_tb.gettxt();
                        }
                        if (!(LastName_tb.gettxt() is null))
                        {
                            User2.LastName = LastName_tb.gettxt();
                        }
                        if (!(Email_tb.gettxt() is null))
                        {
                            User2.Email = Email_tb.gettxt();
                        }
                        if (!(MotherName_tb.gettxt() is null))
                        {
                            User2.MotherName = MotherName_tb.gettxt();
                        }
                        if (!(FatherName_tb.gettxt() is null))
                        {
                            User2.FatherName = FatherName_tb.gettxt();
                        }
                        if (!(NID_tb.gettxt() is null))
                        {
                            User2.NID = NID_tb.gettxt();
                        }
                        if (!(House_tb.gettxt() is null))
                        {
                            User2.Address.House = House_tb.gettxt();
                        }
                        if (!(Road_tb.gettxt() is null))
                        {
                            User2.Address.Road = Road_tb.gettxt();
                        }
                        if (!(Area_tb.gettxt() is null))
                        {
                            User2.Address.Area = Area_tb.gettxt();
                        }
                        if (!(City_tb.gettxt() is null))
                        {
                            User2.Address.City = City_tb.gettxt();
                        }
                        if (!(Position_cmbx.SelectedItem is null))
                        {
                            User2.Position = (string)Position_cmbx.SelectedItem;
                        }
                        if (!(Day_tb.Text is ""))
                        {
                            User2.DOB.Day = Int32.Parse(Day_tb.Text);
                        }
                        if (!(Month_tb.Text is ""))
                        {
                            User2.DOB.Month = Int32.Parse(Month_tb.Text);
                        }
                        if (!(Year_tb.Text is ""))
                        {
                            User2.DOB.Year = Int32.Parse(Year_tb.Text);
                        }

                        DashBoard.admin.updateInfo(User2);
                        MessageBox.Show("INOFORMATION UPDATED SUCCESSFULLY...");
                        Admin_Profile admin_Profile = new Admin_Profile();
                        admin_Profile.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Neumeric Value for Date OF Birth...");
                    }
                }
            }
            
        }

        private void Admin_Profile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uNIVERSITY_MANAGEMENT_CITYDataSet.LOGIN' table. You can move, or remove it, as needed.
            this.lOGINTableAdapter.Fill(this.uNIVERSITY_MANAGEMENT_CITYDataSet.LOGIN);

        }
    }
}
