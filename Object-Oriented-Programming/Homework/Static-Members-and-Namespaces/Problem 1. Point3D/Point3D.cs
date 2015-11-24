﻿using System;

namespace Problem_1.Point3D
{
    public class Point3D
    {
        private double x;
        private double y;
        private double z;
        static readonly Point3D startingPoint = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X
        {
            get;
            set;
        }

        public double Y
        {
            get;
            set;
        }

        public double Z
        {
            get;
            set;
        }

        public static Point3D StartingPoint
        {
            get { return startingPoint; }
        }

        public override string ToString()
        {
            return string.Format("Coordinates: {0}, {1}, {2}", X, Y, Z);
        }
    }
}
