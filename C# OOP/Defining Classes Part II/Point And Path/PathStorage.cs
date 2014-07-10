using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Point
{
    static class PathStorage
    {
        private static List<string> storage = new List<string>();
        
        public static void Save(Path path)
        {
            string output = string.Empty;
            StreamWriter writer = new StreamWriter("PathStorage.txt", true);
            using (writer)
            {
                for (int i = 0; i < path.Points.Count; i++)
                {
                    output = path.Points[i].X.ToString() +
                    path.Points[i].Y.ToString() +
                    path.Points[i].Z.ToString();

                    writer.Write(output);
                }
                writer.WriteLine();
            }
        }

        public static Path[] Load()
        {
            List<Path> paths = new List<Path>();
            StreamReader reader = new StreamReader("PathStorage.txt");
            try
            {
                //Read next line from file
                string currentInputPath = reader.ReadLine();
                if (currentInputPath == null)
                {
                    throw new NullReferenceException("Empty storage");
                }
                using (reader)
                {
                    while (currentInputPath != null)
                    {
                        Path currentPath = new Path();
                        for (int i = 0; i < currentInputPath.Length; i += 3)
                        {
                            //Create new point for current path
                            Point3D currentPoint = new Point3D();
                            currentPoint.X = (int)Char.GetNumericValue(currentInputPath[i]);
                            currentPoint.Y = (int)Char.GetNumericValue(currentInputPath[i + 1]);
                            currentPoint.Z = (int)Char.GetNumericValue(currentInputPath[i + 2]);
                            currentPath.Add(currentPoint);
                        }
                        paths.Add(currentPath);
                        currentInputPath = reader.ReadLine();
                    }
                }
                return paths.ToArray();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                reader.Close();
                return null;
            }
        }

        public static void Delete()
        {
            File.WriteAllText("PathStorage.txt", String.Empty);
        }

    }
}
