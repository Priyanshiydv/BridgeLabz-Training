using System;

class Palindrome
{
    static bool IsPalindrome(string text)
    {
        int left = 0, right = text.Length - 1;

        while (left < right)
        {
            if (text[left] != text[right])
                return false;
            left++;
            right--;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine(IsPalindrome(input) ? "Palindrome" : "Not Palindrome");
    }
}
