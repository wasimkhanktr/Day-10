namespace EmpWage_OOPS
{
    internal class ProgramBase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage by OOPS Program");
            //Making Object of CompEmpWage to call ComputeWage method.
            var e1 = new CompEmpWage();
            e1.ComputeWage();


        }
    }
}