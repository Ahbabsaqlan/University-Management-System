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
            fst_bnr_Dpt_btn.Hide();
            fst_bnr_Btn_Prgm.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool btnflag= false;
        private void banner_Hover(object sender, EventArgs e)
        {
            Dashboard_FST_Banner.BorderStyle = BorderStyle.FixedSingle;
            fst_bnr_Dpt_btn.Show();
            fst_bnr_Btn_Prgm.Show();
        }
        private void bnr_btn_MHover(object sender, EventArgs e)
        {      
            btnflag = true;
            fst_bnr_Dpt_btn.Show();
            fst_bnr_Btn_Prgm.Show();
        }

        private void Dashboard_FST_Banner_MouseLeave(object sender, EventArgs e)
        {
            Dashboard_FST_Banner.BorderStyle = BorderStyle.None;
            if (btnflag == false)
            {
                fst_bnr_Dpt_btn.Hide();
                fst_bnr_Btn_Prgm.Hide();
            }
        }

        private void bnr_btn_Mleave(object sender, EventArgs e)
        {
            Dashboard_FST_Banner.BorderStyle = BorderStyle.FixedSingle;
            btnflag= false;
        }

        private void fst_bnr_Dpt_btn_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
