using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _3.Digits
{
    class Program
    {
        static int[,] m;
        static int result = 0;
        static void ScanOne(int row, int col)
        {
            if (
                    1 == m[row,col+2]  &&
                    1 == m[row+1,col+1]  &&
                    1 == m[row+1,col+2]  &&
                    1 == m[row+2,col]   &&
                    1 == m[row+2,col+2]  &&
                    1 == m[row+3,col+2]  &&
                    1 == m[row+4,col+2]
                )
            {
                result += 1;
            }
        }
        static void ScanTwo(int row, int col)
        {
            if (
                    2 == m[row, col+1] &&
                    2 == m[row+1, col] &&
                    2 == m[row+1, col+2] &&
                    2 == m[row+2, col+2] &&
                    2 == m[row+3, col+1] &&
                    2 == m[row+4, col] &&
                    2 == m[row+4, col+1] &&
                    2 == m[row+4, col+2]
                )
            {
                result += 2;
            }
        }
        static void ScanThree(int row, int col)
        {
            if (
                    3 == m[row, col + 2] &&
                    3 == m[row+1, col + 2] &&
                    3 == m[row+2, col + 2] &&
                    3 == m[row+3, col + 2] &&
                    3 == m[row+4, col + 2] &&
                    3 == m[row, col + 1] &&
                    3 == m[row+2, col + 1] &&
                    3 == m[row+4, col + 1] &&
                    3 == m[row, col] &&
                    3 == m[row+4, col]
                )
            {
                result += 3;
            }
        }
        static void ScanFour(int row, int col)
        {
            if (
                    4 == m[row, col] &&
                    4 == m[row+1, col] &&
                    4 == m[row+2, col] &&
                    4 == m[row+2, col+1] &&
                    4 == m[row, col+2] &&
                    4 == m[row+1, col+2] &&
                    4 == m[row+2, col+2] &&
                    4 == m[row+3, col+2] &&
                    4 == m[row+4, col+2]
                )
            {
                result += 4;
            }
        }
        static void ScanFive(int row, int col)
        {
            if (
                    5 == m[row, col] &&
                    5 == m[row, col+1] &&
                    5 == m[row, col+2] &&
                    5 == m[row+1, col] &&
                    5 == m[row+2, col] &&
                    5 == m[row+2, col+1] &&
                    5 == m[row+2, col+2] &&
                    5 == m[row+3, col+2] &&
                    5 == m[row+4, col] &&
                    5 == m[row+4, col+1] &&
                    5 == m[row+4, col+2]
                )
            {
                result += 5;
            }
        }
        static void ScanSix(int row, int col)
        {
            if (
                    6 == m[row, col] &&
                    6 == m[row, col+1] &&
                    6 == m[row, col+2] &&
                    6 == m[row+1, col] &&
                    6 == m[row+2, col] &&
                    6 == m[row+2, col+1] &&
                    6 == m[row+2, col+2] &&
                    6 == m[row+3, col] &&
                    6 == m[row+3, col+2] &&
                    6 == m[row+4, col] &&
                    6 == m[row+4, col+1] &&
                    6 == m[row+4, col+2]
                )
            {
                result += 6;
            }
        }
        static void ScanSeven(int row, int col)
        {
            if (
                    7 == m[row, col] &&
                    7 == m[row, col+1] &&
                    7 == m[row, col+2] &&
                    7 == m[row+1, col+2] &&
                    7 == m[row+2, col+1] &&
                    7 == m[row+3, col+1] &&
                    7 == m[row+4, col+1]
                )
            {
                result += 7;
            }
        }
        static void ScanEight(int row, int col)
        {
            if (
                    8 == m[row, col] &&
                    8 == m[row, col+1] &&
                    8 == m[row, col+2] &&
                    8 == m[row+1, col] &&
                    8 == m[row+1, col+2] &&
                    8 == m[row+2, col+1] &&
                    8 == m[row+3, col] &&
                    8 == m[row+3, col+2] &&
                    8 == m[row+4, col] &&
                    8 == m[row+4, col+1] &&
                    8 == m[row+4, col+2]
                )
            {
                result += 8;
            }
        }
        static void ScanNine(int row, int col)
        {
            if (
                    9 == m[row, col] &&
                    9 == m[row, col+1] &&
                    9 == m[row, col+2] &&
                    9 == m[row+1, col] &&
                    9 == m[row+1, col+2] &&
                    9 == m[row+2, col+1] &&
                    9 == m[row+2, col+2] &&
                    9 == m[row+3, col+2] &&
                    9 == m[row+4, col] &&
                    9 == m[row+4, col+1] &&
                    9 == m[row+4, col+2]
                )
            {
                result += 9;
            }
        }
        static void Main(string[] args)
        {
            // input
            int size = int.Parse(Console.ReadLine());
            m = new int[size, size]; 
            for (int row = 0; row < size; row++)
            {
                char[] vector = Console.ReadLine().Replace(" ", "").ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    m[row, col] = vector[col] - '0';
                }
            }

            //
            for (int i = 0; i < m.GetLength(0) - 4; i++)
            {
                for (int j = 0; j < m.GetLength(1) - 2; j++)
                {
                    ScanOne(i,j);
                    ScanTwo(i, j);
                    ScanThree(i, j);
                    ScanFour(i, j);
                    ScanFive(i, j);
                    ScanSix(i, j);
                    ScanSeven(i, j);
                    ScanEight(i, j);
                    ScanNine(i, j);
                }
            }

            Console.WriteLine(result);
        }
    }
}
