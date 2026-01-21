using System;
using System.IO;
using System.Text;

class UpperToLower
{
    static void Main()
    {
        string inputFile = "input.txt";
        string outputFile = "output.txt";

        try
        {
            // Buffered stream for efficient reading
            using (FileStream fsRead = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
            using (BufferedStream bsRead = new BufferedStream(fsRead))
            using (StreamReader reader = new StreamReader(bsRead))
            // Buffered stream for efficient writing
            using (FileStream fsWrite = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
            using (BufferedStream bsWrite = new BufferedStream(fsWrite))
            using (StreamWriter writer = new StreamWriter(bsWrite))
            {
                string line;

                // Read line by line
                while ((line = reader.ReadLine()) != null)
                {
                    // Convert uppercase to lowercase
                    writer.WriteLine(line.ToLower());
                }
            }

            Console.WriteLine("File converted to lowercase successfully.");
        }
        catch (IOException e)
        {
            Console.WriteLine("File error: " + e.Message);
        }
    }
}
