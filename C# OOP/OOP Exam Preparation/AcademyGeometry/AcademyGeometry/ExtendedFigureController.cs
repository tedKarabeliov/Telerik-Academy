

namespace GeometryAPI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class ExtendedFigureController : FigureController
    {
        public override void ExecuteFigureCreationCommand(string[] splitFigString)
        {
            switch (splitFigString[0])
            {
                case "circle":
                    Vector3D center = Vector3D.Parse(splitFigString[1]);
                    double circleRadius = double.Parse(splitFigString[2]);
                    currentFigure = new Circle(center, circleRadius);
                    break;
                default:
                    base.ExecuteFigureCreationCommand(splitFigString);
                    break;
                case "cylinder":
                    Vector3D baseCircle = Vector3D.Parse(splitFigString[1]);
                    Vector3D topCircle = Vector3D.Parse(splitFigString[2]);
                    double cylinderRadius = double.Parse(splitFigString[3]);
                    currentFigure = new Cylinder(baseCircle, topCircle, cylinderRadius);
                    break;
            }
            this.EndCommandExecuted = false;
        }

        protected override void ExecuteFigureInstanceCommand(string[] splitCommand)
        {
            switch (splitCommand[0])
            {
                case "normal":
                    if (this.currentFigure is IFlat)
                    {
                        Vector3D normalVector = (this.currentFigure as IFlat).GetNormal();
                        Console.WriteLine(normalVector);
                    }
                    else
                    {
                        Console.WriteLine("undefined");
                    }
                    
                    break;
                case "area":
                    if (this.currentFigure is IAreaMeasurable)
                    {
                        double currentFigureArea = (this.currentFigure as IAreaMeasurable).GetArea();
                        Console.WriteLine("{0:0.00}", currentFigureArea);
                    }
                    else
                    {
                        Console.WriteLine("undefined");
                    }
                    break;
                case "volume":
                    if (this.currentFigure is IVolumeMeasurable)
                    {
                        double currentFigureVolume = (this.currentFigure as IVolumeMeasurable).GetVolume();
                        Console.WriteLine("{0:0.00}", currentFigureVolume);
                    }
                    else
                    {
                        Console.WriteLine("undefined");
                    }
                    break;
                default:
                    base.ExecuteFigureInstanceCommand(splitCommand);
                    break;
            }
        }
    }
}
