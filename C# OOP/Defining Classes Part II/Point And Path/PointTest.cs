using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a structure Point3D to hold a 3D-coordinate {X, Y, Z}
//in the Euclidian 3D space. Implement the ToString() to enable
//printing a 3D point.

//2. Add a private static read-only field to hold the start of the
//coordinate system – the point O{0, 0, 0}. Add a static property
//to return the point O.

//3. Write a static class with a static method to calculate the
//distance between two points in the 3D space.

//4. Create a class Path to hold a sequence of points in the 3D space.
//Create a static class PathStorage with static methods to save and load
//paths from a text file. Use a file format of your choice.


namespace Point
{
    class PointTest
    {
        static void Main()
        {
            Point3D point = new Point3D(1, 2, 3);
            point.X = 5;
            Console.WriteLine(point);

            Console.WriteLine();

            Point3D point1 = Point3D.CenterCoordSystem;
            Console.WriteLine(point1);

            Point3D point2 = new Point3D(5, 6, 7);

            int distance = Point3DDistance.CalculateDistance(point, point2);

            Point3D point3 = new Point3D(1, 2, 3);
            Point3D point4 = new Point3D(5, 6, 7);
            Point3D point5 = new Point3D(1, 2 ,3);
            Point3D point6 = new Point3D(5, 6, 7);
            Point3D point7 = new Point3D(1 ,2 ,3);
            Path path = new Path(point3, point4);
            
            Path path2 = new Path(point5, point6, point7);
            path2.Add(new Point3D());
            PathStorage.Save(path);
            PathStorage.Save(path2);
            Path[] storage = PathStorage.Load();
            PathStorage.Delete();
            storage = PathStorage.Load();
            
        }
    }
}

