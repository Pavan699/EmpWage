using System;

namespace Emp_Wage_Multiple_Wage
{
    // Main Class
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple Company Wages ::");
            //Object for CalculateWages class 
            CalculateWages cal = new CalculateWages();
            //calling check method
            cal.check("Bridge-Lab", 144, 24, 100); //("Company Name", Company_Number, Work_Days, Work_Hours)
            cal.check("Capgi", 234, 20, 80);
            cal.check("TATA", 001, 26, 120);
            cal.check("Wipro", 004, 22, 105);
        }
    }
}
