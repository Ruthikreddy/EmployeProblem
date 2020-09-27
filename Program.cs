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
            if (EmpCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is Present");

            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }
}
