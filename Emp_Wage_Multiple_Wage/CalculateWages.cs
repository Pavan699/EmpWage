using System;
using System.Collections.Generic;
using System.Text;

namespace Emp_Wage_Multiple_Wage
{
    class CalculateWages
    {
        public void check()
        {
            Random emp_random = new Random();
            int empcheck = emp_random.Next(0, 2);
            if (empcheck == 1)
            {
                Console.WriteLine("Employee is Present ");
            }
            else
            {
                Console.WriteLine("Employee is Absent ");
            }
        }
    }
}
