using System;

class NaturalNumberSum
{
    public static int RecursiveSum(int n)
    {
        if (n == 0)
            return 0;
        return n + RecursiveSum(n - 1);
    }

    public static int FormulaSum(int n)
    {
        return n * (n + 1) / 2;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a natural number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Not a natural number");
            return;
        }

        int recursiveResult = RecursiveSum(number);
        int formulaResult = FormulaSum(number);

        Console.WriteLine("Sum using recursion: " + recursiveResult);
        Console.WriteLine("Sum using formula: " + formulaResult);

        if (recursiveResult == formulaResult)
            Console.WriteLine("Both results are correct and equal");
    }
}
