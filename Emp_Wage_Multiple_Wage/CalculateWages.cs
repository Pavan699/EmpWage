using System;
using System.Collections.Generic;
using System.Text;

namespace Emp_Wage_Multiple_Wage
{
    class CalculateWages
    {   
        //Class Variables
        public int oneDay_Sal = 0;
        public int perHour_Pay = 20;        
        public int perhour;       
        public int tot_Wage = 0;      
        
        //Inbuild Random Function Object creation 
        Random emp_random = new Random();
        //check method for implimentation
        public void check(string cmp_name, int cmp_num, int max_WorkDay , int tot_MaxHours)
        {
            int tot_Workhours = 0;
            int day = 1;
            //While for condition Days and Hours for each Company 
            while (day <= max_WorkDay && tot_Workhours <= tot_MaxHours)
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
            Console.WriteLine();
            tot_Wage = tot_Workhours * perHour_Pay;
            //Displaying the Wages And Information for Comapnies
            Console.WriteLine("Comapny Name is : " + cmp_name);
            Console.WriteLine("Comapny Number is : " + cmp_num);
            Console.WriteLine("Total Wage  For Month is : " + tot_Wage);
            Console.WriteLine("Total Hours For Month is : " + tot_Workhours);
        }
    }
}
