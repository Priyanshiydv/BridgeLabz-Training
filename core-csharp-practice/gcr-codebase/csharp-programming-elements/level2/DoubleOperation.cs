using System;
class DoubleOperation
{
    static void Main(string[] args)
    {
        double a, b, c;
        Console.Write("Enter a: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter b: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter c: ");
        c = Convert.ToDouble(Console.ReadLine());

        double result1 = a + b * c;
        double result2 = a * b + c;
        double result3 = c + a / b;
        double result4 = a % b + c;

        Console.WriteLine(
            "The results of Double Operations are " +
            result1 + ", " + result2 + ", " + result3 + ", and " + result4
        );
    }
}
