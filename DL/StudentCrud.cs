using L5T1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace L5T1.DL
{
    internal class StudentCrud
    {
        public static List<Student> Students = new List<Student>();
        public static List<DegreeProgram> Preferences;
        public static List<Subject> RegSubjects;
        public static void AddInto_studentList(Student s)
        {
            Students.Add(s);
        }
        public static Student StudentPresent(string name)
        {
            foreach (Student std in Students)
            {
                if (name == std.name)
                {
                    return std;
                }
            }
            return null;
        }
        public static List<Student> SortStudentsByMerit()
        {
            List<Student> SortedList = new List<Student>();
            foreach (Student std in Students)
            {
                std.CalculateMerit();
            }
            SortedList = Students.OrderByDescending(o => o.merit).ToList();
            return SortedList;
        }
        public static void GiveAdmission(List<Student> sortedStudentList)
        { 
            foreach (Student std in sortedStudentList)
            {
                foreach (DegreeProgram d in std.Preferences)
                {
                    if (d.seats > 0 && std.RegProgram == null)
                    {
                        std.RegProgram = d;
                        d.seats--;
                        break;
                    }
                }
            }
        }
        public static void RegisterSubject(Student s)
        {
            Console.WriteLine("Enter how many subjects you want to register");
            int subCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < subCount; i++)
            {
                Console.WriteLine("Enter the subject code: ");
                string code = Console.ReadLine();
                bool Flag = false;
                foreach (Subject sub in s.RegProgram.Subjects)
                {
                    if (code == sub.code && !(s.RegSubjects.Contains(sub)));
                    {
                        s.RegStudentSubject(sub);
                        Flag = true;
                        break;
                    }
                }
                if (Flag == false)
                {
                    Console.WriteLine("Enter Invalid Course:(");
                    i--;
                }
            }
        }
        public static void PrintStudent()
        {
            foreach (Student std in Students)
            {
                if (std.RegProgram != null)
                {
                    Console.WriteLine(std.name + " got admission in " + std.RegProgram.degreeName);
                }
                else
                {
                    Console.WriteLine(std.name + " didn't got admission:(");
                }
            }
        }
    }
}
