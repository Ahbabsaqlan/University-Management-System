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
    public partial class Program_Course : Form
    {
        public Program_Course(string dept)
        {
            InitializeComponent();
            show();
        }
        private void show()
        {
            Show_Course[] pg = new Show_Course[2];
            for (int i = 0; i < pg.Length; i++)
            {
                pg[i] = new Show_Course();
                Course_LIst.Controls.Add(pg[i]);
            }
        }

        private void Adt_Head_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void layout1_Load(object sender, EventArgs e)
        {

        }
    }
}
