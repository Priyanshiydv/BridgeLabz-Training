using System;
class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        Console.WriteLine(isPrime
            ? $"{number} is a Prime Number"
            : $"{number} is NOT a Prime Number");
    }
}
