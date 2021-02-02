using System;

namespace EmployeeWageComputationNameSpace
{
    class EmployeeWageComputation
    {
        private int IsEmployeePresent() {
            return new Random().Next() % 2;
        }

        public void CheckEmployeeAttendance() { 
            if (IsEmployeePresent() == 1)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }

        static void Main(string[] args)
        {
            EmployeeWageComputation employeeWageComputation = new  EmployeeWageComputation();
            Console.WriteLine("Welcome to Employee Wage Computation");

            employeeWageComputation.CheckEmployeeAttendance();
        }
    }
}
