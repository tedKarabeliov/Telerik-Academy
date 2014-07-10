using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Matrix
{
    class Matrix<T>
    {
        private T[,] elements;
        private int rows;
        private int cols;

        //Constructors
        public Matrix() : this(0, 0)
        {

        }
        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            elements = new T[this.Rows, this.Cols];
        }
        //

        //Properties
        public int Rows
        {
            get { return this.rows; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Size must be positive");
                }
                this.rows = value;
            }
        }
        public int Cols
        {
            get { return this.cols; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Size must be positive");
                }
                this.cols = value;
            }
        }

        //Indexator
        public T this[int row, int col]
        {
            get
            {
                return elements[row, col];
            }
            set
            {
                elements[row, col] = value;
            }
        }
        //

        //Operators
        public static Matrix<T> operator +(Matrix<T> matrix1,Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new ArgumentException("Matrices' rows and columns must be equal");
            }

            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Cols);
            for (int row = 0; row < matrix1.Rows; row++)
            {
                for (int col = 0; col < matrix1.Cols; col++)
                {
                    try
                    {
                        dynamic sum1 = matrix1[row, col];
                        dynamic sum2 = matrix2[row, col];
                        result[row, col] = sum1 + sum2;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Type must be numerable");
                    }
                }
            }
            return result;
        }
        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new ArgumentException("Matrices' rows and columns must be equal");
            }

            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Cols);
            for (int row = 0; row < matrix1.Rows; row++)
            {
                for (int col = 0; col < matrix1.Cols; col++)
                {
                    try
                    {
                        dynamic sum1 = matrix1[row, col];
                        dynamic sum2 = matrix2[row, col];
                        result[row, col] = sum1 - sum2;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Type must be numerable");
                        return null;
                    }
                }
            }
            return result;
        }
        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Cols != matrix2.Rows)
            {
                throw new ArgumentException("First matrix's colons must be equal to second matrix's rows");
            }
            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix2.Cols);
            for (int i = 0; i < matrix1.Rows; ++i)
            {
                for (int j = 0; j < matrix2.Cols; ++j)
                {
                    for (int k = 0; k < matrix1.Cols; ++k)
                    {
                        try
                        {
                            dynamic product1 = matrix1[i, k];
                            dynamic product2 = matrix2[k, j];
                            result[i, j] += product1 * product2;
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("Type must be numerable");
                            return null;
                        }
                    }
                }
            }
            return result;
        }
        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    try
                    {
                        dynamic currentElement = matrix.elements[row, col];
                        if (currentElement == 0)
                        {
                            return false;
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Type must be numerable");
                        return true;
                    }
                }
            }
            return true;
        }
        public static bool operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    try
                    {
                        dynamic currentElement = matrix.elements[row, col];
                        if (currentElement == 0)
                        {
                            return true;
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Type must be numerable");
                        return true;
                    }
                }
            }
            return false;
        }
        //
        
    }
}

