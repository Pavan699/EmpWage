using System;

namespace Emp_Wage_Multiple_Wage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple Company Wages ::");
            CalculateWages cal = new CalculateWages();
            cal.check();
        }
    }
}
