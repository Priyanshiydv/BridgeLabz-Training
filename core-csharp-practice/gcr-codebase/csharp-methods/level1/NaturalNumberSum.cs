using System;

class NaturalNumberSum
{
    // Method to calculate sum
    public static int CalculateSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = CalculateSum(number);

        Console.WriteLine("Sum of natural numbers: " + result);
    }
}
