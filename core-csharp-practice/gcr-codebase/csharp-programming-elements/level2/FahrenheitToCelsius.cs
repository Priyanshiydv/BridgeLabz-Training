using System;
class FahrenheitToCelsius
{
    static void Main(string[] args)
    {
        double fahrenheit;
        Console.Write("Enter temperature in Fahrenheit: ");
        fahrenheit = Convert.ToDouble(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine(
            "The " + fahrenheit + " Fahrenheit is " + celsius + " Celsius"
        );
    }
}
