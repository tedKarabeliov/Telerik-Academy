using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        double double1 = 34.567839023;
        float float1 = 12.345f;
        double double2 = 8923.1234857;
        decimal decimal1 = 3456.091124875956542151256683467m;
        Console.WriteLine(double1 + "\n" + float1 + "\n" + double2 + "\n" + decimal1 + "\n");
        //Става ясно, че променливата "decimal1" може да бъде присвоена, но връща грешен резултат поради закръгляне.


    }
}

