using System;

class ArrayIndexException
{
    public static void AccessInvalidArrayIndex()
    {
        try
        {
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[5]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("IndexOutOfRangeException caught: " + ex.Message);
        }
    }

    static void Main()
    {
        AccessInvalidArrayIndex();
    }
}
