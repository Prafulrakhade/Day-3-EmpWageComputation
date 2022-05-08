using System;

namespace EmpWageComputation
{
    internal class Program
    {
        public const int isFullTime = 2;
        public const int isPartTime = 1;
        public const int empRatePerHr = 20;
        public const int numOfWorkingDays = 20;
        public const int totalWorkingHrs = 100;
        public const int totalWorkingDays = 20;

        public static int ComputeEmpWage()
        {
            int workingDay = 0;
            int workingHrs = 0;
            int totalHrs = 0;
            int empHr = 0;
            int totalSalary = 0;
            while (workingHrs <= totalWorkingHrs && workingDay < totalWorkingDays)
            {
                workingDay++;
                Random random = new Random();
                int randomCheck = random.Next(3);
                switch (randomCheck)
                {
                    case 1:
                        Console.WriteLine("Employee is Present Part Time : ");
                        empHr = 4;
                        break;
                    case 2:
                        Console.WriteLine("Employee is Present Full Day : ");
                        empHr = 8;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent : ");
                        empHr = 0;
                        break;
                }
                workingHrs += empHr;
                Console.WriteLine("Days : " + workingDay + " :: Emp Working hours : " + workingHrs);
                totalHrs += empHr;
            }
            Console.WriteLine("Total Working Hrs : " + totalHrs);
            totalSalary = totalHrs * empRatePerHr;
            Console.WriteLine("Total Employee wage for a month : " + totalSalary);
            return totalSalary;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("------------- WELCOME TO THE EMPLOYEE WAGE COMPUTATION ------------");
            Console.WriteLine();
            ComputeEmpWage();
        }
    }
}