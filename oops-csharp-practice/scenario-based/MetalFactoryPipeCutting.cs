using System;

class MetalFactoryPipeCutting
{
    // Optimized solution using Dynamic Programming
    static int MaxRevenue(int length, int[] price)
    {
        int[] dp = new int[length + 1];
        dp[0] = 0;

        for (int i = 1; i <= length; i++)
        {
            int max = int.MinValue;

            for (int j = 0; j < i; j++)
            {
                max = Math.Max(max, price[j] + dp[i - j - 1]);
            }

            dp[i] = max;
        }

        return dp[length];
    }

    // Non-optimized (simple cutting)
    static int NonOptimizedRevenue(int length, int pricePerUnit)
    {
        return length * pricePerUnit;
    }

    static void Main()
    {
        Console.WriteLine("=== Metal Factory Pipe Cutting ===");

        int rodLength = 8;
        int[] price = { 1, 5, 8, 9, 10, 17, 17, 20 };

        // Scenario A
        Console.WriteLine("Scenario A - Optimized Revenue: ₹" +
            MaxRevenue(rodLength, price));

        // Scenario B - Custom length price change
        price[7] = 25; // custom price for length 8
        Console.WriteLine("Scenario B - After Custom Order: ₹" +
            MaxRevenue(rodLength, price));

        // Scenario C - Non-optimized strategy
        Console.WriteLine("Scenario C - Non-Optimized Revenue: ₹" +
            NonOptimizedRevenue(rodLength, price[0]));

        Console.ReadLine();
    }
}
