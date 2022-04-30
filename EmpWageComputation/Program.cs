using System;

namespace EmpWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------- WELCOME TO THE EMPLOYEE WAGE COMPUTATION ------------");
            Console.WriteLine();
            int isPresent = 1;
            int isFullTime = 2;
            int isPartTime = 1;
            int empRatePerHr = 20;
            int numOfWorkingDays = 20;
            int totalWorkingHrs = 100;
            int totalWorkingDays = 20;
            int workingDay = 0;
            int workingHrs = 0;
            int totalHrs = 0;
            int empHr = 0;
            int empWage = 0;
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
            Console.WriteLine("Total Working Hrs : "+totalHrs);
            totalSalary = totalHrs * empRatePerHr;
            Console.WriteLine("Total Employee wage for a month : "+totalSalary);
        }
    }
}