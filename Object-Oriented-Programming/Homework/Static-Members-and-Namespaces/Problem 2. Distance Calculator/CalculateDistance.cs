using System;
using Problem_1.Point3D;

namespace Problem_2.Distance_Calculator
{
    static class CalculateDistance
    {
        public static double CalculateDistanseMethod(Point3D firstPoint, Point3D secondPoint)
        {

            double distance = Math.Sqrt(((firstPoint.X - secondPoint.X)*(firstPoint.X - secondPoint.X)) +
                                        ((firstPoint.Y - secondPoint.Y)*(firstPoint.Y - secondPoint.Y)) +
                                        ((firstPoint.Z - firstPoint.Z)*(firstPoint.Z - firstPoint.Z)));
            return distance;
        }
    }
}
