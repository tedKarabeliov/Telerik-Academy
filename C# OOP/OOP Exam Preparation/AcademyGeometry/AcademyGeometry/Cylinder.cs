

namespace GeometryAPI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Cylinder : Figure, IAreaMeasurable, IVolumeMeasurable
    {
        private Vector3D baseCircleCenter;
        private Vector3D topCircleCenter;
        private double radius;
        private double height;

        public Cylinder(Vector3D baseCircleCenter, Vector3D topCircleCenter, double radius)
            : base(baseCircleCenter, topCircleCenter)
        {
            this.BaseCircleCenter = baseCircleCenter;
            this.TopCircleCenter = topCircleCenter;
            this.Radius = radius;
            this.Height = this.GetHeight();
        }


        public Vector3D BaseCircleCenter
        {
            get { return this.baseCircleCenter; }
            private set { this.baseCircleCenter = value; }
        }
        public Vector3D TopCircleCenter
        {
            get { return this.topCircleCenter; }
            private set { this.topCircleCenter = value; }
        }

        public double Radius
        {
            get { return this.radius; }
            private set { this.radius = value; }
        }

        public double Height
        {
            get { return this.height; }
            private set { this.height = value; }
        }

        public double GetArea()
        {
            return 2 * Math.PI * this.Radius * this.Radius +  2 * Math.PI * this.Radius * this.Height;
        }

        private double GetHeight()
        {
            return Math.Abs(Math.Sqrt(this.BaseCircleCenter.X - this.TopCircleCenter.X) +
                                    this.BaseCircleCenter.Y - this.TopCircleCenter.Y +
                                    this.BaseCircleCenter.Z - this.TopCircleCenter.Z);
        }

        public double GetVolume()
        {
            return Math.PI * this.Radius * this.Radius * this.Height;
        }

        public override double GetPrimaryMeasure()
        {
            return this.GetVolume();
        }
    }
}
