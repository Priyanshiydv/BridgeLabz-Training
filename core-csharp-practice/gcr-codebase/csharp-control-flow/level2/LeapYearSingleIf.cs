using System;

class LeapYearSingleIf
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        if (year >= 1582 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
        {
            Console.WriteLine($"{year} is a Leap Year");
        }
        else
        {
            Console.WriteLine($"{year} is NOT a Leap Year");
        }
    }
}
