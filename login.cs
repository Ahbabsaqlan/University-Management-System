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
    public partial class login : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_CITY;Integrated Security=True;");

        Student Students { get; set; }
        Teacher Teachers { get; set; }
        Admin Admins { get; set; }
        public login()
        {
            InitializeComponent();
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            //string id=login_ID_TB.Text;
            ////Fetch Data
            //string query = "select password,role from LOGIN where user_id='" + id + "'";
            //SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //DataRow dr = dt.Rows[0];
            //if(dr.Field<string>(0)== login_Pass_TB.Text && dr.Field<string>(1)=="Admin")
            //{
                Admins = new Admin("ADMIN1");
                DashBoard dashBoard = new DashBoard(Admins);
                dashBoard.Show();
                this.Hide();
            //}

            

            
        }
    }
}
