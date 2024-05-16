using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    internal class Address
    {
        public Address(string house,string road,string area,string city) 
		{
			House = house;
			Road = road;
			Area = area;
			City = city;
		}

		private string _house;

		public string House
		{
			get { return _house; }
			set { _house = value; }
		}

		private string _road;

		public string Road
		{
			get { return _road; }
			set { _road = value; }
		}

		private string _area;

		public string Area
		{
			get { return _area; }
			set { _area = value; }
		}

		private string _city;

		public string City
		{
			get { return _city; }
			set { _city = value; }
		}



	}
}
