using System;
using Quality_Classes;

namespace Abstraction
{
    public abstract class Figure : IFigure
    {
        public Figure()
        {
        }

        public abstract double CalculatePerimeter();

        public abstract double CalculateSurface();
    }
}
