using System;

namespace EmployeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is_Full_Time = 1;
            Random randomnum = new Random();
            int EmpCheck = randomnum.Next(0, 2);
            int full_time_salary = 20*8;
            if (EmpCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is Present");
                Console.WriteLine("Daily salary of Employe {0}",full_time_salary);

            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }
}
