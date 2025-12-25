using System;

class NumberAnalysis
{
    public static bool IsPositive(int number)
    {
        return number > 0;
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static int Compare(int number1, int number2)
    {
        if (number1 > number2) return 1;
        if (number1 < number2) return -1;
        return 0;
    }

    static void Main(string[] args)
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());

            if (IsPositive(numbers[i]))
            {
                if (IsEven(numbers[i]))
                    Console.WriteLine("Positive Even");
                else
                    Console.WriteLine("Positive Odd");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }

        int result = Compare(numbers[0], numbers[4]);

        if (result == 1)
            Console.WriteLine("First element is greater than last");
        else if (result == -1)
            Console.WriteLine("First element is less than last");
        else
            Console.WriteLine("First and last elements are equal");
    }
}
