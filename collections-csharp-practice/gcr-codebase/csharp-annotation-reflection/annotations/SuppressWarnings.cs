using System;
using System.Collections;

class SuppressWarnings
{
    static void Main()
    {
#pragma warning disable 0618   // Example warning disable
#pragma warning disable 0168   // Unused variable warning

        ArrayList list = new ArrayList();  // Non-generic collection
        list.Add(10);
        list.Add("Hello");

#pragma warning restore 0618
#pragma warning restore 0168

        Console.WriteLine("Warnings suppressed successfully!");
    }
}
