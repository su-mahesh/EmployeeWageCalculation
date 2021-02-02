using System;

namespace EmployeeWageComputationNameSpace
{
    class EmployeeWageComputation
    {
        private const float EmpWagePerHour = 20;
        private const int FullTime_WorkingHrs_PerDay = 8;
        private const int PartTime_WorkingHrs_PerDay = 4;
        private const int IS_FULL_TIME = 1;
        private const int IS_PART_TIME = 2;
        private const int IS_ABSENT = 0;
        private const int Num_WorkingDays_PerMonth = 20;
        private float EmpMonthlyWage = 0;
        float EmpDailyWage = 0;

        private int IsEmployeePresent() {
            return new Random().Next() % 3;
        }

        public void CalculateWage() {
            
            int DayNumber = 1;
            int EmpWorkinhHrs = 0;
            while (DayNumber <= Num_WorkingDays_PerMonth) {
                switch (IsEmployeePresent()) {
                    case IS_ABSENT:
                        EmpWorkinhHrs = 0;
                        break;
                    case IS_PART_TIME:
                        EmpWorkinhHrs = PartTime_WorkingHrs_PerDay;
                        break;
                    case IS_FULL_TIME:
                        EmpWorkinhHrs = FullTime_WorkingHrs_PerDay;
                        break;
                }
                EmpDailyWage = EmpWorkinhHrs * EmpWagePerHour;

                EmpMonthlyWage += EmpDailyWage;
                DayNumber++;
            }
            Console.WriteLine("Employee monthly wage :"+ EmpMonthlyWage);
        }

        static void Main(string[] args)
        {
            EmployeeWageComputation employeeWageComputation = new  EmployeeWageComputation();
            Console.WriteLine("Welcome to Employee Wage Computation");

            employeeWageComputation.CalculateWage();
        }
    }
}
