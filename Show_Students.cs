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
    public partial class Show_Students : UserControl
    {
        public Show_Students(string firstName, string lastName, string id)
        {
            InitializeComponent();
            Person_First_Name.Text = firstName;
            Person_Last_Name.Text = lastName;
            Person_ID.Text = id;
            //var reader = cmd.ExecuteReader();
            //while (reader.Read() == true)
            //{
            //    byte[] img = (byte[])reader["Photo"];
            //    if (img == null)
            //    {
            //        Person_.Image = null;
            //    }
            //    else
            //    {
            //        MemoryStream ms = new MemoryStream(img);
            //        Person_photo.Image = Image.FromStream(ms);
            //    }

            //}
        }

        private void Show_Students_Load(object sender, EventArgs e)
        {

        }

        private void Person_ID_Click(object sender, EventArgs e)
        {

        }
    }
}
