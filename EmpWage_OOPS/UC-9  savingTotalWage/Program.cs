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
            //Making Object of CompEmpWage to call Different Companies ComputeWage method.
            CompEmpWage tata = new CompEmpWage(90, 18, 25, "TATA");
            CompEmpWage maruti = new CompEmpWage(100, 18, 25, "MARUTI");
            tata.ComputeWage();
            maruti.ComputeWage();

        }
    }
}