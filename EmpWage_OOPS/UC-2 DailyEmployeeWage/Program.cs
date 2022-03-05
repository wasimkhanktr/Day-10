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
            //CONSTATNTS
            const int ISPRESENT = 1;
            const int ISABSENT = 0;
            const int WAGEPERHOUR = 20;
            const int FULLDAYHOUR = 8;
            //VARIABLES
            int empCheck;
            int workingHour;

            Random random = new Random();
            empCheck = random.Next(0, 2);
            //Checking Absent & present & assigning workinghours.
            switch (empCheck)
            {
                case ISPRESENT:
                    Console.WriteLine("Employee is present");
                    workingHour = FULLDAYHOUR;
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    workingHour = 0;
                    break;
            }
            Console.WriteLine($"Daily EmpWage is {workingHour * WAGEPERHOUR}");

        }
    }
}