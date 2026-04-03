using System;
class QuotientRemainder
{
    static void Main(string[] args)
    {
        int num1, num2;
        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        int quotient = num1 / num2;
        int remainder = num1 % num2;

        Console.WriteLine(
            "The Quotient is " + quotient +
            " and Remainder is " + remainder +
            " of two numbers " + num1 + " and " + num2
        );
    }
}
