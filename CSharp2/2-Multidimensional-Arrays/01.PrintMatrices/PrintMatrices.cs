﻿using System;

namespace Matrices
{
    public class PrintMatrices
    {
        static void Main()
        {
            // User Input
            Console.Write("Please enter N: ");
            int n = int.Parse(Console.ReadLine());

            // Variable Declaration
            int[,] matrix = new int[n, n];
            int count = 1;

            // Matrix A
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    matrix[i, j] = count;
                    count++;
                }
            }
            PrintMatrix(matrix);

            // Matrix B
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

            // Matrix D
            count = 1;
            int frames = (n + 1) / 2;
            for (int frame = 0; frame < frames; frame++)
            {
                int i = frame;
                int j = frame;
                // South Movement
                while (i < matrix.GetLength(0) - frame)
                {
                    matrix[i, j] = count;
                    count++;
                    i++;
                }
                i--;
                j++;

                // East Movement
                while (j < matrix.GetLength(1) - frame)
                {
                    matrix[i, j] = count;
                    count++;
                    j++;
                }
                j--;
                i--;

                // North Movement
                while (i >= frame)
                {
                    matrix[i, j] = count;
                    count++;
                    i--;
                }
                i++;
                j--;

                // West Movement
                while (j > frame)
                {
                    matrix[i, j] = count;
                    count++;
                    j--;
                }
            }
            PrintMatrix(matrix);
        }
        public static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine(new string('-', matrix.GetLength(0) * 4));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, -4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}