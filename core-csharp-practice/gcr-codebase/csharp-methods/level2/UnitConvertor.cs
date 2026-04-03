using System;

class UnitConvertor
{
    public static double ConvertKmToMiles(double km)
    {
        return km * 0.621371;
    }

    public static double ConvertMilesToKm(double miles)
    {
        return miles * 1.60934;
    }

    public static double ConvertMetersToFeet(double meters)
    {
        return meters * 3.28084;
    }

    public static double ConvertFeetToMeters(double feet)
    {
        return feet * 0.3048;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("10 Km in Miles: " + ConvertKmToMiles(10));
        Console.WriteLine("10 Miles in Km: " + ConvertMilesToKm(10));
        Console.WriteLine("10 Meters in Feet: " + ConvertMetersToFeet(10));
        Console.WriteLine("10 Feet in Meters: " + ConvertFeetToMeters(10));
    }
}
