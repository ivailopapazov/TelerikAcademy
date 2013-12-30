using System;

namespace MatrixOpperations
{
    class MatrixOpperations
    {
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
        static void Main()
        {
            // User Input for Matrix A
            Console.Write("Please enter matrix A rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Please enter matrix A cols: ");
            int cols = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter matrix A:");
            Matrix A = ParseMatrix(rows, cols);

            // User Input for Matrix B
            Console.Write("Please enter matrix B rows: ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Please enter matrix B cols: ");
            cols = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter matrix B:");
            Matrix B = ParseMatrix(rows, cols);

            // Printing Result for addition
            Matrix C = A + B;
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("A + B = ");
            Console.WriteLine(C.ToString());
            // Notes: cols and rows of matrices A and B must be equal for addition to be successful

            // Printing Result for substraction
            Matrix D = A - B;
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("A - B = ");
            Console.WriteLine(D.ToString());
            // Note: cols and rows of matrices A and B must be equal for substraction to be successful

            // Printing Result for multiplication
            Matrix E = A * B;
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("A * B = ");
            Console.WriteLine(E.ToString());
            // Note: cols of matrix A must be equal to rows of matrix B for multiplication to be successful
        }
    }
}