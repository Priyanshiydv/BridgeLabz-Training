using System;
class GreatestFactor
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        int greatestFactor = 1;

        for (int i = n - 1; i >= 1; i--)
        {
            if (n % i == 0)
            {
                greatestFactor = i;
                break;
            }
        }

        Console.WriteLine($"Greatest factor of {n} (besides itself) is {greatestFactor}");
    }
}
