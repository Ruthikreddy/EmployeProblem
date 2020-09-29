using System;

namespace EmployeProblem
{
    class Program
    {
        
        static void Main(string[] args)
        {
            EmpWage("Capgemini",8,20,100);
            EmpWage("Visualstudio", 5, 30, 120);
        }
        static void EmpWage(string Companyname,int EMP_RATE_PER_HOUR,int NUM_OF_WORKING_DAYS,int MAX_WORKING_HOURS)
        {
            const int IS_ABSENT = 0;
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
       
            Random randomnumber = new Random();
            int empHours = 0, totalWorkingHours = 0;

            for (int Day = 1; Day <= NUM_OF_WORKING_DAYS; Day++)
            {
                int EmpCheck = randomnumber.Next(0, 3);
                switch (EmpCheck)
                {
                    case IS_ABSENT:
                        empHours = 0;
                        break;
                    case IS_PART_TIME:
                        empHours = 4;
                        break;
                    case IS_FULL_TIME:
                        empHours = 8;
                        break;
                    default:
                        break;
                }
                if (totalWorkingHours + empHours > MAX_WORKING_HOURS)
                    empHours = 0;
                totalWorkingHours += empHours;
                Console.WriteLine("Day " + (Day) + " Employee Hours " + empHours);
            }
            Console.WriteLine("Total Employee Hours " + totalWorkingHours);
            int totalEmpWage = totalWorkingHours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wage for "+ Companyname +":"+ totalEmpWage);
        }

    }
}