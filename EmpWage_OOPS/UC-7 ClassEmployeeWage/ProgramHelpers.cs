namespace EmpWage_OOPS
{
    internal static class ProgramHelpers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage by OOPS Program");
            //Making Object of CompEmpWage to call ComputeWage method.
            ((CompEmpWage)new CompEmpWage()).ComputeWage();


        }
    }
}