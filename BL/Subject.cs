using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5T1.BL
{
    internal class Subject
    {
        public string code;
        public string type;
        public int creditHour;
        public int subjectFee;
        public Subject(string code, string type, int creditHour, int subjectFee)
        {
            this.code = code;
            this.type = type;
            this.creditHour = creditHour;
            this.subjectFee = subjectFee;
        }
        public static void ViewSubjects(Student s)
        {
            if (s.RegProgram != null)
            {
                Console.WriteLine("Subject Code\t\tSubject Type");
                foreach (Subject sub in s.RegProgram.Subjects)
                {
                    Console.WriteLine(sub.code + "\t" + sub.type);
                }
            }
        }
    }
}
