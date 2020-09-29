using System;

namespace EmployeProblem
{
    class EmployeeWageComputation
    {
        const int IS_FULL_TIME = 1;
        const int ISS_PART_TIME = 2;
        private string CompanyName;
        private int maxWorkingHours;
        private int maxNumOfWorkingDays;
        private int ratePerHour;
        private int totalWage = 0;

        public EmployeeWageComputation(string companyName, int maxWorkingHours, int maxNumOfWorkingDays, int ratePerHour)
        {
            this.CompanyName = companyName;
            this.maxWorkingHours = maxWorkingHours;
            this.maxNumOfWorkingDays = maxNumOfWorkingDays;
            this.ratePerHour = ratePerHour;

        }

        public void calculateEmpWage()
        {
            int empHrs;

            int totalEmpHours = 0;
            int workingDays = 0;
            Random rand = new Random();
            while (totalEmpHours < maxWorkingHours && workingDays < maxNumOfWorkingDays)

            {

                int empcheck = rand.Next(0, 3);



                switch (empcheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case ISS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;


                }
                totalEmpHours = totalEmpHours + empHrs;
                Console.WriteLine("the total working days is " + workingDays + "and working hours is " + totalEmpHours);

                workingDays++;
            }

            totalWage = totalEmpHours * ratePerHour;
            Console.WriteLine("The total wage of worker for" + CompanyName + "is:" + totalWage);


        }
        public string information()
        {
            return "Total wage for" + this.CompanyName + "is:" + this.totalWage;
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            EmployeeWageComputation Capgemini = new EmployeeWageComputation("Capgemini", 30, 70, 20);
            EmployeeWageComputation Amazon = new EmployeeWageComputation("Amazon", 20, 60, 40);
            Capgemini.calculateEmpWage();
            Amazon.calculateEmpWage();
            Console.WriteLine(Capgemini.information());
            Console.WriteLine(Amazon.information());


        }


    }






}