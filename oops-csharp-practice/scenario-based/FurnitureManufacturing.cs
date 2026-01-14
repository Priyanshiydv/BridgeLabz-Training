using System;

class FurnitureManufacturing
{
    // Dynamic Programming solution
    static int MaxEarnings(int length, int[] price)
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

    static void Main()
    {
        Console.WriteLine("=== Custom Furniture Manufacturing ===");

        int rodLength = 12;
        int[] price = { 2, 5, 7, 8, 10, 13, 17, 18, 22, 25, 30, 35 };

        // Scenario A
        Console.WriteLine("Scenario A - Maximum Earnings: ₹" +
            MaxEarnings(rodLength, price));

        // Scenario B - Waste constraint (2 ft wasted)
        int usableLength = rodLength - 2;
        Console.WriteLine("Scenario B - With Waste Constraint: ₹" +
            MaxEarnings(usableLength, price));

        // Scenario C - Optimized with minimal waste
        Console.WriteLine("Scenario C - Best Revenue with Less Waste: ₹" +
            MaxEarnings(usableLength, price));

        Console.ReadLine();
    }
}
