﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5T1.UI
{
    internal class Utility
    {
        public static int Menu()
        {
            int option;
            Console.WriteLine("Welcome to University Admissions Management System:)");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate MAC");
            Console.WriteLine("4. View Students of a Specific Program");
            Console.WriteLine("5. View Registered Students");
            Console.WriteLine("6. Calculate Fees for all Registered Students");
            Console.WriteLine("7. Register Subject for a Specific Student");
            Console.WriteLine("8. Exit");
        again:
            Console.WriteLine("Enter your option: ");
            option = int.Parse(Console.ReadLine());
            if (option <= 0 || option > 8)
            {
                Console.WriteLine("Invalid Option! Try Again..");
                goto again;
            }
            return option;
        }
        public static void Header()
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("*                     UAMS                    *");
            Console.WriteLine("***********************************************");
        }
    }
}
