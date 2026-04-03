using System;

class FestivalLuckyDraw
{
    static void Main()
    {
        Console.WriteLine(" Diwali Festival Lucky Draw ");

        int visitorCount = 1;

        // Loop for multiple visitors
        while (visitorCount <= 5)
        {
            Console.WriteLine("Visitor " + visitorCount + ", enter your lucky number:");

            int number;

            // Check if input is valid number
            bool isValid = int.TryParse(Console.ReadLine(), out number);

            if (!isValid)
            {
                Console.WriteLine("Invalid input! Try again.");
                continue;   // Skip to next loop iteration
            }

            // Check divisibility by 3 and 5
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Congratulations! You won a gift!");
            }
            else
            {
                Console.WriteLine("Sorry, no gift this time.");
            }

            visitorCount++;
        }

        Console.WriteLine("Lucky draw finished!");
    }
}
