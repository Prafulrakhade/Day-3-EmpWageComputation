using System;

namespace EmpWageComputation
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("------------- WELCOME TO THE EMPLOYEE WAGE COMPUTATION ------------");
            Console.WriteLine();

            EmpWageBuilder tcs = new EmpWageBuilder("TCS", 20, 20, 100);         //(company, empRatePerHrs, numOfWorkingDay, totalWorkingHrs)
            EmpWageBuilder wipro = new EmpWageBuilder("WIPRO", 15, 15, 80);      //(company, empRatePerHrs, numOfWorkingDay, totalWorkingHrs)
            EmpWageBuilder infosys = new EmpWageBuilder("INFOSYS", 30, 20, 80);  //(company, empRatePerHrs, numOfWorkingDay, totalWorkingHrs)
            tcs.ComputeEmpWage();
            Console.WriteLine(tcs.toString());
            wipro.ComputeEmpWage();
            Console.WriteLine(wipro.toString());
            infosys.ComputeEmpWage();
            Console.WriteLine(infosys.toString());
        }
    }
}