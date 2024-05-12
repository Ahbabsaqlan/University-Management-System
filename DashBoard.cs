using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management_System
{
    public partial class DashBoard : Form
    {

        public DashBoard()
        {
            InitializeComponent();
            FST_Panel_up.BringToFront();
            FE_Panel_up.BringToFront();
            FBA_Panel_up.BringToFront();
            FASS_Panel_up.BringToFront();
            AddTeacher_btn.Hide();
            AddStudent_btn.Hide();
        }
        // Exit Button
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Minimize Button
        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        // FST Panel Button Control
        bool FST_Flag= false;
        private void FST_Panel_up_MouseEnter(object sender, EventArgs e)
        {
            FST_Panel_up.Hide();
            FST_Panel.Show();
        }
        private void FST_Panel_MouseEnter(object sender, EventArgs e)
        {
            FST_Panel.BorderStyle = BorderStyle.FixedSingle;
        }
        private void FST_Panel_MouseLeave(object sender, EventArgs e)
        {
            FST_Panel.BorderStyle = BorderStyle.None;
            if (FST_Flag == false)
            {
                FST_Panel_up.Show();
                FST_Panel.Hide();
            }
        }
        private void FST_btn_dept_MouseEnter(object sender, EventArgs e)
        {
            FST_Flag = true;
        }
        private void FST_btn_dept_MouseLeave(object sender, EventArgs e)
        {
            FST_Panel.BorderStyle = BorderStyle.FixedSingle;
            FST_Flag = false;
        }
        // FST Button Click
        private void FST_btn_dept_Click(object sender, EventArgs e)
        {
            Department dept = new Department();
            dept.Show();
            this.Hide();
        }
        private void FST_btn_pgrm_Click(object sender, EventArgs e)
        {
            Programs pgrm = new Programs();
            pgrm.Show();
            this.Hide();
        }
        
        //FE Panel Button Control
        bool FE_Flag = false;
        private void FE_Panel_up_MouseEnter(object sender, EventArgs e)
        {
            FE_Panel_up.Hide();
            Fe_Panel.Show();
        }
        private void Fe_Panel_MouseEnter(object sender, EventArgs e)
        {
            Fe_Panel.BorderStyle = BorderStyle.FixedSingle;
        }
        private void Fe_Panel_MouseLeave(object sender, EventArgs e)
        {
            Fe_Panel.BorderStyle = BorderStyle.None;
            if (FE_Flag == false)
            {
                FE_Panel_up.Show();
                Fe_Panel.Hide();
            }
        }
        private void FE_btn_Dept_MouseEnter(object sender, EventArgs e)
        {
            FE_Flag = true;
        }
        private void FE_btn_Dept_MouseLeave(object sender, EventArgs e)
        {
            Fe_Panel.BorderStyle = BorderStyle.FixedSingle;
            FE_Flag = false;
        }
        //FE Button Click
        private void FE_btn_dept_Click(object sender, EventArgs e)
        {
            Department dept = new Department();
            dept.Show();
            this.Hide();
        }
        private void FE_btn_pgrm_Click(object sender, EventArgs e)
        {
            Programs pgrm = new Programs();
            pgrm.Show();
            this.Hide();
        }

        //FBA Panel Button Control
        bool FBA_Flag = false;
        private void FBA_Panel_up_MouseEnter(object sender, EventArgs e)
        {
            FBA_Panel_up.Hide();
            FBA_panel.Show();
        }
        private void FBA_panel_MouseEnter(object sender, EventArgs e)
        {
            FBA_panel.BorderStyle = BorderStyle.FixedSingle;
        }
        private void FBA_panel_MouseLeave(object sender, EventArgs e)
        {
            FBA_panel.BorderStyle = BorderStyle.None;
            if (FBA_Flag == false)
            {
                FBA_Panel_up.Show();
                FBA_panel.Hide();
            }
        }
        private void FBA_btn_dept_MouseEnter(object sender, EventArgs e)
        {
            FBA_Flag = true;
        }
        private void FBA_btn_dept_MouseLeave(object sender, EventArgs e)
        {
            FBA_panel.BorderStyle= BorderStyle.FixedSingle;
            FBA_Flag=false;
        }
        // FBA Button Click
        private void FBA_btn_dept_Click(object sender, EventArgs e)
        {
            Department dept = new Department();
            dept.Show();
            this.Hide();
        }
        private void FBA_btn_pgrm_Click(object sender, EventArgs e)
        {
            Programs pgrm = new Programs();
            pgrm.Show();
            this.Hide();
        }

        // FASS Panel Button Control
        bool FASS_Flag = false;
        private void FASS_Panel_up_MouseEnter(object sender, EventArgs e)
        {
            FASS_Panel_up.Hide();
            FASS_panel.Show();
        }
        private void FASS_panel_MouseEnter(object sender, EventArgs e)
        {
            FASS_panel.BorderStyle = BorderStyle.FixedSingle;
        }
        private void FASS_panel_MouseLeave(object sender, EventArgs e)
        {
            FASS_panel.BorderStyle = BorderStyle.None;
            if (FASS_Flag == false)
            {
                FASS_Panel_up.Show();
                FASS_panel.Hide();
            }
        }
        private void FASS_btn_dept_MouseEnter(object sender, EventArgs e)
        {
            FASS_Flag = true;
        }
        private void FASS_btn_dept_MouseLeave(object sender, EventArgs e)
        {
            FASS_panel.BorderStyle = BorderStyle.FixedSingle;
            FASS_Flag = false;
        }
        //FASS Button Click
        private void FASS_btn_dept_Click(object sender, EventArgs e)
        {
            Department dept = new Department();
            dept.Show();
            this.Hide();
        }
        private void FASS_btn_pgrm_Click(object sender, EventArgs e)
        {
            Programs pgrm = new Programs();
            pgrm.Show();
            this.Hide();
        }

        // Sidebar
        int Nav_btn_Flag=2;
        private void sideber_btn_ctrl()
        {
            if(Nav_btn_Flag %2!=0)
            {
                sideber_btn.BackgroundImage = Properties.Resources.icons8_multiply_35;
                Sidebar.BringToFront();
                Sidebar.Size = new System.Drawing.Size(210, 805);
                Home_btn.Size = new System.Drawing.Size(210, 60);
                Home_btn.Text = "   NOTIFICATION";
                Home_btn.ImageAlign= System.Drawing.ContentAlignment.MiddleLeft;
                Home_btn.Padding = new Padding(10,0,0,0) ;
                AddUser_btn.Size = new System.Drawing.Size(210, 60);
                AddUser_btn.Text = "   ADD USER";
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
            Nav_btn_Flag ++;
            sideber_btn_ctrl();
        }
        // Add User Button Click
        int AddUser_btn_Flag = 2;
        private void addUser_btn_ctrl()
        {
            if(AddUser_btn_Flag%2 != 0)
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
            addUser_btn_ctrl ();
        }

        private void AddStudent_btn_Click(object sender, EventArgs e)
        {
            Add_Student ads= new Add_Student();
            ads.Show();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {

        }

        private void Profile_btn_Click(object sender, EventArgs e)
        {

        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();
        }
    }
}
