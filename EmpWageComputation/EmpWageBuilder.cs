using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    internal class EmpWageBuilderArray:IComputeEmpWage
    {
        public const int isFullTime = 2;
        public const int isPartTime = 1;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;
        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int totalWorkingHrs)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHr, numOfWorkingDays, totalWorkingHrs);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        public int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int workingDays = 0;
            int workingHrs = 0;
            int totalHrs = 0;
            int empHr = 0;
            while (workingHrs <= companyEmpWage.totalWorkingHrs && workingDays < companyEmpWage.numOfWorkingDays)
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
            return workingHrs * companyEmpWage.empRatePerHr;
        }
    }
}
