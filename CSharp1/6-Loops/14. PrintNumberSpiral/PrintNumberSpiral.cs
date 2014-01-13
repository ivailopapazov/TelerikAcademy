using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintNumberSpiral
{
    static void Main()
    {
        // User input
        int N = 0;
        Console.Write("Please enter positive number N < 20: ");
        if (!int.TryParse(Console.ReadLine(), out N) || N < 0 || N > 19)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        // Variable Declaration
        int[,] matrix = new int[N, N];
        int num = 1;

        // Filling the matrix with values
        for (int frame = 0; frame < (N + 1) / 2; frame++)
        {
            // Declare position variables
            int row = frame;
            int col = frame;

            // Top row loop
            while (col < N - frame)
            {
                matrix[row, col] = num;
                num++;
                col++;
            }
            col--;

            // Left column loop
            row++;
            while (row < N - frame)
            {
                matrix[row, col] = num;
                num++;
                row++;
            }
            row--;

            // Bottom row loop
            while (col > frame)
            {
                col--;
                matrix[row, col] = num;
                num++;
            }

            // Right column loop
            while (row > frame + 1)
            {
                row--;
                matrix[row, col] = num;
                num++;
            }
        }

        // Printing the matrix
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("{0, 4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
