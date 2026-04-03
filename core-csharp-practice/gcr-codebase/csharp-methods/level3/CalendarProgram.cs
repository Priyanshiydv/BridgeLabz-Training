using System;

class CalendarProgram
{
    // Get Month Name
    public static string GetMonthName(int month)
    {
        string[] months =
        {
            "", "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };
        return months[month];
    }

    // Check Leap Year
    public static bool IsLeapYear(int year)
    {
        if (year % 400 == 0) return true;
        if (year % 100 == 0) return false;
        return year % 4 == 0;
    }

    // Get Number of Days in Month
    public static int GetDaysInMonth(int month, int year)
    {
        int[] days = { 0,31,28,31,30,31,30,31,31,30,31,30,31 };

        if (month == 2 && IsLeapYear(year))
            return 29;

        return days[month];
    }

    // Get First Day of Month (Gregorian Algorithm)
    public static int GetFirstDay(int month, int year)
    {
        int d = 1;
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;
        return d0;
    }

    static void Main()
    {
        Console.Write("Enter Month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n   " + GetMonthName(month) + " " + year);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        int firstDay = GetFirstDay(month, year);
        int days = GetDaysInMonth(month, year);

        // Indentation before 1st day
        for (int i = 0; i < firstDay; i++)
            Console.Write("    ");

        // Print days
        for (int day = 1; day <= days; day++)
        {
            Console.Write(day.ToString().PadLeft(3) + " ");

            if ((day + firstDay) % 7 == 0)
                Console.WriteLine();
        }
    }
}
