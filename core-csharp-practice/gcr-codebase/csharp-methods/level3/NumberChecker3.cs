using System;

class NumberChecker3
{
    public static int[] GetDigits(int num)
    {
        int count = 0, temp = num;
        while (temp > 0) { count++; temp /= 10; }

        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = num % 10;
            num /= 10;
        }
        return digits;
    }

    public static int[] ReverseArray(int[] digits)
    {
        int[] rev = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++)
        {
            rev[i] = digits[digits.Length - 1 - i];
        }
        return rev;
    }

    public static bool CompareArrays(int[] a, int[] b)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i]) return false;
        }
        return true;
    }

    public static bool IsDuck(int[] digits)
    {
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] == 0) return true;
        }
        return false;
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] digits = GetDigits(number);
        int[] reversed = ReverseArray(digits);

        Console.WriteLine(CompareArrays(digits, reversed) ? "Palindrome" : "Not Palindrome");
        Console.WriteLine(IsDuck(digits) ? "Duck Number" : "Not Duck Number");
    }
}
