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
        public void check()
        {
            Random emp_random = new Random();
            int empcheck = emp_random.Next(0, 2);
            if (empcheck == 1)
            {
                Console.WriteLine("It's Work-Type is : Full-Time");
                oneDay_Sal = full_Time * perHour_Pay;
                Console.WriteLine("One Day Salary is : {0}", oneDay_Sal);
            }
            else
            {
                Console.WriteLine("Employee is Absent ");
            }
        }
    }
}
