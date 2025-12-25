using System;

class NumberChecker5
{
    public static int[] GetFactors(int n)
    {
        int count = 0;
        for (int i = 1; i <= n; i++)
            if (n % i == 0) count++;

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= n; i++)
            if (n % i == 0) factors[index++] = i;

        return factors;
    }

    public static int SumFactors(int[] f)
    {
        int sum = 0;
        for (int i = 0; i < f.Length - 1; i++)
            sum += f[i];
        return sum;
    }

    public static bool IsPerfect(int n, int[] f)
    {
        return SumFactors(f) == n;
    }

    public static bool IsStrong(int n)
    {
        int temp = n, sum = 0;
        while (temp > 0)
        {
            int d = temp % 10;
            int fact = 1;
            for (int i = 1; i <= d; i++) fact *= i;
            sum += fact;
            temp /= 10;
        }
        return sum == n;
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] factors = GetFactors(n);

        Console.WriteLine(IsPerfect(n, factors) ? "Perfect" : "Not Perfect");
        Console.WriteLine(SumFactors(factors) > n ? "Abundant" : "Not Abundant");
        Console.WriteLine(SumFactors(factors) < n ? "Deficient" : "Not Deficient");
        Console.WriteLine(IsStrong(n) ? "Strong" : "Not Strong");
    }
}
