using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Point
{
    static class Point3DDistance
    {
        public static int CalculateDistance(Point3D p1, Point3D p2)
        {
            return (int)Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
        }
    }
}
