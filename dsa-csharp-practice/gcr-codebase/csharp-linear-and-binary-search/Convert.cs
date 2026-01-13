using System;
using System.IO;
using System.Text;

class Convert  //byte stream to character stream
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("sample.txt", Encoding.UTF8))
        {
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}
