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
    public partial class Add_Teacher : Form
    {
        public Add_Teacher()
        {
            InitializeComponent();
            
        }
        Teacher teacher;
        // Minimize Button
        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void Email_tb_Load(object sender, EventArgs e)
        {

        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            Random randomNum = new Random();
            int num = randomNum.Next(1, 100);
        }
    }
}
