using System;
using System.IO;
using System.Text;

class FileReadingComparison
{
    static void Main()
    {
        string filePath = "largefile.txt"; // assume large file exists

        // -------- Using StreamReader --------
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                reader.ReadLine();
            }
        }
        Console.WriteLine("StreamReader reading completed");

        // -------- Using FileStream --------
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[4096];
            while (fs.Read(buffer, 0, buffer.Length) > 0)
            {
                // reading bytes
            }
        }
        Console.WriteLine("FileStream reading completed");
    }
}
