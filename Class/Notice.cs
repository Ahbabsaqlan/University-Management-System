using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace University_Management_System
{
    internal class Notice
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_CITY;Integrated Security=True;");

        public Notice() 
        {
            
        }
        public Notice(string id) 
        {
            //Fetch Data
            string Data = "select Title,Notice,Time from NOTICE where Section_ID='" + id + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(Data, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                NoticesContent = new Notice[dt.Rows.Count];
                int index = 0;
                foreach (DataRow data in dt.Rows)
                {
                    NoticesContent[index] = new Notice();
                    NoticesContent[index].Title = data.Field<string>(0);
                    NoticesContent[index].Noticed = data.Field<string>(1);
                    NoticesContent[index].Time = data.Field<string>(2);
                    index++;
                }
            }
            else
            {
                NoticesContent = new Notice[1];
                NoticesContent[0]=new Notice();
                NoticesContent[0].Title = "No Notice now!";
                NoticesContent[0].Noticed = null;
                NoticesContent[0].Time = null;
            }
        }

        private Notice[] _noticesContent;

        public Notice[] NoticesContent
        {
            get { return _noticesContent; }
            set { _noticesContent = value; }
        }

        private Section _section;
 
        public Section Sections
        {
            get { return _section; }
            set { _section = value; }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _noticed;

        public string Noticed
        {
            get { return _noticed; }
            set { _noticed = value; }
        }

        private string _time;

        public string Time
        {
            get { return _time; }
            set { _time = value; }
        }

    }
}
