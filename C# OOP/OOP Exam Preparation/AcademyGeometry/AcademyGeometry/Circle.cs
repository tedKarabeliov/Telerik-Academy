

namespace GeometryAPI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Circle : Figure, IAreaMeasurable, IFlat
    {
        private Vector3D center;
        private double radius;

        public Vector3D Center
        {
            get { return this.center; }
            private set { this.center = value; }
        }

        public double Radius
        {
            get { return this.radius; }
            private set { this.radius = value; }
        }

        public Circle(Vector3D center, double radius)
            : base(center)
        {
            this.Center = center;
            this.Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public Vector3D GetNormal()
        {
            Vector3D normal = new Vector3D(0.00, 0.00, 1.00);
            return normal;
        }

        public override double GetPrimaryMeasure()
        {
            return this.GetArea();
        }

    }
}
