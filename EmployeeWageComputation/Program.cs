using System;

namespace EmployeeWageComputationNameSpace
{
    class EmployeeWageComputation
    {
        private const float EmpWagePerHour = 20;
        private const int FullTimeWorkingHrsPerDay = 8;
        private const int PartTimeWorkingHrsPerDay = 4;
        private const int IS_FULL_TIME = 1;
        private const int IS_PART_TIME = 2;

        private int IsEmployeePresent() {
            return new Random().Next() % 3;
        }

        public void CalculateDailyWage() {
            float EmpDailyWage = 0;

            switch (IsEmployeePresent()) {
                case IS_PART_TIME:
                    EmpDailyWage = PartTimeWorkingHrsPerDay * EmpWagePerHour;
                    break;
                case IS_FULL_TIME:
                    EmpDailyWage = FullTimeWorkingHrsPerDay * EmpWagePerHour;
                    break;
            }

            Console.WriteLine("Employee Daily :"+EmpDailyWage);
        }

        static void Main(string[] args)
        {
            EmployeeWageComputation employeeWageComputation = new  EmployeeWageComputation();
            Console.WriteLine("Welcome to Employee Wage Computation");

            employeeWageComputation.CalculateDailyWage();
        }
    }
}
