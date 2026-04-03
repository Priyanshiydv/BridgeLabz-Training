using System;
class FactorialWhile
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            int fact = 1;
            int i = 1;

            while (i <= n)
            {
                fact *= i;
                i++;
            }

            Console.WriteLine($"Factorial of {n} is {fact}");
        }
    }
}
