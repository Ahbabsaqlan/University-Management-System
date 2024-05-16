using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace University_Management_System
{
    internal class Person
    {
		protected Person() { }

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

        protected void setval(string firstname, string lastname, string fathername, string mothername, string email, string mobile, string nid,string house,string road,string area,string city,int day,int month,int year)
        {
            FirstName = firstname;
            LastName = lastname;
            FatherName = fathername;
            MotherName = mothername;
            Email = email;
            Mobile = mobile;
            NID = nid;
			Address=new Address(house, road,area,city);
			DOB = new Date(day,month,year);
        }






    }
}
