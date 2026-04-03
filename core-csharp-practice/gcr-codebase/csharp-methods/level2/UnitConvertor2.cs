using System;

class UnitConvertor2
{
    public static double ConvertYardsToFeet(double yards)
    {
        return yards * 3;
    }

    public static double ConvertFeetToYards(double feet)
    {
        return feet * 0.333333;
    }

    public static double ConvertMetersToInches(double meters)
    {
        return meters * 39.3701;
    }

    public static double ConvertInchesToMeters(double inches)
    {
        return inches * 0.0254;
    }

    public static double ConvertInchesToCentimeters(double inches)
    {
        return inches * 2.54;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("5 Yards to Feet: " + ConvertYardsToFeet(5));
        Console.WriteLine("6 Feet to Yards: " + ConvertFeetToYards(6));
        Console.WriteLine("2 Meters to Inches: " + ConvertMetersToInches(2));
        Console.WriteLine("20 Inches to Meters: " + ConvertInchesToMeters(20));
        Console.WriteLine("10 Inches to CM: " + ConvertInchesToCentimeters(10));
    }
}
