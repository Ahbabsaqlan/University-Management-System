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
    public partial class Add_Student : Form
    {
        Student st = new Student("22-48108-2");
        public Add_Student()
        {
            InitializeComponent();
            string program=st.Programs.ProgramName;
        }
        
        
        
        // Minimize Button
        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        //
    }
}
