using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComptProb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME");
            EmplWage.EmpAttendance();
            employee.ComputeEmpwage("DMart", 20, 2, 10);
            employee.ComputeEmpwage("Reliance", 10, 4, 20);
            Console.ReadLine();
        }

    }
}
