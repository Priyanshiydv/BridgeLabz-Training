using System;

class TimeZoneDisplay
{
    // Method to display current time in a given time zone
    public static void DisplayTime(string timeZoneId, string zoneName)
    {
        TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        DateTimeOffset currentTime = TimeZoneInfo.ConvertTime(DateTimeOffset.UtcNow, timeZone);

        Console.WriteLine($"{zoneName} Time: {currentTime}");
    }

    static void Main()
    {
        DisplayTime("GMT Standard Time", "GMT");
        DisplayTime("India Standard Time", "IST");
        DisplayTime("Pacific Standard Time", "PST");
    }
}
