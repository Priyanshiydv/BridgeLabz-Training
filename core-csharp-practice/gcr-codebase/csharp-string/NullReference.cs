using System;

class NullReference {
    public static void DemonstrateNullReference()
    {
        try
        {
            string text = null;
            Console.WriteLine(text.Length); // Exception
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("NullReferenceException caught: " + ex.Message);
        }
    }

    static void Main()
    {
        DemonstrateNullReference();
    }
}
