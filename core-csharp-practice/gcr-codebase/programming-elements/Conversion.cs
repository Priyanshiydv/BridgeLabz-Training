using System;
class Conversion
{
    static void Main(string[] args)
    {
        float celsius = 50.0f;
        float fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
    }
}
