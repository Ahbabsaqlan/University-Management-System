using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    internal class Date
    {
        public Date(int day,int month,int year) 
		{
			Day = day;
			Month = month;
			Year = year;
		}

		private int _day;

		public int Day
		{
			get { return _day; }
			set { _day = value; }
		}

		private int _month;

		public int Month
		{
			get { return _month; }
			set { _month = value; }
		}

		private int _year;

		public int Year
		{
			get { return _year; }
			set { _year = value; }
		}


	}
}
