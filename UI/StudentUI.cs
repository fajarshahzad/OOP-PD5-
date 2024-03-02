using L5T1.BL;
using L5T1.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5T1.UI
{
    internal class StudentUI
    { 
        public static Student TakeInputForStudent()
        {
            string name;
            int age;
            float fscMarks;
            float ecatMarks;
            List<DegreeProgram> preferences = new List<DegreeProgram>();
            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter Student FSc Marks: ");
            fscMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Student Ecat Marks: ");
            ecatMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Available Degree Programs");
            DegreeCrud.ViewDegreePrograms();
            Console.Write("Enter how many preferences to Enter: ");
            int Count = int.Parse(Console.ReadLine());
            for (int x = 0; x < Count; x++)
            {
                string degName = Console.ReadLine();
                bool flag = false;
                foreach (DegreeProgram dp in DegreeCrud.ProgramList)
                {
                    if (degName == dp.degreeName && !(preferences.Contains(dp)))
                    {
                        preferences.Add(dp);
                    }
                    flag = true;
                }
                if (flag == false)
                {
                    Console.WriteLine("Enter Valid Degree Program Name");
                    x = -1;
                }
            }
            Student s = new Student(name, age, fscMarks, ecatMarks, preferences);
            return s;
        }
        public static  void DisplayFee()
        {

            foreach (Student std in StudentCrud.Students)
            {
                if (std.RegProgram != null)
                {
                    Console.WriteLine(std.name + " has " + std.CalculateFee() + " Fee ");
                }

            }
        }
        public static SubjectUI TakeInput_Subject()
        {
            string code, type;
            int creditHour, subjectFee;
            Console.WriteLine("Enter Subject Code: ");
            code = Console.ReadLine();
            Console.WriteLine("Enter Subject Type: ");
            type = Console.ReadLine();
            Console.WriteLine("Enter Subject Credit Hours: ");
            creditHour = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Fee: ");
            subjectFee = int.Parse(Console.ReadLine());
            SubjectUI s = new SubjectUI();
            return s;
        }

    }
}
