using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_1.Point3D;


namespace Problem_3.Paths
{
    public class Path3D
    {
        static string loadPath = "../../Points.txt";
        static string savePath = "../../SavePoint.txt";

        static void Main()
        {
            Path path = new Path(Storage.PointReader(loadPath));
            Storage.SavePath(savePath, path);
            Console.WriteLine(path);
        }
    }
}
