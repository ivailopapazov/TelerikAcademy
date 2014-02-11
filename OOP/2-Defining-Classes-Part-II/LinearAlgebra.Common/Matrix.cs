using System;

namespace LinearAlgebra.Common
{
    public class Matrix<T> where T: struct, IComparable, IFormattable, IConvertible
    {
        #region Fields
        private T[,] matrix;
        #endregion

        #region Constructors
        public Matrix(int size) : this(size, size)
        {
        }
        public Matrix(int rows, int cols)
        {
            matrix = new T[rows, cols];
        }
        #endregion

        #region Properties
        public int Rows 
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        public int Cols
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }
        #endregion

        #region Indexer
        public T this[int row, int col] 
        {
            get
            {
                // Validate indexes
                if (!IsInMatrix(row, col))
                {
                    throw new ArgumentOutOfRangeException("Index is out of range.");
                }

                return matrix[row, col];
            }
            set
            {
                // Validate indexes
                if (!IsInMatrix(row, col))
                {
                    throw new ArgumentOutOfRangeException("Index is out of range.");
                }

                this.matrix[row, col] = value;
            }
        }
        #endregion

        #region Operators
        public static Matrix<T> operator +(Matrix<T> A, Matrix<T> B)
        {
            // Validate matrices dimensions
            if (A.Rows != B.Rows || A.Cols != B.Cols)
            {
                throw new InvalidOperationException("Cannot add two matrices with different dimensions.");
            }

            // Create new instance of Matrix to store the result of addition
            Matrix<T> C = new Matrix<T>(A.Rows, A.Cols);

            // Perform element-wise addition
            for (int i = 0; i < A.Rows; i++)
            {
                for (int j = 0; j < A.Cols; j++)
                {
                    C[i, j] = (dynamic)A[i, j] + (dynamic)B[i, j];
                }
            }

            // Return the sum of the matrices
            return C;
        }
        #endregion

        #region Methods

        private bool IsInMatrix(int row, int col)
        {
            // If row is out of range
            if (row < 0 || row >= matrix.GetLength(0))
            {
                return false;
            }

            // If col is out of range
            if (col < 0 || col >= matrix.GetLength(1))
            {
                return false;
            }

            // If index is in range
            return true;
        }

        #endregion
    }
}
