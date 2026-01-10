using System;

class InsertionSortEmployeeIds
{
    static void Main()
    {
        int[] empIds = { 104, 102, 109, 101, 105 };

        for (int i = 1; i < empIds.Length; i++)
        {
            int key = empIds[i];
            int j = i - 1;

            while (j >= 0 && empIds[j] > key)
            {
                empIds[j + 1] = empIds[j];
                j--;
            }
            empIds[j + 1] = key;
        }

        Console.WriteLine("Sorted Employee IDs:");
        PrintArray(empIds);
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
    }
}
