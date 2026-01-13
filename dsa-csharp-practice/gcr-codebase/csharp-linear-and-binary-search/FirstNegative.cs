using System;

class FirstNegative
{
    static void Main()
    {
        int[] arr = { 5, 3, -2, 7, -8 };

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                Console.WriteLine("First Negative: " + arr[i]);
                break;
            }
        }
    }
}
