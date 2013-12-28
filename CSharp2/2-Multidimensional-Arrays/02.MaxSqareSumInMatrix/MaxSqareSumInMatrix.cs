using System;
using Matrices;

class MaxSqareSumInMatrix
{
    static void Main()
    {
        Console.Write("Please enter rows: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Please enter cols: ");
        int M = int.Parse(Console.ReadLine());

        int[,] matrix = new int[N, M];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            string[] row = Console.ReadLine().Split(' ');
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = int.Parse(row[j]);
            }
        }

        PrintMatrices.PrintMatrix(matrix);

        int squareField = 3;
        int squareSum = 0;
        int squareSumBest = int.MinValue;
        int[,] squareMatrix = new int[squareField, squareField];
        int[,] bestSquareMatrix = new int[squareField, squareField];

        for (int matrixRow = 0; matrixRow < matrix.GetLength(0) - squareField; matrixRow++)
        {
            for (int matrixCol = 0; matrixCol < matrix.GetLength(1) - squareField; matrixCol++)
            {
                for (int squareRow = matrixRow; squareRow < matrixRow + squareField; squareRow++)
                {
                    for (int squareCol = matrixCol; squareCol < matrixCol + squareField; squareCol++)
                    {
                        squareSum += matrix[squareRow, squareCol];
                        squareMatrix[squareRow - matrixRow, squareCol -  matrixCol] = matrix[squareRow, squareCol];
                    }
                }
                if (squareSum > squareSumBest)
                {
                    squareSumBest = squareSum;
                    bestSquareMatrix = (int[,])squareMatrix.Clone();
                }
                squareSum = int.MinValue;
            }
        }

        PrintMatrices.PrintMatrix(bestSquareMatrix);
        Console.WriteLine("Max sum: {0}", squareSumBest);

    }
}
