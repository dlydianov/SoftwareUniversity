using System;
using Problem_1.Shapes.Interfaces;

namespace Problem_1.Shapes
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Radius cannot be negative.");
                }
                this.radius = value;
            }
        }
        public void CalculateArea()
        {
            double area = Math.PI*(radius*radius);
            Console.WriteLine("Area: {0:F2}", area);
        }

        public void CalculatePerimeter()
        {
            double perimeter = 2*(Math.PI*radius);
            Console.WriteLine("Perimeter: {0:F2}", perimeter);
        }
    }
}