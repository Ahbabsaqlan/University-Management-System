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
    internal partial class Search_tab : UserControl
    {
        bool flag=false;
        Teacher teacher;
        Student student;
        public Search_tab(Student stu)
        {
            student = stu;
            InitializeComponent();
            Name_lb.Text=student.FirstName+" "+student.LastName;
            ID_lb.Text=student.ID;
            Image_bx.Image = Image.FromStream(student.Images);
        }
        public Search_tab(Teacher stu)
        {
            teacher = stu;
            InitializeComponent();
            Name_lb.Text = teacher.FirstName + " " + teacher.LastName;
            ID_lb.Text = teacher.ID;
            Image_bx.Image = Image.FromStream(teacher.Images);
            flag = true;
        }

        private void Search_tab_Click(object sender, EventArgs e)
        {
            if (flag==true)
            {
                Admin_Profile show = new Admin_Profile(teacher);
                show.Show();
                this.Parent.Hide();
            }
            else
            {
                Admin_Profile show = new Admin_Profile(student);
                show.Show();
                this.Parent.Hide();
                
            }
           
        }
    }
}
