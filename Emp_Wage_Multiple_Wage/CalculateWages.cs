using System;
using System.Collections.Generic;
using System.Text;

namespace Emp_Wage_Multiple_Wage
{
    class CalculateWages
    {
        int oneDay_Sal = 0;
        int perHour_Pay = 20;
        int max_WorkDay = 20;
        int perhour;
        int tot_Workhours = 0;
        int tot_Wage = 0;
        
        Random emp_random = new Random();
        public void check()
        {
            int day = 1;
            while (day <= max_WorkDay)
            {
                int empcheck = emp_random.Next(0, 3);
                switch (empcheck)
                {
                    case 1:
                        perhour = 8;
                        break;
                    case 2:
                        perhour = 4;
                        break;
                    default:
                        perhour = 0;
                        break;
                }
                day++;
                oneDay_Sal = perhour * perHour_Pay;
                tot_Workhours = tot_Workhours + perhour;
            }
            tot_Wage = tot_Workhours * perHour_Pay;
            Console.WriteLine("Total Wage For Month is : " + tot_Wage);
        }
    }
}
