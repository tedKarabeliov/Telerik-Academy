using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(FileReader.GetFileExtension("example"));
            Console.WriteLine(FileReader.GetFileExtension("example.pdf"));
            Console.WriteLine(FileReader.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileReader.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileReader.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileReader.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                FigureUtil.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                FigureUtil.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Figure3D figure = new Figure3D(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", figure.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", figure.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", figure.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", figure.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", figure.CalcDiagonalYZ());
        }
    }
}
