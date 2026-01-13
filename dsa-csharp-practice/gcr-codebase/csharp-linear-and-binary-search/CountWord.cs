using System;
using System.IO;

class Program
{
    static void Main()
    {
        int count = 0;
        string word = "hello";

        using (StreamReader reader = new StreamReader("sample.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.ToLower().Contains(word.ToLower()))
                {
                    count++;
                }
            }
        }

        Console.WriteLine("Word count: " + count);
    }
}
