using System;

class Search2DMatrix
{
    static void Main()
    {
        int[,] matrix = {
            {1, 3, 5},
            {7, 9, 11}
        };

        int target = 9;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == target)
                {
                    Console.WriteLine("Found at row " + i + " col " + j);
                }
            }
        }
    }
}
