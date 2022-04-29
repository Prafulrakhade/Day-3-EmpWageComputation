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
            Random random = new Random();
            int randomCheck = random.Next(2);
            if(randomCheck==isPresent)
            {
                Console.WriteLine("The Employee is Present");
            }
            else
            {
                Console.WriteLine("The Employee is Absent");
            }
        }
    }
}