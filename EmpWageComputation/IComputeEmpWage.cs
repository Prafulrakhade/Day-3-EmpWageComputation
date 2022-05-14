using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int totalWorkingHrs);
        public void computeEmpWage();

        public int getTotalWage(string company);
    }
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHr;
        public int numOfWorkingDays;
        public int totalWorkingHrs;
        public int totalSalary;
        public CompanyEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int totalWorkingHrs)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.numOfWorkingDays = numOfWorkingDays;
            this.totalWorkingHrs = totalWorkingHrs;
            this.totalSalary = 0;
        }
        public void setTotalEmpWage(int totalSalary)
        {
            this.totalSalary = totalSalary;
        }
        public string toString()
        {
            return "Total Employee Wage For Companyn : " + this.company + "is : " + this.totalSalary;
        }

    }
}
