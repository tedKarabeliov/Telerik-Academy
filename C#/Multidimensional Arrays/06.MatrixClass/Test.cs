using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Test
{
    static void Main()
    {
        Matrix matrix1 = new Matrix(2, 2);
        Matrix matrix2 = new Matrix(2, 2);

        matrix1[0, 0] = 1;
        matrix1[0, 1] = 2;
        matrix1[1, 0] = 3;
        matrix1[1, 1] = 4;

        matrix2[0, 0] = 5;
        matrix2[0, 1] = 6;
        matrix2[1, 0] = 7;
        matrix2[1, 1] = 8;

        
        Matrix result = matrix1 * matrix2;
        string str = result.ToString();
        result.Display();
    }
}

