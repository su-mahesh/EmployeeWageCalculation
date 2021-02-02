using System;

namespace EmployeeWageComputationNameSpace
{
    class EmployeeWageComputation
    {
        private const float EmpWagePerHour = 20;
        private const int FullTime_WorkingHrs_PerDay = 8;
        private const int PartTime_WorkingHrs_PerDay = 4;
        private const int MAX_WORKING_HRS = 100;
        private const int MAX_WORKING_DAYS = 20;
        private const int IS_FULL_TIME = 1;
        private const int IS_PART_TIME = 2;
        private const int IS_ABSENT = 0;
        float EmpDailyWage = 0;
        private float TotalWage = 0;

        private int IsEmployeePresent() {
            return new Random().Next() % 3;
        }

        public void CalculateWage() {
            
            int DayNumber = 1;
            int EmpWorkinghHrs = 0;
            int TotalWorkingHrs = 0;
            while (DayNumber <= MAX_WORKING_DAYS && TotalWorkingHrs <= MAX_WORKING_HRS) {
                switch (IsEmployeePresent()) {
                    case IS_ABSENT:
                        EmpWorkinghHrs = 0;
                        break;
                    case IS_PART_TIME:
                        EmpWorkinghHrs = PartTime_WorkingHrs_PerDay;
                        break;
                    case IS_FULL_TIME:
                        EmpWorkinghHrs = FullTime_WorkingHrs_PerDay;
                        break;
                }
                EmpDailyWage = EmpWorkinghHrs * EmpWagePerHour;

                TotalWage += EmpDailyWage;
                DayNumber++;
                TotalWorkingHrs += EmpWorkinghHrs;
            }
            Console.WriteLine("Total working days :"+ (DayNumber-1) +"\nTotal working hours :"+ TotalWorkingHrs + "\nTotal employee wage :"+ TotalWage);
        }

        static void Main(string[] args)
        {
            EmployeeWageComputation employeeWageComputation = new  EmployeeWageComputation();
            Console.WriteLine("Welcome to Employee Wage Computation");

            employeeWageComputation.CalculateWage();
        }
    }
}
