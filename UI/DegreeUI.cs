using L5T1.BL;
using L5T1.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5T1.UI
{
    internal class DegreeUI
    {   
        public static DegreeProgram TakeInput_Degree()
        {
            string degreeName;
            float degreeDuration;
            int seats;
            Console.WriteLine("Enter your degree name: ");
            degreeName = Console.ReadLine();
            Console.WriteLine("Enter your degree duration: ");
            degreeDuration = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the available seats");
            seats = int.Parse(Console.ReadLine());
            DegreeProgram d = new DegreeProgram(degreeName, degreeDuration, seats);
            Console.WriteLine("How many subjects you want to enter: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                d.AddSubject(SubjectUI.TakeInput_Subject());
            }
            return d;
        }

    }
}
