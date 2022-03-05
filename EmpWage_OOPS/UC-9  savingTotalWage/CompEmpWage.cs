using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_OOPS
{
    internal class CompEmpWage
    {
        //CONSTATNTS
        const int ISPRESENT = 1;
        const int PARTTIME = 2;
        const int FULLDAYHOUR = 8;
        const int PARTTIMEHOUR = 4;
        //Fields
        int totalWorkingHours;
        int totalWorkingDays;
        int wagePerHour;
        string companyName;

        public CompEmpWage(int totalWorkingHours, int totalWorkingDays, int wagePerHour, string companyName)
        {
            this.totalWorkingHours = totalWorkingHours;
            this.totalWorkingDays = totalWorkingDays;
            this.wagePerHour = wagePerHour;
            this.companyName = companyName;
        }

        public void ComputeWage()
        {
            //VARIABLES
            int workingdays = 0; int workingHours = 0;
            //Monthly Wage Computation
            while (workingdays < totalWorkingDays && workingHours <= totalWorkingHours)
            {
                //VARIABLES
                int empCheck;
                int workingHourPerDay;

                Random random = new Random();
                empCheck = random.Next(0, 3);
                //Checking Absent & present & assigning workinghours.
                switch (empCheck)
                {
                    case ISPRESENT:
                        //Console.WriteLine("Employee is present");
                        workingHourPerDay = FULLDAYHOUR;
                        break;
                    case PARTTIME:
                        //Console.WriteLine("Employee is Part Time");
                        workingHourPerDay = PARTTIMEHOUR;
                        break;
                    default:
                        //Console.WriteLine("Employee is absent");
                        workingHourPerDay = 0;
                        break;
                }
                workingHours = workingHours + workingHourPerDay;
                workingdays++;
            }
            Console.WriteLine($"Monthly EmpWage of {companyName} employee is {workingHours * wagePerHour}");
        }
    }
}