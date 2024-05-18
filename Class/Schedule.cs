using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    internal class Schedule
    {
        public Schedule(string scheduleTime,string scheduleDay) 
        {
            ScheduleTime = scheduleTime;
            ScheduleDay = scheduleDay;
        }

        private string _scheduleTime;

        public string ScheduleTime
        {
            get { return _scheduleTime; }
            set { _scheduleTime = value; }
        }

        private string _scheduleDay;

        public string ScheduleDay
        {
            get { return _scheduleDay; }
            set { _scheduleDay = value; }
        }


    }
}
