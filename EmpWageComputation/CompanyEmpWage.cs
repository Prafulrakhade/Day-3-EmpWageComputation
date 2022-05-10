using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    internal class CompanyEmpWage
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
        }
        public void setTotalEmpWage(int totalSalary)
        {
            this.totalSalary = totalSalary;
        }
        public string toString()
        {
            return "Total Employee Wage For Company : " + this.company + " Total Salary : " + this.totalSalary;
        }
    }
}
