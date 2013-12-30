using System;

class LongestSequenceInMatrix
{
    static string bestElement = string.Empty;
    static int bestCount = 0;

    static void Main()
    {
        string[,] stringMatrix = new string[,]
        {
            {"as", "sd", "ds", "fd", "szx"},
            {"ds", "as", "sdsd", "ssdd", "sdsd"},
            {"as", "sdd", "sa", "sdsd", "zsd"},
            {"sd", "sd", "sd", "as", "sdsd"}
        };

        for (int i = 0; i < stringMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < stringMatrix.GetLength(1); j++)
            {
                SearchMatrix(stringMatrix, i, j);
            }
        }

        Console.WriteLine("{0} {1}", bestElement, bestCount);
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
