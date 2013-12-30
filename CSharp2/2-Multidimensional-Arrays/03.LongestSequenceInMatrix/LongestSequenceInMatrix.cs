using System;

class LongestSequenceInMatrix
{
    static string bestElement = string.Empty;
    static int bestCount = 0;

    static void Main()
    {
        // User Input
        Console.Write("Please enter rows: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Please enter cols: ");
        int M = int.Parse(Console.ReadLine());

        // Parse Matrix
        string[,] stringMatrix = new string[N, M];
        for (int i = 0; i < stringMatrix.GetLength(0); i++)
        {
            string[] row = Console.ReadLine().Split(' ');
            for (int j = 0; j < stringMatrix.GetLength(1); j++)
            {
                stringMatrix[i, j] = row[j];
            }
        }

        // Traverse the array
        for (int i = 0; i < stringMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < stringMatrix.GetLength(1); j++)
            {
                SearchMatrix(stringMatrix, i, j);
            }
        }

        // Print Result
        Console.WriteLine("Element - {0}, count - {1}", bestElement, bestCount);
    }
    static void SearchMatrix(string[,] stringMatrix, int row, int col, int rowNext, int colNext)
    {
        string currentElement = stringMatrix[row, col];
        int currentCount = 1;
        row += rowNext;
        col += colNext;

        // While in range
        while (row >= 0 && col >= 0 && row < stringMatrix.GetLength(0) && col < stringMatrix.GetLength(1))
        {
            if (currentElement != stringMatrix[row, col])
            {
                break;
            }
            row += rowNext;
            col += colNext;
            currentCount++;
        }

        if (currentCount > bestCount)
        {
            bestElement = currentElement;
            bestCount = currentCount;
        }
    }

    static void SearchMatrix(string[,] stringMatrix, int row, int col)
    {
        // Left diagonal
        SearchMatrix(stringMatrix, row, col, 1, -1);
        // Down
        SearchMatrix(stringMatrix, row, col, 1, 0);
        // Right diagonal
        SearchMatrix(stringMatrix, row, col, 1, 1);
        // Right
        SearchMatrix(stringMatrix, row, col, 0, 1);
    }
}
