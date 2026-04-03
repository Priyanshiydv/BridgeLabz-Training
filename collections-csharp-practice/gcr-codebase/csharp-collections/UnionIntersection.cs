using System;
using System.Collections.Generic;

class UnionIntersection
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int>() { 3, 4, 5 };

        HashSet<int> union = new HashSet<int>(set1);
        HashSet<int> intersection = new HashSet<int>();

        int[] arr = new int[set2.Count];
        set2.CopyTo(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            union.Add(arr[i]);

            if (set1.Contains(arr[i]))
                intersection.Add(arr[i]);
        }

        Console.Write("Union: ");
        PrintSet(union);

        Console.Write("Intersection: ");
        PrintSet(intersection);
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
