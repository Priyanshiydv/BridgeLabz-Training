using System;
using System.Collections.Generic;

class ZeroSumSubarrays
{
    static void FindSubarrays(int[] arr)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int sum = 0;

        map[0] = 1; // important for subarrays starting at index 0

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            if (map.ContainsKey(sum))
            {
                Console.WriteLine("Zero sum subarray found ending at index " + i);
                map[sum]++;
            }
            else
            {
                map[sum] = 1;
            }
        }
    }

    static void Main()
    {
        int[] arr = { 3, 4, -7, 1, 3, -4, -2, -2 };
        FindSubarrays(arr);
    }
}
