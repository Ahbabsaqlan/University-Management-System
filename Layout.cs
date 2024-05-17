using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management_System
{
    internal partial class Layout : UserControl
    {
        //Admin admin { get; set; }
        public Layout()
        {
            InitializeComponent();
            AddTeacher_btn.Hide();
            AddStudent_btn.Hide();

            
        }
        //public void adminholder(Admin admins)
        //{
        //    admin = admins;
        //    InitializeComponent();
        //}
        // Exit Button
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        // Sidebar
        int Nav_btn_Flag = 2;
        private void sideber_btn_ctrl()
        {
            if (Nav_btn_Flag % 2 != 0)
            {
                sideber_btn.BackgroundImage = Properties.Resources.icons8_multiply_35;
                Sidebar.BringToFront();
                Sidebar.Size = new System.Drawing.Size(210, 805);
                Home_btn.Size = new System.Drawing.Size(210, 60);
                Home_btn.Text = "   HOME";
                Home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                Home_btn.Padding = new Padding(10, 0, 0, 0);
                AddUser_btn.Size = new System.Drawing.Size(210, 60);
                AddUser_btn.Text = "  ADD USER";
                AddTeacher_btn.Size = new System.Drawing.Size(210, 60);
                AddTeacher_btn.Text = "   ADD TEACHER";
                AddTeacher_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                AddTeacher_btn.Padding = new Padding(10, 0, 0, 0);
                AddStudent_btn.Size = new System.Drawing.Size(210, 60);
                AddStudent_btn.Text = "   ADD STUDENT";
                AddStudent_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                AddStudent_btn.Padding = new Padding(10, 0, 0, 0);
                Search_btn.Size = new System.Drawing.Size(210, 60);
                Search_btn.Text = "   SEARCH";
                Search_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                Search_btn.Padding = new Padding(9, 0, 0, 0);
                Profile_btn.Size = new System.Drawing.Size(210, 60);
                Profile_btn.Text = "   PROFILE";
                Profile_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                Profile_btn.Padding = new Padding(9, 0, 0, 0);
                Logout_btn.Size = new System.Drawing.Size(210, 60);
                Logout_btn.Text = "   LOGOUT";
                Logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                Logout_btn.Padding = new Padding(9, 0, 0, 0);
            }
            else
            {
                sideber_btn.BackgroundImage = Properties.Resources.icons8_menu_35;
                Sidebar.Size = new System.Drawing.Size(60, 805);
                Home_btn.Size = new System.Drawing.Size(60, 60);
                Home_btn.Text = null;
                Home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                Home_btn.Padding = new Padding(0, 0, 0, 0);
                AddUser_btn.Size = new System.Drawing.Size(60, 60);
                AddUser_btn.Text = null;
                AddTeacher_btn.Size = new System.Drawing.Size(60, 60);
                AddTeacher_btn.Text = null;
                AddTeacher_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                AddTeacher_btn.Padding = new Padding(0, 0, 0, 0);
                AddStudent_btn.Size = new System.Drawing.Size(60, 60);
                AddStudent_btn.Text = null;
                AddStudent_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                AddStudent_btn.Padding = new Padding(0, 0, 0, 0);
                Search_btn.Size = new System.Drawing.Size(60, 60);
                Search_btn.Text = null;
                Search_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                Search_btn.Padding = new Padding(0, 0, 0, 0);
                Profile_btn.Size = new System.Drawing.Size(60, 60);
                Profile_btn.Text = null;
                Profile_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                Profile_btn.Padding = new Padding(0, 0, 0, 0);
                Logout_btn.Size = new System.Drawing.Size(60, 60);
                Logout_btn.Text = null;
                Logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                Logout_btn.Padding = new Padding(0, 0, 0, 0);
            }
        }
        private void sideber_btn_Click(object sender, EventArgs e)
        {
            Nav_btn_Flag++;
            sideber_btn_ctrl();
        }
        // Add User Button Click
        int AddUser_btn_Flag = 2;
        private void addUser_btn_ctrl()
        {
            if (AddUser_btn_Flag % 2 != 0)
            {
                AddTeacher_btn.Show();
                AddStudent_btn.Show();
            }
            else
            {
                AddStudent_btn.Hide();
                AddTeacher_btn.Hide();
            }
        }
        private void AddUser_btn_Click(object sender, EventArgs e)
        {
            AddUser_btn_Flag++;
            addUser_btn_ctrl();
        }

        private void AddStudent_btn_Click(object sender, EventArgs e)
        {
            Add_Student ads = new Add_Student();
            ads.Show();
            this.Parent.Hide();
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard(DashBoard.admin);
            dashBoard.Show();
            this.Parent.Hide();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Parent.Hide();
        }

        private void AddTeacher_btn_Click(object sender, EventArgs e)
        {
            Add_Teacher teacher = new Add_Teacher();
            teacher.Show();
            this.Parent.Hide();
        }

        private void Profile_btn_Click(object sender, EventArgs e)
        {
            Admin_Profile admin_Profile = new Admin_Profile();
            admin_Profile.Show();
            this.Parent.Hide();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            Admin_Search admin_Search = new Admin_Search();
            admin_Search.Show();
        }
    }
}
