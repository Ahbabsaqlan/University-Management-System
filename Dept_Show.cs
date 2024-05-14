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
    public partial class Dept_Show : UserControl
    {
        public Dept_Show()
        {
            InitializeComponent();
        }

        private void Dept_ShowCourse_btn_Click(object sender, EventArgs e)
        {
            Program_Course program_Course = new Program_Course();
            program_Course.Show();
            this.Parent.Hide();
        }

        private void Dept_ShowTeacher_btn_Click(object sender, EventArgs e)
        {
            Student_List student_List = new Student_List();
            student_List.Show();
            this.Parent.Hide();
        }
    }
}
