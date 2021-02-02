using System;

namespace EmployeeWageComputationNameSpace
{
    class EmployeeWageComputation
    {
        private const float EmpWagePerHour = 20;
        private const int WorkingHoursPerDay = 8;
        private int IsEmployeePresent() {
            return new Random().Next() % 2;
        }

        public void CheckEmployeeAttendance() { 
            if (IsEmployeePresent() == 1)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }

        public void CalculateDailyWage() {
            float EmpDailyWage = 0;
            if (IsEmployeePresent() == 1)
                EmpDailyWage = WorkingHoursPerDay * EmpWagePerHour;
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
