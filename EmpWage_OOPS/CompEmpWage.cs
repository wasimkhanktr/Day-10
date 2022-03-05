using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_OOPS
{
    internal class CompEmpWage
    {
        //Fields
        public int totalWorkingHours;
        public int totalWorkingDays;
        public int wagePerHour;
        public string companyName;
        public int totalWage;
        public int[] dailyWage;

        public CompEmpWage(int totalWorkingHours, int totalWorkingDays, int wagePerHour, string companyName)
        {
            this.totalWorkingHours = totalWorkingHours;
            this.totalWorkingDays = totalWorkingDays;
            this.wagePerHour = wagePerHour;
            this.companyName = companyName;
            dailyWage = new int[totalWorkingDays];
        }


    }
}