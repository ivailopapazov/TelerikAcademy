using System;
using System.Text;

namespace MatrixOpperations
{
    public class Matrix
    {
        private int[,] container;

        public Matrix(int rows, int cols)
        {
            this.container = new int[rows, cols];
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
            if (A.GetRows() != B.GetRows() && A.GetCols() != B.GetCols())
            {
                throw new InvalidOperationException("Dimension missmatch");
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

        public int GetRows()
        {
            return container.GetLength(0);
        }

        public int GetCols()
        {
            return container.GetLength(1);
        }

    }
}
