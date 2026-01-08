using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    sealed class EmployeeMenu
    {
        private IEmployee employeeUtility;

        public EmployeeMenu()
        {
            employeeUtility = new EmployeeUtilityImpl();
        }

        public void Start()
        {
            int choice;

            do
            {
                Console.WriteLine("\n---- Employee Wage Menu ----");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Check Attendance");
                Console.WriteLine("3. Calculate Daily Wage");
                Console.WriteLine("4. Calculate Part Time Wage");
                Console.WriteLine("5. Calculate Wage Using Switch");
                Console.WriteLine("6. Calculate Monthly Wage");
                Console.WriteLine("7. Calculate Wage Till Condition");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        employeeUtility.AddEmployee();
                        break;

                    case 2:
                        employeeUtility.CheckAttendance();
                        break;

                    case 3:
                        employeeUtility.CalculateDailyWage();
                        break;

                    case 4:
                        employeeUtility.CalculatePartTimeWage();
                        break;

                    case 5:
                        employeeUtility.CalculateWageUsingSwitch();
                        break;

                    case 6:
                        employeeUtility.CalculateMonthlyWage();
                        break;

                    case 7:
                        employeeUtility.CalculateWageTillCondition();
                        break;

                    case 0:
                        Console.WriteLine("Exiting Program...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice! Try Again.");
                        break;
                }

            } while (choice != 0);
        }
    }
}
