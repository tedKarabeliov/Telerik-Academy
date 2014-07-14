using System;
namespace Using_Varaibles__Data_Expressions_and_Constants
{
    public class Size
    {
        public double width, height;
        public Size(double weight, double height)
        {
            this.width = weight;
            this.height = height;
        }

        public static Size GetRotatedSize(Size size, double angleOfFigure)
        {
            double newWidth = Math.Abs(Math.Cos(angleOfFigure)) * size.width +
                Math.Abs(Math.Sin(angleOfFigure)) * size.height;
            double newHeight = Math.Abs(Math.Sin(angleOfFigure)) * size.width +
                Math.Abs(Math.Cos(angleOfFigure)) * size.height;

            return new Size(newWidth, newHeight);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
