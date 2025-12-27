using System;

class CheckAnagram
{
    
    public static bool AreAnagrams(string first, string second)
    {
        if (first.Length != second.Length)
            return false;

        int[] frequency = new int[256];

        for (int i = 0; i < first.Length; i++)
        {
            frequency[first[i]]++;
            frequency[second[i]]--;
        }

        for (int i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] != 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        if (AreAnagrams(str1, str2))
            Console.WriteLine("Strings are anagrams");
        else
            Console.WriteLine("Strings are not anagrams");
    }
}
