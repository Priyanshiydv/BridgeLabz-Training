using System;

class MatrixOperations
{
    // a. Create Random Matrix
    public static double[,] CreateRandomMatrix(int rows, int cols)
    {
        double[,] matrix = new double[rows, cols];
        Random rand = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rand.Next(1, 10); // small numbers
            }
        }
        return matrix;
    }

    // b. Add Two Matrices
    public static double[,] AddMatrix(double[,] A, double[,] B)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = A[i, j] + B[i, j];
            }
        }
        return result;
    }

    // c. Subtract Two Matrices
    public static double[,] SubtractMatrix(double[,] A, double[,] B)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = A[i, j] - B[i, j];
            }
        }
        return result;
    }

    // d. Multiply Two Matrices
    public static double[,] MultiplyMatrix(double[,] A, double[,] B)
    {
        int rowsA = A.GetLength(0);
        int colsA = A.GetLength(1);
        int colsB = B.GetLength(1);

        double[,] result = new double[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < colsA; k++)
                {
                    result[i, j] += A[i, k] * B[k, j];
                }
            }
        }
        return result;
    }

    // Transpose of Matrix
    public static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] result = new double[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[j, i] = matrix[i, j];
            }
        }
        return result;
    }

    // e. Determinant of 2x2 Matrix
    public static double Determinant2x2(double[,] m)
    {
        return (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);
    }

    // f. Determinant of 3x3 Matrix
    public static double Determinant3x3(double[,] m)
    {
        double det =
            m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) -
            m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0]) +
            m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);

        return det;
    }

    // g. Inverse of 2x2 Matrix
    public static double[,] Inverse2x2(double[,] m)
    {
        double det = Determinant2x2(m);
        double[,] inv = new double[2, 2];

        inv[0, 0] = m[1, 1] / det;
        inv[0, 1] = -m[0, 1] / det;
        inv[1, 0] = -m[1, 0] / det;
        inv[1, 1] = m[0, 0] / det;

        return inv;
    }

    // h. Inverse of 3x3 Matrix
    public static double[,] Inverse3x3(double[,] m)
    {
        double det = Determinant3x3(m);
        double[,] inv = new double[3, 3];

        inv[0, 0] = (m[1,1]*m[2,2]-m[1,2]*m[2,1]) / det;
        inv[0, 1] = (m[0,2]*m[2,1]-m[0,1]*m[2,2]) / det;
        inv[0, 2] = (m[0,1]*m[1,2]-m[0,2]*m[1,1]) / det;

        inv[1, 0] = (m[1,2]*m[2,0]-m[1,0]*m[2,2]) / det;
        inv[1, 1] = (m[0,0]*m[2,2]-m[0,2]*m[2,0]) / det;
        inv[1, 2] = (m[0,2]*m[1,0]-m[0,0]*m[1,2]) / det;

        inv[2, 0] = (m[1,0]*m[2,1]-m[1,1]*m[2,0]) / det;
        inv[2, 1] = (m[0,1]*m[2,0]-m[0,0]*m[2,1]) / det;
        inv[2, 2] = (m[0,0]*m[1,1]-m[0,1]*m[1,0]) / det;

        return inv;
    }

    // i. Display Matrix
    public static void DisplayMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main()
    {
        double[,] A = CreateRandomMatrix(3, 3);
        double[,] B = CreateRandomMatrix(3, 3);

        Console.WriteLine("Matrix A:");
        DisplayMatrix(A);

        Console.WriteLine("Matrix B:");
        DisplayMatrix(B);

        Console.WriteLine("Addition:");
        DisplayMatrix(AddMatrix(A, B));

        Console.WriteLine("Subtraction:");
        DisplayMatrix(SubtractMatrix(A, B));

        Console.WriteLine("Multiplication:");
        DisplayMatrix(MultiplyMatrix(A, B));

        Console.WriteLine("Transpose of A:");
        DisplayMatrix(Transpose(A));

        Console.WriteLine("Determinant of A (3x3): " + Determinant3x3(A));

        Console.WriteLine("Inverse of A:");
        DisplayMatrix(Inverse3x3(A));
    }
}
