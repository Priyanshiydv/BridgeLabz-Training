using System;
using System.IO;

class ReadFile
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("sample.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
