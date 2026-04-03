using System;

class NumberChecker2
{
    public static int CountDigits(int num)
    {
        int count = 0;
        while (num > 0)
        {
            count++;
            num /= 10;
        }
        return count;
    }

    public static int[] GetDigits(int num)
    {
        int count = CountDigits(num);
        int[] digits = new int[count];

        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = num % 10;
            num /= 10;
        }
        return digits;
    }

    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sum += digits[i];
        }
        return sum;
    }

    public static int SumOfSquares(int[] digits)
    {
        int sum = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sum += (int)Math.Pow(digits[i], 2);
        }
        return sum;
    }

    public static bool IsHarshad(int number, int[] digits)
    {
        int sum = SumOfDigits(digits);
        return number % sum == 0;
    }

    public static void DigitFrequency(int[] digits)
    {
        int[,] freq = new int[10, 2];

        for (int i = 0; i < 10; i++)
        {
            freq[i, 0] = i;
            freq[i, 1] = 0;
        }

        for (int i = 0; i < digits.Length; i++)
        {
            freq[digits[i], 1]++;
        }

        Console.WriteLine("Digit  Frequency");
        for (int i = 0; i < 10; i++)
        {
            if (freq[i, 1] > 0)
                Console.WriteLine(freq[i, 0] + "      " + freq[i, 1]);
        }
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] digits = GetDigits(number);

        Console.WriteLine("Sum of Digits: " + SumOfDigits(digits));
        Console.WriteLine("Sum of Squares: " + SumOfSquares(digits));
        Console.WriteLine(IsHarshad(number, digits) ? "Harshad Number" : "Not Harshad");

        DigitFrequency(digits);
    }
}
