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
    public partial class Admin_Search : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_CITY;Integrated Security=True;");
        public Admin_Search()
        {
            InitializeComponent();
            container.VerticalScroll.Visible = false;
            container.HorizontalScroll.Visible = false;
        }
        // Exit Button
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Minimize Button
        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                container.Controls.Clear();
                string query = "select user_id from LOGIN where user_id like '%" + textBox1.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                //Data Showing
                Search_tab[] pg = new Search_tab[dt.Rows.Count];
                int i = 0;
                foreach (DataRow r in dt.Rows)
                {
                    if (r.Field<string>(0).Substring(2, 1) == "-")
                    {
                        pg[i] = new Search_tab(new Student(r.Field<string>(0)));
                        container.Controls.Add(pg[i]);
                        i++;
                    }
                    else if (r.Field<string>(0).Substring(4, 1) == "-")
                    {
                        pg[i] = new Search_tab(new Teacher(r.Field<string>(0)));
                        container.Controls.Add(pg[i]);
                        i++;
                    }
                }
            }
        }
    }
}
