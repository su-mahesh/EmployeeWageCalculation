using System;
using System.Collections.Generic;

namespace EmployeeWageComputationNameSpace
{
    class EmployeeWageComputation : IEmpWageComputation
    {
        private const int IS_FULL_TIME = 1;
        private const int IS_PART_TIME = 2;
        private const int IS_ABSENT = 0;
        float EmpDailyWage = 0;
        private float TotalWage = 0;
        private Dictionary<String, CompanyEmpWage> Companies = new Dictionary<String, CompanyEmpWage>();

        public void AddCompany(String CompanyName, int EmpWagePerHour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHrs_PerDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS)
        {
            CompanyEmpWage company = new CompanyEmpWage(CompanyName.ToLower(), EmpWagePerHour, FullTime_WorkingHrs_PerDay, PartTime_WorkingHrs_PerDay, MAX_WORKING_HRS, MAX_WORKING_DAYS);
            Companies.Add(CompanyName.ToLower(), company);
        }

        private int IsEmployeePresent() {
            return new Random().Next(0, 3);
        }

        public void CalculateEmpWage(string CompanyName) {
            
            int DayNumber = 1;
            int EmpWorkinghHrs = 0;
            int TotalWorkingHrs = 0;
            try
            {
                if (!Companies.ContainsKey(CompanyName.ToLower()))
                    throw new ArgumentNullException("company doesn't exist");
                Companies.TryGetValue(CompanyName.ToLower(), out CompanyEmpWage company);

                while (DayNumber <= company.MAX_WORKING_DAYS && TotalWorkingHrs <= company.MAX_WORKING_HRS)
                {
                    switch (IsEmployeePresent())
                    {
                        case IS_ABSENT:
                            EmpWorkinghHrs = 0;
                            break;
                        case IS_PART_TIME:
                            EmpWorkinghHrs = company.PartTime_WorkingHrs_PerDay;
                            break;
                        case IS_FULL_TIME:
                            EmpWorkinghHrs = company.FullTime_WorkingHrs_PerDay;
                            break;
                    }
                    EmpDailyWage = EmpWorkinghHrs * company.EmpWagePerHour;
                    company.EmpDailyWage.Add(DayNumber, EmpDailyWage);
                    TotalWage += EmpDailyWage;
                    DayNumber++;
                    TotalWorkingHrs += EmpWorkinghHrs;
                }
                company.TotalEmpWage = TotalWage;
                Console.WriteLine("\nCompany name: "+CompanyName);
                Console.WriteLine("Total working days :" + (DayNumber - 1) + "\nTotal working hours :" + TotalWorkingHrs + "\nTotal employee wage :" + company.TotalEmpWage);

            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {        
            Console.WriteLine("Welcome to Employee Wage Computation");    
            IEmpWageComputation employeeWageComputation = new EmployeeWageComputation();

            employeeWageComputation.AddCompany("TATA", 20, 8, 4, 100, 20);
            employeeWageComputation.AddCompany("Mahindra", 30, 8, 4, 100, 20);
            employeeWageComputation.AddCompany("Infy", 25, 8, 4, 100, 20);
            employeeWageComputation.CalculateEmpWage("tata");
            employeeWageComputation.CalculateEmpWage("Mahindra");
            employeeWageComputation.CalculateEmpWage("infy");

            Console.WriteLine("\nMaindra total employee wage:"+ employeeWageComputation.GetTotalEmpWage("Mahindra"));
            
        }

        public float GetTotalEmpWage(string CompanyName)
        {
            if (Companies.ContainsKey(CompanyName.ToLower()))           
                return Companies[CompanyName.ToLower()].TotalEmpWage;            
            else 
                return 0;
        }
    }
}
