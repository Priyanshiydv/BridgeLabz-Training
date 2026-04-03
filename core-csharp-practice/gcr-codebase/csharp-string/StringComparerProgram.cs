using System;

//26-12-2025
class StringComparerProgram
{
    // Method to compare two strings using charAt
    public static bool CompareStringsUsingCharAt(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false;

        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
                return false;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine();

        bool customResult = CompareStringsUsingCharAt(s1, s2);
        bool builtInResult = string.Equals(s1, s2);

        Console.WriteLine($"Custom Comparison Result: {customResult}");
        Console.WriteLine($"Built-in Equals Result: {builtInResult}");
    }
}
