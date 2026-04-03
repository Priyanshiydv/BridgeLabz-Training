using System;
class BasicCalculator
{
    static void Main(string[] args)
    {
        double num1;
        double num2;
        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        double addition = num1 + num2;
        double subtraction = num1 - num2;
        double multiplication = num1 * num2;
        double division = num1 / num2;
        Console.WriteLine(
            "The addition, subtraction, multiplication and division value of 2 numbers "
            + num1 + " and " + num2 + " is "
            + addition + ", " + subtraction + ", " + multiplication + ", and " + division
        );
    }
}
