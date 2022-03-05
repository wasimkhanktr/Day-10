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
            Console.WriteLine("Welcome to EmpWage by OOPS Program");
            //Making Object of CompEmpWage to call Different Companies ComputeWage method.
            IEmpWageBuilder interfaceAppproach = new EmpWageBuilderArray(2);
            interfaceAppproach.AddEmpWageInArray(100, 20, 18, "MARUTI");
            interfaceAppproach.AddEmpWageInArray(120, 25, 22, "TATA");
            interfaceAppproach.GetEmpWage();

        }
    }
}