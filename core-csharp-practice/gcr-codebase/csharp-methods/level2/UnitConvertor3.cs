using System;

class UnitConvertor3
{
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double ConvertPoundsToKilograms(double pounds)
    {
        return pounds * 0.453592;
    }

    public static double ConvertKilogramsToPounds(double kilograms)
    {
        return kilograms * 2.20462;
    }

    public static double ConvertGallonsToLiters(double gallons)
    {
        return gallons * 3.78541;
    }

    public static double ConvertLitersToGallons(double liters)
    {
        return liters * 0.264172;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("100 F to C: " + ConvertFahrenheitToCelsius(100));
        Console.WriteLine("37 C to F: " + ConvertCelsiusToFahrenheit(37));
        Console.WriteLine("10 Pounds to Kg: " + ConvertPoundsToKilograms(10));
        Console.WriteLine("5 Kg to Pounds: " + ConvertKilogramsToPounds(5));
        Console.WriteLine("2 Gallons to Liters: " + ConvertGallonsToLiters(2));
        Console.WriteLine("5 Liters to Gallons: " + ConvertLitersToGallons(5));
    }
}
