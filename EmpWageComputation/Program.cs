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
            int empRatePerHr = 20;
            int empHr = 0;
            int empWage = 0;
            Random random = new Random();
            int randomCheck = random.Next(2);
            if(randomCheck==isPresent)
            {
                empHr = 8;
            }
            else
            {
                empHr = 0;
            }
            empWage = empHr * empRatePerHr;
            Console.WriteLine("Employee Wage = "+empWage);
        }
    }
}