using System;
using System.Collections.Generic;

class LongestConsecutive
{
    static void FindLongest(int[] arr)
    {
        HashSet<int> set = new HashSet<int>();
        int longest = 0;

        for (int i = 0; i < arr.Length; i++)
            set.Add(arr[i]);

        for (int i = 0; i < arr.Length; i++)
        {
            if (!set.Contains(arr[i] - 1))
            {
                int current = arr[i];
                int count = 1;

                while (set.Contains(current + 1))
                {
                    current++;
                    count++;
                }

                longest = Math.Max(longest, count);
            }
        }

        Console.WriteLine("Longest consecutive sequence length: " + longest);
    }

    static void Main()
    {
        int[] arr = { 100, 4, 200, 1, 3, 2 };
        FindLongest(arr);
    }
}
