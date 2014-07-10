﻿

namespace GeometryAPI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class LineSegment : Figure, ILengthMeasurable
    {
        private Vector3D A
        {
            get { return this.vertices[0]; }
            set { this.vertices[0] = value; }
        }

        private Vector3D B
        {
            get { return this.vertices[1]; }
            set { this.vertices[1] = value; }
        }

        double length;

        public LineSegment(Vector3D a, Vector3D b)
            : base(a, b)
        {
            this.length = (this.A - this.B).Magnitude;
        }

        public double GetLength()
        {
            return this.length;
        }

        public override double GetPrimaryMeasure()
        {
            return this.GetLength();
        }
    }
}
