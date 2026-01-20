using System;
using System.Collections.Generic;

class FindSubset
{
    static void Main()
    {
        HashSet<int> subset = new HashSet<int>() { 2, 3 };
        HashSet<int> mainSet = new HashSet<int>() { 1, 2, 3, 4 };

        bool isSubset = true;

        int[] arr = new int[subset.Count];
        subset.CopyTo(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            if (!mainSet.Contains(arr[i]))
            {
                isSubset = false;
                break;
            }
        }

        Console.WriteLine("Is Subset: " + isSubset);
    }
}
