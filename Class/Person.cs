using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace University_Management_System
{
    internal class Person
    {
        SqlConnection connection = new SqlConnection("Data Source=SAQLAN-XAMI;Initial Catalog=UNIVERSITY_MANAGEMENT_CITY;Integrated Security=True;");
        public Person() {}

		private MemoryStream _images;

		public MemoryStream Images
        {
			get { return _images; }
			set { _images = value; }
		}

		private string _id;

		public string ID
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _firstName;

		public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}

        private string _lastName;

        public string LastName
        {
            get { return _lastName ; }
            set { _lastName = value; }
        }
		private string _mobile;

		public string Mobile
		{
			get { return _mobile; }
			set { _mobile = value; }
		}

		private string _email;

		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}


		private string _nid;

		public string NID
		{
			get { return _nid; }
			set { _nid = value; }
		}

		private string _fatherName;

		public string FatherName
        {
			get { return _fatherName; }
			set { _fatherName = value; }
		}

		private string _motherName;

		public string MotherName
		{
			get { return _motherName; }
			set { _motherName = value; }
		}

		private Date _dob;

		public Date DOB
		{
			get { return _dob; }
			set { _dob = value; }
		}

		private Address _address;

		public Address Address
		{
			get { return _address; }
			set { _address = value; }
		}

        protected void setval(Student student,string firstname, string lastname, string fathername, string mothername, string email, string mobile, string nid,string house,string road,string area,string city,int day,int month,int year)
        {
			ID=student.ID;
            FirstName = firstname;
            LastName = lastname;
            FatherName = fathername;
            MotherName = mothername;
            Email = email;
            Mobile = mobile;
            NID = nid;
			Address=new Address(house, road,area,city);
			DOB = new Date(day,month,year);
            string query = "select Photo from STUDENT where Student_ID='" + ID + "'";
            
            SqlCommand cmd = new SqlCommand(query, connection); //query executed
            connection.Open();

            var reader = cmd.ExecuteReader();
            while (reader.Read() == true)
            {
                byte[] Photo = (byte[])reader["Photo"];
                Images = new MemoryStream(Photo);
            }
            connection.Close();
        }
        protected void setval(Teacher teacher, string firstname, string lastname, string fathername, string mothername, string email, string mobile, string nid, string house, string road, string area, string city, int day, int month, int year)
        {
            ID = teacher.ID;
            FirstName = firstname;
            LastName = lastname;
            FatherName = fathername;
            MotherName = mothername;
            Email = email;
            Mobile = mobile;
            NID = nid;
            Address = new Address(house, road, area, city);
            DOB = new Date(day, month, year);
            string query = "select Photo from TEACHER where Teacher_ID='" + ID + "'";

            SqlCommand cmd = new SqlCommand(query, connection); //query executed
            connection.Open();

            var reader = cmd.ExecuteReader();
            while (reader.Read() == true)
            {
                byte[] Photo = (byte[])reader["Photo"];
                Images = new MemoryStream(Photo);
            }
            connection.Close();
        }
        protected void setval(Admin admin, string firstname, string lastname, string fathername, string mothername, string email, string mobile, string nid, string house, string road, string area, string city, int day, int month, int year)
        {
            ID = admin.ID;
            FirstName = firstname;
            LastName = lastname;
            FatherName = fathername;
            MotherName = mothername;
            Email = email;
            Mobile = mobile;
            NID = nid;
            Address = new Address(house, road, area, city);
            DOB = new Date(day, month, year);
            string query = "select Photo from ADMIN where Admin_ID='" + ID + "'";

            SqlCommand cmd = new SqlCommand(query, connection); //query executed
            connection.Open();

            var reader = cmd.ExecuteReader();
            while (reader.Read() == true)
            {
                byte[] Photo = (byte[])reader["Photo"];
                Images = new MemoryStream(Photo);
            }
            connection.Close();
        }

        public void updateInfo(Student person)
        {
            string query = "update STUDENT set First_Name='" + person.FirstName+"' where Student_ID='" + person.ID + "'";
            SqlCommand cmd = new SqlCommand(query, connection); //query executed
            connection.Open();
            int result=cmd.ExecuteNonQuery();
            connection.Close();

            query = "update STUDENT set Last_Name='" + person.LastName + "' where Student_ID='" + person.ID + "'";
            SqlCommand cmd1 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd1.ExecuteNonQuery();
            connection.Close();

            query = "update STUDENT set Father_Name='" + person.FatherName + "'  where Student_ID='" + person.ID + "'";
            SqlCommand cmd2 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd2.ExecuteNonQuery();
            connection.Close();

            query = "update STUDENT set Mother_Name='" + person.MotherName + "'  where Student_ID='" + person.ID + "'";
            SqlCommand cmd3 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd3.ExecuteNonQuery();
            connection.Close();

            query = "update STUDENT set Email='" + person.Email + "'  where Student_ID='" + person.ID + "'";
            SqlCommand cmd4 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd4.ExecuteNonQuery();
            connection.Close();

            query = "update STUDENT set NID='" + person.NID + "'  where Student_ID='" + person.ID + "'";
            SqlCommand cmd5 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd5.ExecuteNonQuery();
            connection.Close();

            query = "update STUDENT set Mobile='" + person.Mobile + "'  where Student_ID='" + person.ID + "'";
            SqlCommand cmd6 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd6.ExecuteNonQuery();
            connection.Close();

            query = "update STUDENT set Program_ID='" + person.Programs.ID + "'  where Student_ID='" + person.ID + "'";
            SqlCommand cmd7 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd7.ExecuteNonQuery();
            connection.Close();

            query = "update Date_of_Birth set Day='" + person.DOB.Day + "'  where Person_ID='" + person.ID + "'";
            SqlCommand cmd8 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd8.ExecuteNonQuery();
            connection.Close();

            query = "update Date_of_Birth set Month='" + person.DOB.Month + "'  where Person_ID='" + person.ID + "'";
            SqlCommand cmd9 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd9.ExecuteNonQuery();
            connection.Close();

            query = "update Date_of_Birth set Year='" + person.DOB.Year + "'  where Person_ID='" + person.ID + "'";
            SqlCommand cmd10 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd10.ExecuteNonQuery();
            connection.Close();

            query = "update ADDRESS set House='" + person.Address.House + "'   where Person_ID='" + person.ID + "'";
            SqlCommand cmd11 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd11.ExecuteNonQuery();
            connection.Close();

            query = "update ADDRESS set Road='" + person.Address.Road + "'  where Person_ID='" + person.ID + "'";
            SqlCommand cmd12 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd12.ExecuteNonQuery();
            connection.Close();

            query = "update ADDRESS set Area='" + person.Address.Area + "'  where Person_ID='" + person.ID + "'";
            SqlCommand cmd13 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd13.ExecuteNonQuery();
            connection.Close();

            query = "update ADDRESS set City='" + person.Address.City + "'  where Person_ID='" + person.ID + "'";
            SqlCommand cmd14 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd14.ExecuteNonQuery();
            connection.Close();

        }

        public void updateInfo(Teacher person)
        {
            string query = "update TEACHER set First_Name='" + person.FirstName + "' where Teacher_ID='" + person.ID + "'";
            SqlCommand cmd = new SqlCommand(query, connection); //query executed
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();

            query = "update TEACHER set Last_Name='" + person.LastName + "' where Teacher_ID='" + person.ID + "'";
            SqlCommand cmd1 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd1.ExecuteNonQuery();
            connection.Close();

            query = "update TEACHER set Father_Name='" + person.FatherName + "'  where Teacher_ID='" + person.ID + "'";
            SqlCommand cmd2 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd2.ExecuteNonQuery();
            connection.Close();

            query = "update TEACHER set Mother_Name='" + person.MotherName + "'  where Teacher_ID='" + person.ID + "'";
            SqlCommand cmd3 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd3.ExecuteNonQuery();
            connection.Close();

            query = "update TEACHER set Email='" + person.Email + "'  where Teacher_ID='" + person.ID + "'";
            SqlCommand cmd4 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd4.ExecuteNonQuery();
            connection.Close();

            query = "update TEACHER set NID='" + person.NID + "'  where Teacher_ID='" + person.ID + "'";
            SqlCommand cmd5 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd5.ExecuteNonQuery();
            connection.Close();

            query = "update TEACHER set Mobile='" + person.Mobile + "'  where Teacher_ID='" + person.ID + "'";
            SqlCommand cmd6 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd6.ExecuteNonQuery();
            connection.Close();

            query = "update TEACHER set Position='" + person.Position + "'  where Teacher_ID='" + person.ID + "'";
            SqlCommand cmd7 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd7.ExecuteNonQuery();
            connection.Close();

            query = "update LOGIN set role='" + person.Position + "'  where user_id='" + person.ID + "'";
            SqlCommand cmd15 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd15.ExecuteNonQuery();
            connection.Close();

            query = "update Date_of_Birth set Day='" + person.DOB.Day + "'  where Person_ID='" + person.ID + "'";
            SqlCommand cmd8 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd8.ExecuteNonQuery();
            connection.Close();

            query = "update Date_of_Birth set Month='" + person.DOB.Month + "'  where Person_ID='" + person.ID + "'";
            SqlCommand cmd9 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd9.ExecuteNonQuery();
            connection.Close();

            query = "update Date_of_Birth set Year='" + person.DOB.Year + "'  where Person_ID='" + person.ID + "'";
            SqlCommand cmd10 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd10.ExecuteNonQuery();
            connection.Close();

            query = "update ADDRESS set House='" + person.Address.House + "'   where Person_ID='" + person.ID + "'";
            SqlCommand cmd11 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd11.ExecuteNonQuery();
            connection.Close();

            query = "update ADDRESS set Road='" + person.Address.Road + "'  where Person_ID='" + person.ID + "'";
            SqlCommand cmd12 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd12.ExecuteNonQuery();
            connection.Close();

            query = "update ADDRESS set Area='" + person.Address.Area + "'  where Person_ID='" + person.ID + "'";
            SqlCommand cmd13 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd13.ExecuteNonQuery();
            connection.Close();

            query = "update ADDRESS set City='" + person.Address.City + "'  where Person_ID='" + person.ID + "'";
            SqlCommand cmd14 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd14.ExecuteNonQuery();
            connection.Close();

            
        }
        public void updateInfo(Admin person)
        {
            string query = "update ADMIN set First_Name='" + person.FirstName + "' where Admin_ID='" + person.ID + "'";
            SqlCommand cmd = new SqlCommand(query, connection); //query executed
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();

            query = "update ADMIN set Last_Name='" + person.LastName + "' where Admin_ID='" + person.ID + "'";
            SqlCommand cmd1 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd1.ExecuteNonQuery();
            connection.Close();

            query = "update ADMIN set Father_Name='" + person.FatherName + "'  where Admin_ID='" + person.ID + "'";
            SqlCommand cmd2 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd2.ExecuteNonQuery();
            connection.Close();

            query = "update ADMIN set Mother_Name='" + person.MotherName + "'  where Admin_ID='" + person.ID + "'";
            SqlCommand cmd3 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd3.ExecuteNonQuery();
            connection.Close();

            query = "update ADMIN set Email='" + person.Email + "'  where Admin_ID='" + person.ID + "'";
            SqlCommand cmd4 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd4.ExecuteNonQuery();
            connection.Close();

            query = "update ADMIN set NID='" + person.NID + "'  where Admin_ID='" + person.ID + "'";
            SqlCommand cmd5 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd5.ExecuteNonQuery();
            connection.Close();

            query = "update ADMIN set Mobile='" + person.Mobile + "'  where Admin_ID='" + person.ID + "'";
            SqlCommand cmd6 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd6.ExecuteNonQuery();
            connection.Close();

            query = "update ADMIN set Position='" + person.Position + "'  where Admin_ID='" + person.ID + "'";
            SqlCommand cmd7 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd7.ExecuteNonQuery();
            connection.Close();

            query = "update LOGIN set role='" + person.Position + "'  where user_id='" + person.ID + "'";
            SqlCommand cmd15 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd15.ExecuteNonQuery();
            connection.Close();

            query = "update Date_of_Birth set Day='" + person.DOB.Day + "'  where Person_ID='" + person.ID + "'";
            SqlCommand cmd8 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd8.ExecuteNonQuery();
            connection.Close();

            query = "update Date_of_Birth set Month='" + person.DOB.Month + "'  where Person_ID='" + person.ID + "'";
            SqlCommand cmd9 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd9.ExecuteNonQuery();
            connection.Close();

            query = "update Date_of_Birth set Year='" + person.DOB.Year + "'  where Person_ID='" + person.ID + "'";
            SqlCommand cmd10 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd10.ExecuteNonQuery();
            connection.Close();

            query = "update ADDRESS set House='" + person.Address.House + "'   where Person_ID='" + person.ID + "'";
            SqlCommand cmd11 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd11.ExecuteNonQuery();
            connection.Close();

            query = "update ADDRESS set Road='" + person.Address.Road + "'  where Person_ID='" + person.ID + "'";
            SqlCommand cmd12 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd12.ExecuteNonQuery();
            connection.Close();

            query = "update ADDRESS set Area='" + person.Address.Area + "'  where Person_ID='" + person.ID + "'";
            SqlCommand cmd13 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd13.ExecuteNonQuery();
            connection.Close();

            query = "update ADDRESS set City='" + person.Address.City + "'  where Person_ID='" + person.ID + "'";
            SqlCommand cmd14 = new SqlCommand(query, connection); //query executed
            connection.Open();
            result = cmd14.ExecuteNonQuery();
            connection.Close();
        }

    }
}
