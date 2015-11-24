using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Problem_1.Point3D;

namespace Problem_3.Paths
{
    public class Storage
    {
        public static List<Point3D> PointReader(string path)
        {
            Regex regex = new Regex(@"(\d+),\s?(\d+),\s?(\d+)");
            List<Point3D> points = new List<Point3D>();

            string file = File.ReadAllText(path);
            foreach (Match match in regex.Matches(file))
            {
                double X;
                double Y;
                double Z;

                try
                {
                    X = double.Parse(match.Groups[1].Value);
                    Y = double.Parse(match.Groups[2].Value);
                    Z = double.Parse(match.Groups[3].Value);

                    Point3D point = new Point3D(X, Y, Z);
                    points.Add(point);
                }
                catch (Exception)
                {
                    throw new FormatException("Not a 3D point.");
                }
            }
            return points;
        }

        public static void SavePath(string destination, Path path)
        {
            foreach (var point in path.Points)
            {
                File.AppendAllText(destination, point.ToString());
            }
        }
    }
}
