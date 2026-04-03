using System;

class NumberCheck
{
    // Method to check number 
    public static int CheckNumber(int number)
    {
        if (number > 0)
            return 1;
        else if (number < 0)
            return -1;
        else
            return 0;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = CheckNumber(number);

        Console.WriteLine("Result: " + result);
    }
}
