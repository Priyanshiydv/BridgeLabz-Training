using System;

class FibonacciComparison
{
    // Recursive Fibonacci - O(2^N)
    static int FibonacciRecursive(int n)
    {
        if (n <= 1)
            return n;

        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    // Iterative Fibonacci - O(N)
    static int FibonacciIterative(int n)
    {
        if (n <= 1)
            return n;

        int a = 0, b = 1, sum = 0;

        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }

    static void Main()
    {
        int n = 10;

        Console.WriteLine("Recursive Fibonacci:");
        Console.WriteLine(FibonacciRecursive(n));

        Console.WriteLine("Iterative Fibonacci:");
        Console.WriteLine(FibonacciIterative(n));
    }
}
