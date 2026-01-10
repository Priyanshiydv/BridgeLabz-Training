using System;

class SelectionSortExamScores
{
    static void Main()
    {
        int[] scores = { 78, 55, 90, 66, 85 };

        for (int i = 0; i < scores.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < scores.Length; j++)
            {
                if (scores[j] < scores[minIndex])
                    minIndex = j;
            }

            int temp = scores[i];
            scores[i] = scores[minIndex];
            scores[minIndex] = temp;
        }

        Console.WriteLine("Sorted Exam Scores:");
        PrintArray(scores);
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
    }
}
