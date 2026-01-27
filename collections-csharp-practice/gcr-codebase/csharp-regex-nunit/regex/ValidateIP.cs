using System;
using System.Text.RegularExpressions;

class ValidateIP
{
    static void Main()
    {
        string pattern = @"^((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)\.){3}(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)$";

        string[] ips = { "192.168.1.1", "256.100.50.0", "10.0.0.255" };

        for (int i = 0; i < ips.Length; i++)
        {
            if (Regex.IsMatch(ips[i], pattern))
                Console.WriteLine(ips[i] + " → Valid");
            else
                Console.WriteLine(ips[i] + " → Invalid");
        }
    }
}
