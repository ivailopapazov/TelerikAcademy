using System;

namespace MatrixOpperations
{
    class MatrixOpperations
    {
        static void Main()
        {
            Console.Write("Please enter matrix A rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Please enter matrix A cols: ");
            int cols = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter matrix A:");
            Matrix A = ParseMatrix(rows, cols);

            Console.Write("Please enter matrix B rows: ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Please enter matrix B cols: ");
            cols = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter matrix B:");
            Matrix B = ParseMatrix(rows, cols);

            //Console.WriteLine(A.ToString());
            //Console.WriteLine(B.ToString());

            Matrix C = A + B;
            Console.WriteLine(C.ToString());
        }

        static Matrix ParseMatrix(int rows, int cols)
        {
            Matrix parsedMatrix = new Matrix(rows, cols);

            for (int i = 0; i < rows; i++)
            {
                string[] matrixRow = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    parsedMatrix[i, j] = int.Parse(matrixRow[j]);
                }
            }

            return parsedMatrix;
        }
    }
}
