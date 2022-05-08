using System;

namespace EmpWageComputation
{
    internal class Program
    {
        public const int isFullTime = 2;
        public const int isPartTime = 1;

        // in static method No Need To create a object of the class
        public static int ComputeEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int totalWorkingHrs) //method with argument and return type
        {
            int workingDay = 0;
            int workingHrs = 0;
            int totalHrs = 0;
            int empHr = 0;
            int totalSalary = 0;
            while (workingHrs <= totalWorkingHrs && workingDay < numOfWorkingDays)
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
                Console.WriteLine("Days : " + workingDay + " :: Emp Working Hours : " + workingHrs);
                totalHrs += empHr;
                Console.WriteLine();
            }
            Console.WriteLine("Total Working Hrs : " + totalHrs + " For : " + company);
            totalSalary = totalHrs * empRatePerHr;
            Console.WriteLine("Total Employee Wage For : " + company  +" Total Salary : " + totalSalary);
            Console.WriteLine("\n");
            return totalSalary;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("------------- WELCOME TO THE EMPLOYEE WAGE COMPUTATION ------------");
            Console.WriteLine();

            // in static method No Need To create a object of the class
            ComputeEmpWage("TCS",20,20,100);      // (company, empRatePerHrs, numOfWorkingDay, totalWorkingHrs)
            ComputeEmpWage("WIPRO", 15, 15, 80);  // (company, empRatePerHrs, numOfWorkingDay, totalWorkingHrs)
            ComputeEmpWage("INFOSYS", 30, 20, 80);// (company, empRatePerHrs, numOfWorkingDay, totalWorkingHrs)
        }
    }
}