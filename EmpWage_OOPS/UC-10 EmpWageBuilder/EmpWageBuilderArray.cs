using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_OOPS
{
    internal class EmpWageBuilderArray
    {
        public CompEmpWage[] compEmpWageArray;

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
            for (int j = 0; j < compEmpWageArray.Length; j++)
            {
                compEmpWageArray[j].ComputeWage();
            }
        }

    }
}