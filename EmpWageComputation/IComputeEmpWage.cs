using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public interface IComputeEmpWage
    {
        void addCompanyEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int totalWorkingHrs);
        void computeEmpWage();
    }
}
