using System;
using Problem_1.Point3D;

namespace Problem_2.Distance_Calculator
{
    public class DistanceCalculator
    {
        static void Main()
        {
            Point3D firstPoint = new Point3D(0, 0, 0);
            Point3D secondPoint = new Point3D(1, 2, 3);

            Console.WriteLine("First point coordinates: ");
            Console.WriteLine(firstPoint);
            Console.WriteLine("Second point coordinates: ");
            Console.WriteLine(secondPoint);
            Console.WriteLine("---------------------");
            Console.WriteLine("Distance between the two points: ");
            double distance = CalculateDistance.CalculateDistanseMethod(firstPoint, secondPoint);
            Console.WriteLine(distance);
        }
    }
}
