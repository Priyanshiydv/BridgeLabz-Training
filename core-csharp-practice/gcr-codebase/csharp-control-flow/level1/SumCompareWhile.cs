using System;
class SumCompareWhile
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            int sumWhile = 0;
            int i = 1;

            while (i <= n)
            {
                sumWhile += i;
                i++;
            }

            int sumFormula = n * (n + 1) / 2;

            Console.WriteLine($"Sum using while loop: {sumWhile}");
            Console.WriteLine($"Sum using formula: {sumFormula}");
        }
    }
}
