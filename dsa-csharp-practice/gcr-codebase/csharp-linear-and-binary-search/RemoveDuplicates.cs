using System;
using System.Text;

class RemoveDuplicates
{
    static void Main()
    {
        string input = "programming";
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            // If character not already added
            if (!sb.ToString().Contains(input[i]))
            {
                sb.Append(input[i]);
            }
        }

        Console.WriteLine("Without Duplicates: " + sb.ToString());
    }
}
