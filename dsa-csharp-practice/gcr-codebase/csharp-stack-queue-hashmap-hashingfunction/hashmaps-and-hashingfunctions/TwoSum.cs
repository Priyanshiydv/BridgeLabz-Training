using System;
using System.Collections.Generic;

class TwoSum
{
    static void FindTwoSum(int[] arr, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            int needed = target - arr[i];

            if (map.ContainsKey(needed))
            {
                Console.WriteLine("Indices: " + map[needed] + " and " + i);
                return;
            }

            map[arr[i]] = i;
        }

        Console.WriteLine("No solution found");
    }

    static void Main()
    {
        int[] arr = { 2, 7, 11, 15 };
        FindTwoSum(arr, 9);
    }
}
