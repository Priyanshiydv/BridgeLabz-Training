using System;
using System.Text;

class ComparePerformance
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < 10000; i++)
        {
            sb.Append("A");
        }

        Console.WriteLine("StringBuilder Length: " + sb.Length);
    }
}
