using L5T1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5T1.DL
{
    internal class DegreeCrud
    {
        public static List<DegreeProgram> degreePrograms = new List<DegreeProgram>();
        public static List<DegreeProgram> ProgramList = new List<DegreeProgram>();
        public  List<Subject> Subjects=new List<Subject>();

        public static void ViewRegStudent()
        {
            Console.WriteLine("Name\tFSC Marks\tECAT Marks\tAge");
            foreach (Student s in StudentCrud.Students)
            {
                if (s.RegProgram != null)
                {
                    Console.WriteLine(s.name + "\t\t" + s.fscMarks + "\t\t" + s.ecatMarks + "\t\t" + s.age);
                }
            }

        }
        public static void Add_Into_DegreeList(DegreeProgram d)
        {
            ProgramList.Add(d);
        }
        public static void ViewDegreePrograms()
        {
            foreach (DegreeProgram dp in ProgramList)
            {
                Console.WriteLine(dp.degreeName);
            }
        }
        public static void ViewStudent_inDegree(string degName)
        {
            Console.WriteLine("Name\tFSC Marks\tECAT Marks\tAge");
            foreach (Student s in StudentCrud.Students)
            {
                if (s.RegProgram != null)
                {
                    if (degName == s.RegProgram.degreeName)
                    {
                        Console.WriteLine(s.name + "\t\t" + s.fscMarks + "\t\t" + s.ecatMarks + "\t\t" + s.age);
                    }
                }
            }
        }
    }
}
