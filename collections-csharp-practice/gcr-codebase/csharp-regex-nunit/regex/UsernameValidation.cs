using System;
using System.Text.RegularExpressions;

class UsernameValidation
{
    static void Main()
    {
        string pattern = @"^[A-Za-z][A-Za-z0-9_]{4,14}$";

        string[] usernames = { "user_123", "123user", "us", "ValidUser_1" };

        for (int i = 0; i < usernames.Length; i++)
        {
            if (Regex.IsMatch(usernames[i], pattern))
                Console.WriteLine(usernames[i] + " → Valid");
            else
                Console.WriteLine(usernames[i] + " → Invalid");
        }
    }
}
