﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComptProb
{
    internal class EmplWage
    {
        public static void EmpAttendance()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is not present");
            }
            Console.ReadLine();
        }
    }
}
