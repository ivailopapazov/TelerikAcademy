using System;
using System.IO;

class MaxSubMatrix
{    
    // File path constants
    const string InputFilePath = @"../../input.txt";
    const string OutputFilePath = @"../../output.txt";

    static void Main()
    {
        // Matrix declaration
        int[,] matrix;

        // Parse input matrix
        using (StreamReader input = new StreamReader(InputFilePath))
        {
            // Read first line
            string line = input.ReadLine();

            // Parse n
            int size = int.Parse(line);

            // Initialize matrix
            matrix = new int[size, size];

            // Matrix rows
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                // Read next line
                line = input.ReadLine();

                // Split line by numbers
                string[] lineNumbers = line.Split(' ');

                // Matrix cols
                for (int col = 0; col < lineNumbers.Length; col++)
                {
                    matrix[row, col] = int.Parse(lineNumbers[col]);
                }
            }
        }

        // Search for best sum of 2x2 sub matrix
        int bestSum = 0;

        // Matrix tranversal
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                // Calculate sum of sub matrix
                int currentSum = matrix[row, col] + matrix[row, col + 1];
                currentSum += matrix[row + 1, col] + matrix[row + 1, col + 1];

                // Compare to best sum
                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                }
            }
        }

        // Write bestsum to outputfile
        using (StreamWriter output = new StreamWriter(OutputFilePath))
        {
            output.WriteLine(bestSum);
        }

        // Print best sum
        Console.WriteLine(bestSum);
    }
}
