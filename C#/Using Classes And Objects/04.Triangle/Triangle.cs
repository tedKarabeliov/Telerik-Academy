using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Triangle
{
   static double ThreeSides(double a,double b,double c)
    {
        double p = (a + b + c) / 2;
        double surface = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return surface;
    }
    static double SideAndHeight(double side,double height)
    {
        double surface = (side * height) / 2;
        return surface;
    }
    static double TwoSidesAndAngle(double side1,double side2,double angle)
    {
        angle *= Math.PI / 180;
        double surface = (side1 * side2 * Math.Sin(angle)) / 2;
        return surface;
    }

    static void Main()
    {
        Console.WriteLine("For finding surface of a triangle: \n ");
        Console.WriteLine("Press \"1\" for declaring 3 sides");
        Console.WriteLine("Press \"2\" for declaring 1 side and height");
        Console.WriteLine("Press \"3\" for declaring 2 sides and angle between given sides");
        int choose = int.Parse(Console.ReadLine());
        if (choose == 1)
        {
            Console.WriteLine("Enter first side: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second side: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third side: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Surface: " + ThreeSides(a, b, c));

        }
        else if (choose == 2)
        {
            Console.WriteLine("Enter side: ");
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Surface: " + SideAndHeight(side, height));
        }
        else if (choose == 3)
        {
            Console.WriteLine("Enter first side: ");
            double firstside = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second side: ");
            double secondside = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter angle between sides: ");
            int angle = int.Parse(Console.ReadLine());
            Console.WriteLine("Surface: " + TwoSidesAndAngle(firstside, secondside, angle));
        }
        else
        {
            Console.WriteLine("Invalid number!");
            return;
        }
    }
}

