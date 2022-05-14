using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EmpWageComputation
{
    public class EmpWageBuilder : IComputeEmpWage
    {
        public const int isFullTime = 2;
        public const int isPartTime = 1;

        private LinkedList<CompanyEmpWage> companyEmpWagesList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;
        public EmpWageBuilder()
        {
            this.companyEmpWagesList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }
        public void addCompanyEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int totalWorkingHrs)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHr, numOfWorkingDays, totalWorkingHrs);
            this.companyEmpWagesList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
        }
        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWagesList)
            {
                //companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                //Console.WriteLine(companyEmpWage.toString());
            }
        }
       // privat int computeEmpWage(CompanyEmpWage companyEmpWage);
            public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalSalary;
        }
    }
}
