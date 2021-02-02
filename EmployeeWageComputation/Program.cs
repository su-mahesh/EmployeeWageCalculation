using System;

namespace EmployeeWageComputationNameSpace
{
    class EmployeeWageComputation
    {
        private const float EmpWagePerHour = 20;
        private const int FullTimeWorkingHrsPerDay = 8;
        private const int PartTimeWorkingHrsPerDay = 4;
        private int IsEmployeePresent() {
            return new Random().Next() % 3;
        }

        public void CalculateDailyWage() {
            float EmpDailyWage = 0;
            if (IsEmployeePresent() == 1)
                EmpDailyWage = FullTimeWorkingHrsPerDay * EmpWagePerHour;
            else if (IsEmployeePresent() == 2)
                EmpDailyWage = PartTimeWorkingHrsPerDay * EmpWagePerHour;
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
