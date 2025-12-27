using System;

class DateFormatter
{
    // Method to display date in multiple formats
    public static void DisplayFormattedDates(DateTime date)
    {
        Console.WriteLine("dd/MM/yyyy       : " + date.ToString("dd/MM/yyyy"));
        Console.WriteLine("yyyy-MM-dd       : " + date.ToString("yyyy-MM-dd"));
        Console.WriteLine("EEE, MMM dd, yyyy: " + date.ToString("ddd, MMM dd, yyyy"));
    }

    static void Main()
    {
        DateTime currentDate = DateTime.Now;
        DisplayFormattedDates(currentDate);
    }
}
