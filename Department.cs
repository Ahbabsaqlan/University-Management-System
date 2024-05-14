using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace University_Management_System
{
    public partial class Department : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_SYSTEM 2;Integrated Security=True;");

        public Department(string faculty)
        {
            InitializeComponent();
            //Fetch Data
            string query = "select Department_Name from DEPARTMENT where Faculty_ID='"+faculty+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            //Data Showing
            Dept_Show[] pg = new Dept_Show[dt.Rows.Count];
            int i = 0;
            foreach (DataRow r in dt.Rows)
            {
                pg[i] = new Dept_Show(r.Field<string>(0));
                Dept_Panel.Controls.Add(pg[i]);
                i++;
            }
        }
        
        // Minimize Button
        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
        
        
        
    }
}
