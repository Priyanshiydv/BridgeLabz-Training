using System;

class DateComparer
{
    // Method to compare two dates
    public static string CompareDates(DateTime firstDate, DateTime secondDate)
    {
        int result = DateTime.Compare(firstDate, secondDate);

        if (result < 0)
            return "First date is before the second date";
        else if (result > 0)
            return "First date is after the second date";
        else
            return "Both dates are the same";
    }

    static void Main()
    {
        Console.Write("Enter first date (yyyy-MM-dd): ");
        DateTime date1 = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter second date (yyyy-MM-dd): ");
        DateTime date2 = DateTime.Parse(Console.ReadLine());

        Console.WriteLine(CompareDates(date1, date2));
    }
}
