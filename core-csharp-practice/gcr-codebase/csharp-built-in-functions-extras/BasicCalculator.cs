using System;

class BasicCalculator
{
    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b) => a / b;

    static void Main()
    {
        Console.Write("Enter two numbers: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        Console.Write("Choose operation (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double result = 0;

        if (op == '+') result = Add(a, b);
        else if (op == '-') result = Subtract(a, b);
        else if (op == '*') result = Multiply(a, b);
        else if (op == '/') result = Divide(a, b);

        Console.WriteLine("Result: " + result);
    }
}
