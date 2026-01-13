using System;
using System.Text;

class Concatenate
{
    static void Main()
    {
        string[] words = { "Hello", " ", "World", "!" };
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < words.Length; i++)
        {
            sb.Append(words[i]);
        }

        Console.WriteLine("Result: " + sb.ToString());
    }
}
