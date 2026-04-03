using System;
using System.IO;
using System.Diagnostics;

class BufferedStreams
{
    static void Main()
    {
        string sourceFile = "source.txt";
        string unbufferedFile = "unbuffered_copy.txt";
        string bufferedFile = "buffered_copy.txt";

        byte[] buffer = new byte[4096];

        try
        {
            // ---------- Unbuffered FileStream ----------
            Stopwatch sw = new Stopwatch();
            sw.Start();

            FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
            FileStream fsWrite = new FileStream(unbufferedFile, FileMode.Create, FileAccess.Write);

            int bytesRead;
            while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                fsWrite.Write(buffer, 0, bytesRead);
            }

            fsRead.Close();
            fsWrite.Close();

            sw.Stop();
            Console.WriteLine("Unbuffered Time: " + sw.ElapsedMilliseconds + " ms");

            // ---------- BufferedStream ----------
            sw.Reset();
            sw.Start();

            BufferedStream bsRead =
                new BufferedStream(new FileStream(sourceFile, FileMode.Open, FileAccess.Read));

            BufferedStream bsWrite =
                new BufferedStream(new FileStream(bufferedFile, FileMode.Create, FileAccess.Write));

            while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                bsWrite.Write(buffer, 0, bytesRead);
            }

            bsRead.Close();
            bsWrite.Close();

            sw.Stop();
            Console.WriteLine("Buffered Time: " + sw.ElapsedMilliseconds + " ms");
        }
        catch (IOException e)
        {
            Console.WriteLine("IO Error: " + e.Message);
        }
    }
}
