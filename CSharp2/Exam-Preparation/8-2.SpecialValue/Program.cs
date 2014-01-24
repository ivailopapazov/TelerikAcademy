using System;
using System.Collections.Generic;

// http://bgcoder.com/Contests/Submissions/View/295456

namespace _8_2.SpecialValue
{
    class Program
    {
        static int[] ReadLine()
        {
            string[] line = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            return Array.ConvertAll(line, int.Parse);

        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[][] numbers = new int[num][];
            bool[][] visited = new bool[num][];


            for (int i = 0; i < num; i++)
            {
                numbers[i] = ReadLine();
                visited[i] = new bool[numbers[i].Length];
            }

            // Variables
            ulong specialValueMax = ulong.MinValue;
            ulong specialValue;

            // Solution
            for (int i = 0; i < numbers[0].Length; i++)
            {
                Unvisit(visited);
                specialValue = TraverseNumbers(numbers, visited, i);
                if (specialValue > specialValueMax)
                {
                    specialValueMax = specialValue;
                }
            }

            // Print
            Console.WriteLine(specialValueMax);
        }

        static void Unvisit(bool[][] visited)
        {
            for (int i = 0; i < visited.Length; i++)
            {
                for (int j = 0; j < visited[i].Length; j++)
                {
                    visited[i][j] = false;
                }
            }
        }

        static ulong TraverseNumbers(int[][] numbers, bool[][] visited, int index)
        {
            // Variables
            int currentRow = 0;
            int row = 1;

            while (true)
            {
                if (numbers[currentRow][index] < 0)
                {
                    // Negative
                    return (ulong)(row + (-numbers[currentRow][index]));
                }
                else if (visited[currentRow][index])
                {
                    return ulong.MinValue;
                }
                else
                {
                    // Positive
                    visited[currentRow][index] = true;
                    index = numbers[currentRow][index];
                    currentRow = row % numbers.Length;
                    row++; 
                }
            }
        }
    }
}
