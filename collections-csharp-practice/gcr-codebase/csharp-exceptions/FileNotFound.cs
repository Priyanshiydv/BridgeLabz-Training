using System;
using System.IO;

class FileNotFound
{
    static void Main()
    {
        try
        {
            using (StreamReader reader = new StreamReader("data.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (IOException)
        {
            Console.WriteLine("File not found");
        }
    }
}
