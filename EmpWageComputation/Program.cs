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
            int empHr = 0;
            int empWage = 0;
            Random random = new Random();
            int randomCheck = random.Next(3);
            if(randomCheck==isPartTime)
            {
                Console.WriteLine("Employee is present Part Time : ");
                empHr = 8;
            }
            else if(randomCheck==isFullTime)
            {
                Console.WriteLine("Employee is present Full Time : ");
                empHr = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent : ");
                empHr = 0;
            }
            empWage = empHr * empRatePerHr;
            Console.WriteLine("Employee Wage = "+empWage);
        }
    }
}