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


        private void Person_ID_Click(object sender, EventArgs e)
        {

        }

        private void Show_Students_Click(object sender, EventArgs e)
        {

        }
    }
}
