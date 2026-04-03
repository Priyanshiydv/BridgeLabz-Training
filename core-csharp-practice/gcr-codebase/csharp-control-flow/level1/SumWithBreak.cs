using System;
class SumWithBreak
{
    static void Main()
    {
        double total = 0;

        while (true)
        {
            Console.Write("Enter a number: ");
            double num = double.Parse(Console.ReadLine());

            if (num <= 0)
                break;

            total += num;
        }

        Console.WriteLine($"Total sum is {total}");
    }
}
