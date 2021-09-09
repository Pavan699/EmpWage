using System;
using System.Collections.Generic;
using System.Text;

namespace Emp_Wage_Multiple_Wage
{
    class CalculateWages
    {
        int oneDay_Sal = 0;
        int full_Time = 8;
        int perHour_Pay = 20;
        int part_Time = 4;
        Random emp_random = new Random();
        public void check()
        {
            
            int empcheck = emp_random.Next(0, 3);
            switch (empcheck)
            {
                case 1:
                    Console.WriteLine("It's Work-Type is : Full-Time");
                    oneDay_Sal = full_Time * perHour_Pay;
                    Console.WriteLine("One Day Salary is : {0}", oneDay_Sal);
                    break;
                case 2:
                    Console.WriteLine("It's Work-Type is : Part-Time");
                    oneDay_Sal = part_Time * perHour_Pay;
                    Console.WriteLine("One Day Salary is : {0}", oneDay_Sal);
                    break;
                default:
                    Console.WriteLine(" Employee is Absent...");
                    break;
            }
        }
    }
}
