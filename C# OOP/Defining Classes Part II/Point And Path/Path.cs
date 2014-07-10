using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Point
{
    class Path
    {
        private List<Point3D> points = new List<Point3D>();

        public List<Point3D> Points
        {
            get { return this.points; }
        }

        public Path()
        {
        }

        public Path(params Point3D[] path)
        {
            Add(path);
        }

        public void Add(params Point3D[] path)
        {
            for (int i = 0; i < path.Length; i++)
            {
                this.points.Add(path[i]);
            }
        }

        public void Clear()
        {
            this.points.Clear();
        }
    }
}
