using System;

class FactorsProgram
{
    // Method to find factors and return array
    public static int[] FindFactors(int number)
    {
        int count = 0;

        // First loop to count factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                count++;
        }

        int[] factors = new int[count];
        int index = 0;

        // Second loop to store factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    public static int FindSum(int[] factors)
    {
        int sum = 0;
        foreach (int value in factors)
            sum += value;
        return sum;
    }

    public static int FindProduct(int[] factors)
    {
        int product = 1;
        foreach (int value in factors)
            product *= value;
        return product;
    }

    public static double FindSumOfSquares(int[] factors)
    {
        double sum = 0;
        foreach (int value in factors)
            sum += Math.Pow(value, 2);
        return sum;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] factors = FindFactors(number);

        Console.WriteLine("Factors:");
        foreach (int value in factors)
            Console.Write(value + " ");

        Console.WriteLine("\nSum of factors: " + FindSum(factors));
        Console.WriteLine("Product of factors: " + FindProduct(factors));
        Console.WriteLine("Sum of squares of factors: " + FindSumOfSquares(factors));
    }
}
