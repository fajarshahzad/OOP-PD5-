using L5T1.BL;
using L5T1.DL;
using L5T1.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opt = 0;
            while (opt != 8)
            {
                Console.Clear();
                Utility.Header();
                opt = Utility.Menu();
                if (opt == 1)
                {
                    Console.Clear();
                    Utility.Header();
                    if (DegreeCrud.ProgramList.Count > 0)
                    {
                        Student s = StudentUI.TakeInputForStudent();
                        StudentCrud.AddInto_studentList(s);
                    }
                }
                if (opt == 2)
                {
                    Console.Clear();
                    Utility.Header();
                    DegreeProgram d = DegreeUI.TakeInput_Degree();
                    DegreeCrud.Add_Into_DegreeList(d);
                }
                if (opt == 3)
                {
                    Console.Clear();
                    Utility.Header();
                    List<Student> SortedStudentList;
                    SortedStudentList = StudentCrud.SortStudentsByMerit();
                    StudentCrud.GiveAdmission(SortedStudentList);
                    StudentCrud.PrintStudent();
                }
                if (opt == 4)
                {
                    Console.Clear();
                    Utility.Header();
                    DegreeCrud.ViewRegStudent();
                }
                if (opt == 5)
                {
                    Console.Clear();
                    Utility.Header();
                    string dName;
                    Console.WriteLine("Enter Degree Name: ");
                    dName = Console.ReadLine();
                    DegreeCrud.ViewStudent_inDegree(dName);
                }
                if (opt == 6)
                {
                    Console.Clear();
                    Utility.Header();
                    Console.WriteLine("Enter Student name: ");
                    string name = Console.ReadLine();
                    Student s = StudentCrud.StudentPresent(name);
                    if (s != null)
                    {
                        Subject.ViewSubjects(s);
                        StudentCrud.RegisterSubject(s);
                    }
                }
                if (opt == 7)
                {
                    Console.Clear();
                    Utility.Header();
                    StudentUI.DisplayFee();
                }
                if (opt == 8)
                {
                    Console.Clear();
                    Utility.Header();
                    Console.WriteLine("Exiting the Program.");

                }
                Console.ReadKey();
            }

        }

    }
}
