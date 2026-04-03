using System;

class RemoveDuplicate
{
    public static string RemoveDuplicates(string s)
    {
        string result = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (!result.Contains(s[i]))
                result += s[i];
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("After Removing Duplicates: " + RemoveDuplicates(input));
    }
}
