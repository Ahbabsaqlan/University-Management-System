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

    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void User_Text_Box_MouseClick(object sender, MouseEventArgs e)
        {
            if (User_Text_Box.Text == "User ID")
            {
                User_Text_Box.Text = " ";
                User_Text_Box.ForeColor = Color.Black;
            }
        }

        private void Password_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Password_TextBox.Text == "Password")
            {
                Password_TextBox.Text = " ";
                Password_TextBox.ForeColor = Color.Black;
            }
        }

        
    }
}
