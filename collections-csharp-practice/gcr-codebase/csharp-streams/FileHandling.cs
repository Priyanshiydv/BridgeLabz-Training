using System;
using System.IO;

class FileHandling
{
    static void Main()
    {
        string sourceFile = "source.txt";
        string destinationFile = "destination.txt";

        try
        {
            // Step 1: Check if source file exists
            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            // Step 2: Open FileStream for reading
            FileStream readStream =
                new FileStream(sourceFile, FileMode.Open, FileAccess.Read);

            // Step 3: Open FileStream for writing
            FileStream writeStream =
                new FileStream(destinationFile, FileMode.Create, FileAccess.Write);

            // Step 4: Read byte by byte and write
            int data;
            while ((data = readStream.ReadByte()) != -1)
            {
                writeStream.WriteByte((byte)data);
            }

            // Step 5: Close streams
            readStream.Close();
            writeStream.Close();

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException e)
        {
            Console.WriteLine("IO Error: " + e.Message);
        }
    }
}
