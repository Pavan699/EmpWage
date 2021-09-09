using System;

namespace Emp_Wage_Multiple_Wage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple Company Wages ::");
            CalculateWages cal = new CalculateWages();
            cal.check("Bridge-Lab", 144, 24, 100);
            cal.check("Capgi", 234, 20, 80);
            cal.check("TATA", 001, 26, 120);
            cal.check("Wipro", 004, 22, 105);
        }
    }
}
