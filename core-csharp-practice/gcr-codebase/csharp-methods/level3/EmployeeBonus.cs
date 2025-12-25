using System;

class EmployeeBonus
{
    // Method to generate old salary and years of service
    // salary[0] -> Old Salary
    // salary[1] -> Years of Service
    public static int[,] GenerateEmployeeData(int employees)
    {
        int[,] data = new int[employees, 2];
        Random rand = new Random();

        for (int i = 0; i < employees; i++)
        {
            // 5-digit salary (10000 to 99999)
            data[i, 0] = rand.Next(10000, 100000);

            // Years of service (1 to 10)
            data[i, 1] = rand.Next(1, 11);
        }

        return data;
    }

    // Method to calculate new salary and bonus
    // result[0] -> New Salary
    // result[1] -> Bonus Amount
    public static double[,] CalculateBonus(int[,] data, int employees)
    {
        double[,] result = new double[employees, 2];

        for (int i = 0; i < employees; i++)
        {
            int oldSalary = data[i, 0];
            int years = data[i, 1];
            double bonus;

            if (years > 5)
                bonus = oldSalary * 0.05;
            else
                bonus = oldSalary * 0.02;

            result[i, 1] = bonus;
            result[i, 0] = oldSalary + bonus;
        }

        return result;
    }

    // Method to display table and totals
    public static void DisplaySummary(int[,] data, double[,] result, int employees)
    {
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;

        Console.WriteLine("Emp\tOldSalary\tYears\tBonus\t\tNewSalary");
        Console.WriteLine("------------------------------------------------------");

        for (int i = 0; i < employees; i++)
        {
            Console.WriteLine(
                (i + 1) + "\t" +
                data[i, 0] + "\t\t" +
                data[i, 1] + "\t" +
                result[i, 1] + "\t" +
                result[i, 0]
            );

            totalOldSalary += data[i, 0];
            totalBonus += result[i, 1];
            totalNewSalary += result[i, 0];
        }

        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("Total Old Salary : " + totalOldSalary);
        Console.WriteLine("Total Bonus      : " + totalBonus);
        Console.WriteLine("Total New Salary : " + totalNewSalary);
    }

    static void Main()
    {
        int employees = 10;

        int[,] employeeData = GenerateEmployeeData(employees);
        double[,] salaryData = CalculateBonus(employeeData, employees);
        DisplaySummary(employeeData, salaryData, employees);
    }
}
