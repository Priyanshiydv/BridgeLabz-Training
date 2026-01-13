using System;

class FirstMissingPositive
{
    static void Main()
    {
        int[] arr = { 3, 4, -1, 1 };

        bool[] present = new bool[arr.Length + 1];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0 && arr[i] <= arr.Length)
            {
                present[arr[i]] = true;
            }
        }

        for (int i = 1; i < present.Length; i++)
        {
            if (!present[i])
            {
                Console.WriteLine("Missing Positive: " + i);
                break;
            }
        }
    }
}
