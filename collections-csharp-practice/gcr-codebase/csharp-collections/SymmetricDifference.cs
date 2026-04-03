using System;
using System.Collections.Generic;

class SymmetricDifference
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int>() { 3, 4, 5 };

        HashSet<int> result = new HashSet<int>();

        int[] arr1 = new int[set1.Count];
        int[] arr2 = new int[set2.Count];

        set1.CopyTo(arr1);
        set2.CopyTo(arr2);

        for (int i = 0; i < arr1.Length; i++)
        {
            if (!set2.Contains(arr1[i]))
                result.Add(arr1[i]);
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            if (!set1.Contains(arr2[i]))
                result.Add(arr2[i]);
        }

        Console.Write("Symmetric Difference: ");
        PrintSet(result);
    }

    static void PrintSet(HashSet<int> set)
    {
        int[] arr = new int[set.Count];
        set.CopyTo(arr);

        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");

        Console.WriteLine();
    }
}
