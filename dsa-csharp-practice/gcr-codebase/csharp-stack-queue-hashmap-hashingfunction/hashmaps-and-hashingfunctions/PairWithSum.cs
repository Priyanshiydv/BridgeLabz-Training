using System;
using System.Collections.Generic;

class PairWithSum
{
    static void CheckPair(int[] arr, int target)
    {
        Dictionary<int, bool> map = new Dictionary<int, bool>();

        for (int i = 0; i < arr.Length; i++)
        {
            int needed = target - arr[i];

            if (map.ContainsKey(needed))
            {
                Console.WriteLine("Pair found: " + arr[i] + " and " + needed);
                return;
            }

            map[arr[i]] = true;
        }

        Console.WriteLine("No pair found");
    }

    static void Main()
    {
        int[] arr = { 8, 7, 2, 5, 3, 1 };
        CheckPair(arr, 10);
    }
}
