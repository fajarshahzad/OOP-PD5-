using L5T1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5T1.UI
{
    internal class SubjectUI
    {
        public static Subject TakeInput_Subject()
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
            Subject s = new Subject(code, type, creditHour, subjectFee);
            return s;
        }
    }
}
