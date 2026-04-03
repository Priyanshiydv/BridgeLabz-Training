using System;
class CelsiusToFahrenheit
{
    static void Main(string[] args)
    {
        double celsius;
        Console.Write("Enter temperature in Celsius: ");
        celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine(
            "The " + celsius + " Celsius is " + fahrenheit + " Fahrenheit"
        );
    }
}
