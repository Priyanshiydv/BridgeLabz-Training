using System;

class Factors
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Factors are:");

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
