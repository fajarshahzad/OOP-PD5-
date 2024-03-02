using L5T1.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5T1.BL
{
    internal class DegreeProgram
    {
        public string degreeName;
        public float duration;
        public int seats;
        public List<Subject> Subjects;
        public DegreeProgram(string degreeName, float duration, int seats)
        {
            this.degreeName = degreeName;
            this.duration = duration;
            this.seats = seats;
            Subjects = new List<Subject>();
        }
        public int CalculateCreditHour()
        {
            int count = 0;
            for (int i = 0; i < Subjects.Count; i++)
            {
                count += Subjects[i].creditHour;
            }
            return count;
        }
        public bool AddSubject(Subject s)
        {
            int CreditHours = CalculateCreditHour();
            if (CreditHours + s.creditHour <= 20)
            {
                Subjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsSubject(Subject sub)
        {
            foreach (Subject s in Subjects)
            {
                if (s.code == sub.code)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
