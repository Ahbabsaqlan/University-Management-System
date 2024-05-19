using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management_System
{
    internal partial class Show_Students : UserControl
    {
        public Show_Students(Person person)
        {
            Persons = person;
            InitializeComponent();
            Person_First_Name.Text = Persons.FirstName+" "+ Persons.LastName;
            Person_ID.Text = Persons.ID;
            Person_Image.Image = Image.FromStream(Persons.Images);

        }

        private Person _persons;

        public Person Persons
        {
            get { return _persons; }
            set { _persons = value; }
        }


        private void Show_Students_Click(object sender, EventArgs e)
        {
            if(Persons.ID.Substring(2,1) == "-")
            {
                Student student = new Student(Persons.ID);
                Admin_Profile admin_Profile = new Admin_Profile(student);
                admin_Profile.Show();
                this.Hide();
            }
            else
            {
                Teacher teacher= new Teacher(Persons.ID);
                Admin_Profile admin_Profile = new Admin_Profile(teacher);
                admin_Profile.Show();
                this.Hide();
            }
            
        }
    }
}
