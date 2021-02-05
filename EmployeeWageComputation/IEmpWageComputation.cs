using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputationNameSpace
{
    interface IEmpWageComputation
    {
        void CalculateEmpWage(string CompanyName);
        void AddCompany(String CompanyName, int EmpWagePerHour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHrs_PerDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS);

    }
}
