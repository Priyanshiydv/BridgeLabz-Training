using System;
using System.Text.RegularExpressions;

class HexColorValidation
{
    static void Main()
    {
        string pattern = @"^#[0-9A-Fa-f]{6}$";

        string[] colors = { "#FFA500", "#ff4500", "#123", "#A1B2C3" };

        for (int i = 0; i < colors.Length; i++)
        {
            if (Regex.IsMatch(colors[i], pattern))
                Console.WriteLine(colors[i] + " → Valid");
            else
                Console.WriteLine(colors[i] + " → Invalid");
        }
    }
}
