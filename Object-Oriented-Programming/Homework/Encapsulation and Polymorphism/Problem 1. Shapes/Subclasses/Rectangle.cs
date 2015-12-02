using System;

namespace Problem_1.Shapes.Subclasses
{
    public class Rectangle : BasicShape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }
        public override void CalculateArea()
        {
            double area = Height * Width;
            Console.WriteLine("Area: {0:F2}", area);
        }

        public override void CalculatePerimeter()
        {
            double perimeter = 2 * (Width + Height);
            Console.WriteLine("Perimeter: {0:F2}", perimeter);
        }

    }
}