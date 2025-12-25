using System;

class NumberChecker4
{
    public static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= n / 2; i++)
            if (n % i == 0) return false;
        return true;
    }

    public static bool IsNeon(int n)
    {
        int sq = n * n, sum = 0;
        while (sq > 0)
        {
            sum += sq % 10;
            sq /= 10;
        }
        return sum == n;
    }

    public static bool IsSpy(int n)
    {
        int sum = 0, prod = 1;
        while (n > 0)
        {
            int d = n % 10;
            sum += d;
            prod *= d;
            n /= 10;
        }
        return sum == prod;
    }

    public static bool IsAutomorphic(int n)
    {
        int sq = n * n;
        return sq % 10 == n % 10;
    }

    public static bool IsBuzz(int n)
    {
        return (n % 7 == 0 || n % 10 == 7);
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(IsPrime(n) ? "Prime" : "Not Prime");
        Console.WriteLine(IsNeon(n) ? "Neon" : "Not Neon");
        Console.WriteLine(IsSpy(n) ? "Spy" : "Not Spy");
        Console.WriteLine(IsAutomorphic(n) ? "Automorphic" : "Not Automorphic");
        Console.WriteLine(IsBuzz(n) ? "Buzz" : "Not Buzz");
    }
}
