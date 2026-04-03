using System;

class BubbleSortStudentMarks
{
    static void Main()
    {
        int[] marks = { 65, 85, 45, 90, 70 };

        Console.WriteLine("Before Sorting:");
        PrintArray(marks);

        // Bubble Sort logic
        for (int i = 0; i < marks.Length - 1; i++)
        {
            for (int j = 0; j < marks.Length - i - 1; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    // swap
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nAfter Sorting:");
        PrintArray(marks);
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
    }
}
