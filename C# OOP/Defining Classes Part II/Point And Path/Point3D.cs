using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Point
{
    struct Point3D
    {
        private static readonly Point3D centerCoordSystem = new Point3D(0, 0, 0);

        private int x;
        private int y;
        private int z;

        public static Point3D CenterCoordSystem
        {
            get { return centerCoordSystem; }
        }
        public int X 
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public int Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public Point3D(int x, int y, int z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return "X = " + this.x + "\n"
                 + "Y = " + this.y + "\n"
                 + "Z = " + this.z;
        }
    }
}
