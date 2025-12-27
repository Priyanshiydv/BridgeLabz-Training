using System;

class CheckPrime
{
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(IsPrime(num) ? "Prime Number" : "Not a Prime Number");
    }
}
