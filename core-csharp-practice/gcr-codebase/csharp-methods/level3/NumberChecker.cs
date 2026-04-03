using System;

class NumberChecker
{
    // Method to count digits
    public static int CountDigits(int number)
    {
        int count = 0;
        while (number > 0)
        {
            count++;
            number = number / 10;
        }
        return count;
    }

    // Method to store digits in array
    public static int[] GetDigits(int number)
    {
        int count = CountDigits(number);
        int[] digits = new int[count];

        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number = number / 10;
        }
        return digits;
    }

    // Duck number check (contains zero)
    public static bool IsDuckNumber(int[] digits)
    {
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] == 0)
                return true;
        }
        return false;
    }

    // Armstrong number check
    public static bool IsArmstrong(int number, int[] digits)
    {
        int sum = 0;
        int power = digits.Length;

        for (int i = 0; i < digits.Length; i++)
        {
            sum = sum + (int)Math.Pow(digits[i], power);
        }
        return sum == number;
    }

    // Largest and second largest
    public static void FindLargest(int[] digits)
    {
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        Console.WriteLine("Largest Digit: " + largest);
        Console.WriteLine("Second Largest Digit: " + secondLargest);
    }

    // Smallest and second smallest
    public static void FindSmallest(int[] digits)
    {
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;

        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] < smallest)
            {
                secondSmallest = smallest;
                smallest = digits[i];
            }
            else if (digits[i] < secondSmallest && digits[i] != smallest)
            {
                secondSmallest = digits[i];
            }
        }

        Console.WriteLine("Smallest Digit: " + smallest);
        Console.WriteLine("Second Smallest Digit: " + secondSmallest);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] digits = GetDigits(number);

        Console.WriteLine("Digit Count: " + digits.Length);
        Console.WriteLine(IsDuckNumber(digits) ? "Duck Number" : "Not a Duck Number");
        Console.WriteLine(IsArmstrong(number, digits) ? "Armstrong Number" : "Not an Armstrong Number");

        FindLargest(digits);
        FindSmallest(digits);
    }
}
