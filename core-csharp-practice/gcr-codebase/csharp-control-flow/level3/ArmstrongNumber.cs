using System;

class ArmstrongNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int originalNumber = number;
        int sum = 0;

        // Loop until originalNumber becomes 0
        while (originalNumber != 0)
        {
            int remainder = originalNumber % 10;   // Get last digit
            sum += remainder * remainder * remainder; // Cube and add
            originalNumber = originalNumber / 10;  // Remove last digit
        }

        if (sum == number)
            Console.WriteLine($"{number} is an Armstrong Number");
        else
            Console.WriteLine($"{number} is NOT an Armstrong Number");
    }
}
