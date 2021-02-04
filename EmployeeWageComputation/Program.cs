using System;

namespace EmployeeWageComputationNameSpace
{
    class EmployeeWageComputation
    {
        private float EmpWagePerHour = 20;
        private int FullTime_WorkingHrs_PerDay = 8;
        private int PartTime_WorkingHrs_PerDay = 4;
        private int MAX_WORKING_HRS = 100;
        private int MAX_WORKING_DAYS = 20;
        private const int IS_FULL_TIME = 1;
        private const int IS_PART_TIME = 2;
        private const int IS_ABSENT = 0;
        float EmpDailyWage = 0;
        private float TotalWage = 0;

        public EmployeeWageComputation(int EmpWagePerHour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHrs_PerDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS)
        {
            this.EmpWagePerHour = EmpWagePerHour;
            this.FullTime_WorkingHrs_PerDay = FullTime_WorkingHrs_PerDay;
            this.PartTime_WorkingHrs_PerDay = PartTime_WorkingHrs_PerDay;
            this.MAX_WORKING_HRS = MAX_WORKING_HRS;
            this.MAX_WORKING_DAYS = MAX_WORKING_DAYS;
        }

        private int IsEmployeePresent() {
            return new Random().Next(0, 3);
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
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmployeeWageComputation employeeWageComputation = new EmployeeWageComputation(20, 8, 4, 100, 20);
            employeeWageComputation.CalculateWage();
        }
    }
}
