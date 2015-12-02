using System;

namespace Problem_1.Shapes.Subclasses
{
    public class Rhombus : BasicShape
    {
        private const short SidesOfRhombus = 4; 
        public Rhombus(double width, double height) : base(width, height)
        {
        }

        public override void CalculateArea()
        {
            double area = Height*Width;
            Console.WriteLine("Area: {0:F2}",area);
        }

        public override void CalculatePerimeter()
        {
            double perimeter = SidesOfRhombus*Width;
            Console.WriteLine("Perimeter: {0:F2}", perimeter);
        }

    }
}