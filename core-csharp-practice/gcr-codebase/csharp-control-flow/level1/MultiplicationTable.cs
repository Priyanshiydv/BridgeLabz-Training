using System;
class MultiplicationTable
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{n} * {i} = {n * i}");
        }
    }
}
