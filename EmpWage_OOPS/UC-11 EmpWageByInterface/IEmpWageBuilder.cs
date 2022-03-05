using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_OOPS
{
    public interface IEmpWageBuilder
    {
        public void AddEmpWageInArray(int totalWorkingHours, int totalWorkingDays, int wagePerHour, string companyName);
        public void GetEmpWage();

    }
    //CONSTATNTS
    internal class EmpWageBuilderArray : IEmpWageBuilder
    {
        const int ISPRESENT = 1;
        const int PARTTIME = 2;
        const int FULLDAYHOUR = 8;
        const int PARTTIMEHOUR = 4;
        //Array Field
        public CompEmpWage[] compEmpWageArray;

        //Array Constructor
        public EmpWageBuilderArray(int size)
        {
            this.compEmpWageArray = new CompEmpWage[size];
        }
        int i = 0;
        public void AddEmpWageInArray(int totalWorkingHours, int totalWorkingDays, int wagePerHour, string companyName)
        {
            compEmpWageArray[i] = new CompEmpWage(totalWorkingHours, totalWorkingDays, wagePerHour, companyName);
            i++;
        }
        public void GetEmpWage()
        {
            foreach (var emp in compEmpWageArray)
            {
                ComputeWage(emp);
            }
        }
        public void ComputeWage(CompEmpWage e1)
        {
            //VARIABLES
            int workingdays = 0; int workingHours = 0;
            //Monthly Wage Computation
            while (workingdays < e1.totalWorkingDays && workingHours <= e1.totalWorkingHours)
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
            e1.totalWage = workingHours * e1.wagePerHour;
            Console.WriteLine($"Employee from {e1.companyName} company earns {e1.totalWage}");
        }

    }
}