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
    internal partial class Program_Show : UserControl
    {
        public Program_Show()
        {
            InitializeComponent();
        }

        private Program _programss;

        public Program Programss
        {
            get { return _programss; }
            set { _programss = value; }
        }

        public void showProgramCourses()
        {
            Pgrm_Label.Text = Programss.ProgramName;
        }

        private void Pgrm_Crs_btn_Click(object sender, EventArgs e)
        {
            Program_Course program_Course = new Program_Course(Programss);
            program_Course.Show();
            this.Parent.Hide();
        }

        private void Enrl_Std_btn_Click(object sender, EventArgs e)
        {
            Teacher_List student_List = new Teacher_List(Programss);
            student_List.Show();
            this.Parent.Hide();
        }

        //public string ProgramName 
        //{
        //    get { return ProgramName; }  set { Pgrm_Label.Text = value; } 
        //}
    }
}
