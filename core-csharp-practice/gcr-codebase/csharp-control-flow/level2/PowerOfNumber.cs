using System;
class PowerOfNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter power: ");
        int power = int.Parse(Console.ReadLine());

        int result = 1;

        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }

        Console.WriteLine($"{number}^{power} = {result}");
    }
}
