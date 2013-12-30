using System;

namespace MatrixOpperations
{
    class MatrixOpperations
    {
        static void Main()
        {
            Matrix A = new Matrix(2, 3);
            A[0, 1] = 10;
            Console.WriteLine(A.ToString());
        }
    }
}
