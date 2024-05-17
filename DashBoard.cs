using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management_System
{
    internal partial class DashBoard : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_SYSTEM 2;Integrated Security=True;");
        public DashBoard(Student students)
        {
            InitializeComponent();
            FST_Panel_up.BringToFront();
            FE_Panel_up.BringToFront();
            FBA_Panel_up.BringToFront();
            FASS_Panel_up.BringToFront();
            st = students;
            label1.Text = st.FirstName;
        }
        Student st;
        

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
            Department dept = new Department("FST");
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
            Department dept = new Department("FE");
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
            Department dept = new Department("FBA");
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
            Department dept = new Department("FASS");
            dept.Show();
            this.Hide();
        }
        private void FASS_btn_pgrm_Click(object sender, EventArgs e)
        {
            Programs pgrm = new Programs();
            pgrm.Show();
            this.Hide();
        }
    }
}
