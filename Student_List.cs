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
    public partial class Student_List : Form
    {
        public Student_List()
        {
            InitializeComponent();
            show();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {

        }

        private void show()
        {
            Show_Students[] pg = new Show_Students[2];
            for (int i = 0; i < pg.Length; i++)
            {
                pg[i] = new Show_Students();
                Students_List_Panel.Controls.Add(pg[i]);
            }
        }

        private void Students_List_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
