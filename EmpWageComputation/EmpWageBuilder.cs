using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    internal class EmpWageBuilder
    {
        public const int isFullTime = 2;
        public const int isPartTime = 1;
        private string company;
        private int empRatePerHr;
        private int numOfWorkingDays;
        private int totalWorkingHrs;
        private int totalSalary;
        public EmpWageBuilder(string company, int empRatePerHr, int numOfWorkingDays, int totalWorkingHrs)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.numOfWorkingDays = numOfWorkingDays;
            this.totalWorkingHrs = totalWorkingHrs;
        }

        public void ComputeEmpWage() 
        {
            int workingDays = 0;
            int workingHrs = 0;
            int totalHrs = 0;
            int empHr = 0;
            while (workingHrs <= this.totalWorkingHrs && workingDays < this.numOfWorkingDays)
            {
                workingDays++;
                Random random = new Random();
                int randomCheck = random.Next(3);
                switch (randomCheck)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Employee is Present Part Time : ");
                        empHr = 4;
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Employee is Present Full Day : ");
                        empHr = 8;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Employee is Absent : ");
                        empHr = 0;
                        break;
                }
                workingHrs += empHr;
                Console.WriteLine("Days : " + workingDays + " :: Emp Working Hours : " + workingHrs);
                totalHrs += empHr;
                Console.WriteLine();
            }
            Console.WriteLine("Total Working Hrs : " + totalHrs + " For : " + company);
            totalSalary = totalHrs * this.empRatePerHr;
            Console.WriteLine("Total Employee Wage For : " + this.company + " Total Salary : " + totalSalary);
        }
        public string toString()
        {
            return "Total Employee Wage For Company : " + this.company + " Total Salary : " + this.totalSalary;
        }
    }
}
