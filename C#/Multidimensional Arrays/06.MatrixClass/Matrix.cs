using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Matrix
{
    private int[,] matrix;
    private int row;
    private int col;

    public Matrix(int row, int col)
    {
        this.row = row;
        this.col = col;
        matrix = new int[this.row, this.col];
    }

    public Matrix(int[,] matrix)
    {
        this.matrix = matrix;
        this.row = matrix.GetLength(0);
        this.col = matrix.GetLength(1);
    }

    public int GetRow
    {
        get { return this.row; }
    }
    public int GetCol
    {
        get { return this.col; }
    }
    public int Rank
    {
        get { return matrix.Rank; }
    }

    public int this[int row, int col]
    {
        get
        {
            if (row < 0 || col < 0 || row >= this.row || col >= this.row)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return matrix[row, col];
            }
        }
        set
        {
            if (row < 0 || col < 0 || row >= this.row || col >= this.row)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                matrix[row, col] = value;
            }
        }
    }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.GetRow != b.GetRow || a.GetCol != b.GetCol)
        {
            throw new ArgumentException("Matrices' rows and columns must be equal");
        }

        Matrix result = new Matrix(a.GetRow, a.GetCol);
        for (int row = 0; row < a.GetRow; row++)
        {
            for (int col = 0; col < a.GetCol; col++)
            {
                result[row, col] = a[row, col] + b[row, col];
            }
        }
        return result;
    }
    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.GetRow != b.GetRow || a.GetCol != b.GetCol)
        {
            throw new ArgumentException("Matrices' rows and columns must be equal");
        }
        Matrix result = new Matrix(a.GetRow, a.GetCol);
        for (int row = 0; row < a.GetRow; row++)
        {
            for (int col = 0; col < a.GetCol; col++)
            {
                result[row, col] = a[row, col] - b[row, col];
            }
        }
        return result;
    }
    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.GetCol != b.GetRow)
        {
            throw new ArgumentException();
        }
        Matrix result = new Matrix(a.GetRow, b.GetCol);
        for (int i = 0; i < a.GetRow; ++i)
        {
            for (int j = 0; j < b.GetCol; ++j)
            {
                for (int k = 0; k < a.GetCol; ++k)
                {
                    result[i, j] += a[i, k] * b[k, j];
                }
            }
        }
        return result;
    }

    public override string ToString()
    {
        string result = null;
        for (int row = 0; row < this.row; row++)
        {
            for (int col = 0; col < this.col; col++)
            {
                result += this.matrix[row, col] + " ";
            }
        }
        return result;
    }

    public void Display()
    {
        for (int row = 0; row < this.row; row++)
        {
            for (int col = 0; col < this.col; col++)
            {
                Console.Write(this.matrix[row, col] + " "); 
            }
            Console.WriteLine();
        }
    }
}

