using System;
using System.Text;

namespace MatrixOpperations
{
    public class Matrix
    {
        private int[,] container;
        public int Rows { get; private set; }
        public int Cols { get; private set; }

        public Matrix(int rows, int cols)
        {
            this.container = new int[rows, cols];
            Rows = rows;
            Cols = cols;
        }

        public int this[int i, int j]
        {
            get
            {
                return container[i, j];
            }
            set
            {
                container[i, j] = value;
            }
        }

        public static Matrix operator +(Matrix A, Matrix B)
        {
            if (A.Rows != B.Rows && A.Cols != B.Cols)
            {
                throw new InvalidOperationException("Dimension missmatch");
            }

            for (int i = 0; i < length; i++)
            {
                
            }
        }

        public override string ToString()
        {
            StringBuilder stringMatrix = new StringBuilder();

            for (int i = 0; i < container.GetLength(0); i++)
            {
                for (int j = 0; j < container.GetLength(1); j++)
                {
                    stringMatrix.AppendFormat("{0, -4}", container[i, j]);
                }
                stringMatrix.AppendLine();
            }
            return stringMatrix.ToString();
        }

    }
}
