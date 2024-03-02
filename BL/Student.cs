using L5T1.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5T1.BL
{
    internal class Student
    {
        public string name;
        public int age;
        public float fscMarks;
        public float merit;
        public float ecatMarks;
        public List<DegreeProgram> Preferences;
        public List<Subject> RegSubjects;
        public  DegreeProgram RegProgram;
        public Student(string name, int age, float fscMarks, float ecatMarks, List<DegreeProgram> preferences)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.Preferences = preferences;
            RegSubjects = new List<Subject>();
        }
        public void CalculateMerit()
        {
            this. merit = (((fscMarks / 1100) * 0.45F) + ((ecatMarks / 400) * 0.55F) * 100);
        }
        public static int GetCreditHour()
        {
            int count = 0;
            foreach (Subject s in StudentCrud.RegSubjects)
            {
                count += s.creditHour;
            }
            return count;
        }
        public  float CalculateFee()
        {
            float fee = 0;
            if (StudentCrud.RegSubjects != null)
            {
                foreach (Subject s in StudentCrud.RegSubjects)
                {
                    fee += s.subjectFee;
                }
            }
            return fee;
        }
        public  bool RegStudentSubject(Subject s)
        {
            int stCH = GetCreditHour();
            if (RegProgram != null && RegProgram.IsSubject(s)&& stCH + s.creditHour <= 9)
            {
                StudentCrud.RegSubjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
