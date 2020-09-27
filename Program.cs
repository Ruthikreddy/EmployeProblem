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
            int full_time_salary = 20 * 8;
            int parttimesalary = 4 * 20;


            switch (EmpCheck)
            {
                case 1:

                    Console.WriteLine("Employee is Present");
                    Console.WriteLine("Daily salary of Employe {0}", full_time_salary);
                    break;

                case 2:

                    Console.WriteLine("employee is Part Time");
                    Console.WriteLine("Daily salary of Employe {0}", parttimesalary);
                    break;

                case 0:
                    Console.WriteLine("Employe is absent");
                    break;
            }

            int total_Emp_hrs = 0;
            for (int i = 1; i <= 20; i++)
            {
                switch (randomnum.Next(0, 3))
                {
                    case 1:
                        total_Emp_hrs += 8;//emp present for full day on that working day
                        break;
                    case 2:
                        total_Emp_hrs += 4; //emp present for part time on that working day
                        break;
                    case 0:
                        break;
                }
            }
            Console.WriteLine("No of working hours of employee in a month are {0}", total_Emp_hrs);
            int monthly_Wage = total_Emp_hrs * 20;
            Console.WriteLine("Montly wage of employee is {0}", monthly_Wage);
        }
    }

}