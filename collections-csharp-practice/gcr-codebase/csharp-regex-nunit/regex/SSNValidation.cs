using System;
using System.Text.RegularExpressions;

class SSNValidation
{
    static void Main()
    {
        string pattern = @"^\d{3}-\d{2}-\d{4}$";

        string[] ssns = { "123-45-6789", "123456789" };

        for (int i = 0; i < ssns.Length; i++)
        {
            if (Regex.IsMatch(ssns[i], pattern))
                Console.WriteLine(ssns[i] + " → Valid");
            else
                Console.WriteLine(ssns[i] + " → Invalid");
        }
    }
}
