using System;
using System.Text;

namespace LinearAlgebra.Common
{
    /// <summary>
    /// Represents matrix with number elements.
    /// </summary>
    /// <typeparam name="T">Numeric generic type.</typeparam>
    public class Matrix<T> where T: struct, IComparable, IFormattable, IConvertible
    {
        #region Fields
        private T[,] matrix;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes new instance of class Matrix<T> to the specified size of the square matrix.
        /// </summary>
        /// <param name="size">The size of the square matrix.</param>
        public Matrix(int size) : this(size, size)
        {
        }

        /// <summary>
        /// Initializes new instance of class Matrix<T> to the specified rows and cols.
        /// </summary>
        /// <param name="rows">The rows of the matrix.</param>
        /// <param name="cols">The cols of the matrix.</param>
        public Matrix(int rows, int cols)
        {
            matrix = new T[rows, cols];
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the rows of the matrix.
        /// </summary>
        public int Rows 
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        /// <summary>
        /// Gets the cols of the matrix.
        /// </summary>
        public int Cols
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }
        #endregion

        #region Indexer
        /// <summary>
        /// Gets value of the matrix by it's indexes.
        /// </summary>
        /// <param name="row">Row index of the value.</param>
        /// <param name="col">Col index of the value.</param>
        /// <returns></returns>
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
        /// <summary>
        /// Adds two matrices.
        /// </summary>
        /// <param name="A">Left matrix.</param>
        /// <param name="B">Right matrix.</param>
        /// <returns></returns>
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
                    // Cast the generic numeric type to dynamic to perform addition
                    C[i, j] = (dynamic)A[i, j] + (dynamic)B[i, j];
                }
            }

            // Return the sum of the matrices
            return C;
        }

        /// <summary>
        /// Substracts two matrices.
        /// </summary>
        /// <param name="A">Left matrix.</param>
        /// <param name="B">Right matrix.</param>
        /// <returns></returns>
        public static Matrix<T> operator -(Matrix<T> A, Matrix<T> B)
        {
            // Validate matrices dimensions
            if (A.Rows != B.Rows || A.Cols != B.Cols)
            {
                throw new InvalidOperationException("Cannot substract two matrices with different dimensions.");
            }

            // Create new instance of Matrix to store the result of substraction
            Matrix<T> C = new Matrix<T>(A.Rows, A.Cols);

            // Perform element-wise substraction
            for (int i = 0; i < A.Rows; i++)
            {
                for (int j = 0; j < A.Cols; j++)
                {
                    // Cast the generic numeric type to dynamic to perform substraction
                    C[i, j] = (dynamic)A[i, j] - (dynamic)B[i, j];
                }
            }

            // Return the difference of the matrices
            return C;
        }

        /// <summary>
        /// Performs matrix multiplication.
        /// </summary>
        /// <param name="A">Left matrix.</param>
        /// <param name="B">Right matrix.</param>
        /// <returns></returns>
        public static Matrix<T> operator *(Matrix<T> A, Matrix<T> B)
        {
            // Validate matrices dimensions
            if (A.Cols != B.Rows)
            {
                throw new InvalidOperationException("Cannot perform multiplication of two matrices.");
            }

            // Create new instance of Matrix to store the product of the matrices
            Matrix<T> C = new Matrix<T>(A.Rows, B.Cols);

            // Process of matrix multiplication
            // Multiply each row of A by each col of B element wise and sum the products.
            // A rows
            for (int i = 0; i < A.Rows; i++)
            {
                // B Cols
                for (int j = 0; j < B.Cols; j++)
                {
                    // Elements in row/col
                    for (int k = 0; k < B.Rows; k++) // Or A.Cols
                    {
                        C[i, j] += (dynamic)A[i, k] * (dynamic)B[k, j];
                    }
                }
            }

            // Return the product of the matrices
            return C;
        }

        /// <summary>
        /// Determines if the current instance has only non-zero elements.
        /// </summary>
        /// <param name="item">The instance of the matrix class to be searched for zero elements.</param>
        /// <returns>Returns true if matrix holds only non-zero elements.</returns>
        public static bool operator true(Matrix<T> item)
        {
            // Check element by element for zero values.
            for (int row = 0; row < item.Rows; row++)
            {
                for (int col = 0; col < item.Cols; col++)
                {
                    if (item[row, col].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }

            // If no zero elements are found
            return true;
        }

        /// <summary>
        /// Determines if the current instance has zero elements.
        /// </summary>
        /// <param name="item">The instance of the matrix class to be searched for zero elements.</param>
        /// <returns>Returns true if matrix holds zero elements.</returns>
        public static bool operator false(Matrix<T> item)
        {
            // Check element by element for zero values.
            for (int row = 0; row < item.Rows; row++)
            {
                for (int col = 0; col < item.Cols; col++)
                {
                    if (item[row, col].Equals(default(T)))
                    {
                        return true;
                    }
                }
            }

            // If no zero elements are found
            return false;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Converts matrix to string representation of it's elements.
        /// </summary>
        /// <returns>Elements of the matrix as a string.</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int rows = 0; rows < this.matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < this.matrix.GetLength(1); cols++)
                {
                    result.AppendFormat("{0, -4}", this.matrix[rows, cols]);
                }
                result.AppendLine();
            }

            return result.ToString();
        } 

        /// <summary>
        /// Checks if indexes are in the matrix range.
        /// </summary>
        /// <param name="row">Row index.</param>
        /// <param name="col">Col index.</param>
        /// <returns>Returns true if indexes provided are in the matrix range.</returns>
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
