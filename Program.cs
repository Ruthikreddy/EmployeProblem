using System;

namespace EmployeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is_Full_Time = 1;
            Random randomnum = new Random();
            int EmpCheck = randomnum.Next(0, 3);
            int full_time_salary = 20*8;
            int parttimesalary = 4 * 20;

            if (EmpCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is Present");
                Console.WriteLine("Daily salary of Employe {0}",full_time_salary);

            }
            else if (EmpCheck==2)
            {
                Console.WriteLine("employee is Part Time");
                Console.WriteLine("Daily salary of Employe {0}", parttimesalary);
            }
            else
            {
                Console.WriteLine("Employe is absent");
            }
        }
    }
}
