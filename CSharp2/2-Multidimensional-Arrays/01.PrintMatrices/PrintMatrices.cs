using System;

class PrintMatrices
{
    static void Main()
    {
        // User Input
        Console.Write("Please enter N: ");
        int n = int.Parse(Console.ReadLine());

        // Variable Declaration
        int[,] matrix = new int[n, n];
        int count = 1;

        // Generate Matrix A
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, j] = count;
                count++;
            }
        }

        // Print Matrix A
        PrintMatrix(matrix);

        // Generate Matrix B
        count = 1;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, j] = count;
                count++;
            }
            if (j + 1 < matrix.GetLength(1))
            {
                j++;
                for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
                {
                    matrix[i, j] = count;
                    count++;
                }
            }
            
        }
        PrintMatrix(matrix);

        // Matrix C
        count = 1;
        for (int k = matrix.GetLength(0) - 1; k >= 0; k--)
        {
            for (int i = k, j = 0; i < matrix.GetLength(0); i++, j++)
            {
                matrix[i, j] = count;
                count++;
            }
        }
        for (int k = 1; k < matrix.GetLength(1); k++)
        {
            for (int j = k, i = 0; j < matrix.GetLength(1); j++, i++)
            {
                matrix[i, j] = count;
                count++;
            }
        }
        PrintMatrix(matrix);
    }
    static void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine(new string('-', matrix.GetLength(0) * 4));
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0, -4}", matrix[i,j]);
            }
            Console.WriteLine();
        }
    }
}
