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
            const int PARTTIME = 2;
            const int WAGEPERHOUR = 20;
            const int FULLDAYHOUR = 8;
            const int PARTTIMEHOUR = 4;
            const int TOTALWORKINGDAYS = 20;
            //VARIABLES
            int empCheck;
            int workingHour;
            int workingdays = 0;
            int totalWorkingHours = 0;
            //Monthly Wage Computation
            while (workingdays < TOTALWORKINGDAYS)
            {
                Random random = new Random();
                empCheck = random.Next(0, 3);
                //Checking Absent & present & assigning workinghours.
                switch (empCheck)
                {
                    case ISPRESENT:
                        Console.WriteLine("Employee is Present");
                        workingHour = FULLDAYHOUR;
                        break;
                    case PARTTIME:
                        Console.WriteLine("Employee is Part Time");
                        workingHour = PARTTIMEHOUR;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        workingHour = 0;
                        break;
                }
                totalWorkingHours = totalWorkingHours + workingHour;
                workingdays++;
            }
            Console.WriteLine($"Daily EmpWage is {totalWorkingHours * WAGEPERHOUR}");

        }
    }
}