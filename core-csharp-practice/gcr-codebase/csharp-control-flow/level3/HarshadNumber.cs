using System;

class HarshadNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int originalNumber = number;
        int sum = 0;

        while (number != 0)
        {
            int digit = number % 10;
            sum += digit;
            number = number / 10;
        }

        if (originalNumber % sum == 0)
            Console.WriteLine($"{originalNumber} is a Harshad Number");
        else
            Console.WriteLine($"{originalNumber} is NOT a Harshad Number");
    }
}
