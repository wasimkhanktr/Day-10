using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpWage_OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage by OOPS Program");
            
            const int ISPRESENT = 1;
            const int ISABSENT = 0;
            
            int empCheck;

            Random random = new Random();
            empCheck = random.Next(0, 2);
            switch (empCheck)
            {
                case ISPRESENT:
                    Console.WriteLine("Employee is Present");
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    break;
            }

        }
    }
}