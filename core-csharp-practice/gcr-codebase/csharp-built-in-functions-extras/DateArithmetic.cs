using System;

class DateArithmetic
{
    // Method to perform date arithmetic
    public static DateTime CalculateNewDate(DateTime inputDate)
    {
        DateTime result = inputDate
                            .AddDays(7)
                            .AddMonths(1)
                            .AddYears(2)
                            .AddDays(-21); // 3 weeks = 21 days

        return result;
    }

    static void Main()
    {
        Console.Write("Enter a date (yyyy-MM-dd): ");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());

        DateTime finalDate = CalculateNewDate(inputDate);
        Console.WriteLine("Final Date: " + finalDate.ToString("yyyy-MM-dd"));
    }
}
