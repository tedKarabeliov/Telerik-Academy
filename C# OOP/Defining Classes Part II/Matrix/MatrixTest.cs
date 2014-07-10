using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//8. Define a class Matrix<T> to hold a matrix of numbers
//(e.g. integers, floats, decimals). 

//9.Implement an indexer this[row, col] to access the inner matrix cells.

//10.Implement the operators + and - (addition and subtraction of matrices of the same size)
//and * for matrix multiplication. Throw an exception when the operation cannot be performed.
//Implement the true operator (check for non-zero elements).

namespace Matrix
{
    class MatrixTest
    {
        static void Main()
        {
            int[,] mat = new int[0, 1];
            Matrix<int> matrix = new Matrix<int>(2, 2);
            matrix[0, 0] = 8;
            matrix[0, 1] = 7;
            matrix[1, 0] = 4;
            matrix[1, 1] = 6;
            Matrix<int> matrix1 = new Matrix<int>(2, 2);
            matrix1[0, 0] = 1;
            matrix1[0, 1] = 2;
            matrix1[1, 0] = 3;
            matrix1[1, 1] = 4;
            Matrix<int> matrix2 = matrix * matrix1;
        }
    }
}
