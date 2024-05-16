﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management_System
{
    internal  class start
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new login());
        //}
        public static void Main(string[] args)
        {
            Student st = new Student("22-48108-2");
            Console.WriteLine(st.FirstName);
            Console.WriteLine(st.LastName);
            Console.WriteLine(st.FatherName);
            Console.WriteLine(st.MotherName);
            Console.WriteLine(st.Email);
            Console.WriteLine(st.Mobile);
            Console.WriteLine(st.CGPA);
            Console.WriteLine(st.CreditComplete);
            Console.WriteLine(st.Programs.ProgramName);
            Console.WriteLine(Program.TotalCourse);
            Console.WriteLine(st.Programs.Facultys.FacultyName);
            for(int i=0;i< Program.TotalCourse; i++)
            {
                Console.WriteLine(st.Programs.Curriculums.CurricullumCourses[i].CourseName);
            }
            Console.WriteLine(st.Programs.Curriculums.CurricullumCourses[Program.TotalCourse-1].Departments.DepartmentName);

            Student st1 = new Student("22-48109-2");
            Console.WriteLine(st1.FirstName);
            Console.WriteLine(st1.LastName);
            Console.WriteLine(st1.FatherName);
            Console.WriteLine(st1.MotherName);
            Console.WriteLine(st1.Email);
            Console.WriteLine(st1.Mobile);
            Console.WriteLine(st1.CGPA);
            Console.WriteLine(st1.CreditComplete);
            Console.WriteLine(st1.Programs.ProgramName);
            Console.WriteLine(Program.TotalCourse);
            Console.WriteLine(st1.Programs.Facultys.FacultyName);
            for (int i = 0; i < Program.TotalCourse; i++)
            {
                Console.WriteLine(st1.Programs.Curriculums.CurricullumCourses[i].CourseName);
            }
            Console.WriteLine(st1.Programs.Curriculums.CurricullumCourses[Program.TotalCourse-1].Departments.DepartmentName);

            Teacher tea = new Teacher("1705-1788-2");
            Console.WriteLine(tea.FirstName);
            Console.WriteLine(tea.LastName);
            Console.WriteLine(tea.FatherName);
            Console.WriteLine(tea.MotherName);
            Console.WriteLine(tea.Email);
            Console.WriteLine(tea.Mobile);
            Console.WriteLine(tea.Position);
            Console.WriteLine(tea.DepartMents.DepartmentName);
            Console.WriteLine(tea.DepartMents.Facultys.FacultyName);

            Admin adm = new Admin("ADMIN1");
            Console.WriteLine(adm.FirstName);
            Console.WriteLine(adm.LastName);
            Console.WriteLine(adm.FatherName);
            Console.WriteLine(adm.MotherName);
            Console.WriteLine(adm.Email);
            Console.WriteLine(adm.Mobile);
            Console.WriteLine(adm.Position);
            Console.ReadKey();
        }
    }
}