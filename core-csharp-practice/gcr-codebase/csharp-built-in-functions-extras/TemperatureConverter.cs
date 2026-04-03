using System;

class TemperatureConverter
{
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static void Main()
    {
        Console.Write("Enter temperature: ");
        double temp = double.Parse(Console.ReadLine());

        Console.Write("Convert to (C/F): ");
        char choice = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (choice == 'C' || choice == 'c')
            Console.WriteLine("Celsius: " + FahrenheitToCelsius(temp));
        else
            Console.WriteLine("Fahrenheit: " + CelsiusToFahrenheit(temp));
    }
}
