using System;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading;

class PipeStream
{
    static void Main()
    {
        try
        {
            // Create pipe server (writer)
            using (AnonymousPipeServerStream pipeServer =
                   new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
            {
                // Create pipe client (reader)
                using (AnonymousPipeClientStream pipeClient =
                       new AnonymousPipeClientStream(PipeDirection.In, pipeServer.ClientSafePipeHandle))
                {
                    // Writer thread
                    Thread writerThread = new Thread(() =>
                    {
                        using (StreamWriter writer = new StreamWriter(pipeServer))
                        {
                            writer.AutoFlush = true;
                            writer.WriteLine("Hello from Writer Thread");
                            writer.WriteLine("This is Pipe Stream");
                            writer.WriteLine("End");
                        }
                    });

                    // Reader thread
                    Thread readerThread = new Thread(() =>
                    {
                        using (StreamReader reader = new StreamReader(pipeClient))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                Console.WriteLine("Reader received: " + line);
                            }
                        }
                    });

                    // Start threads
                    readerThread.Start();
                    writerThread.Start();

                    // Wait for completion
                    writerThread.Join();
                    readerThread.Join();
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Pipe error: " + e.Message);
        }
    }
}
