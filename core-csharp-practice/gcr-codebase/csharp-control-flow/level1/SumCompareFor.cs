using System;
class SumCompareFor
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            int sumFor = 0;

            for (int i = 1; i <= n; i++)
                sumFor += i;

            int sumFormula = n * (n + 1) / 2;

            Console.WriteLine($"Sum using for loop: {sumFor}");
            Console.WriteLine($"Sum using formula: {sumFormula}");
        }
    }
}
