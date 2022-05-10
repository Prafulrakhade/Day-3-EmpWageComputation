using System;

namespace EmpWageComputation
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("------------- WELCOME TO THE EMPLOYEE WAGE COMPUTATION ------------");
            Console.WriteLine();

            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("TCS", 20, 20, 100);     //(company, empRatePerHrs, numOfWorkingDay, totalWorkingHrs)
            empWageBuilder.addCompanyEmpWage("WIPRO", 15, 15, 80);    //(company, empRatePerHrs, numOfWorkingDay, totalWorkingHrs)
            empWageBuilder.addCompanyEmpWage("INFOSYS", 30, 20, 80);  //(company, empRatePerHrs, numOfWorkingDay, totalWorkingHrs)
            empWageBuilder.computeEmpWage();
        }
    }
}