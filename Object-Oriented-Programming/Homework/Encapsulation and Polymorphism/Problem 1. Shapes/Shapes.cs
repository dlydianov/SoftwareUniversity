using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_1.Shapes.Subclasses;

namespace Problem_1.Shapes
{
    class Shapes
    {
        static void Main()
        {
            Console.Write("Enter Radius of a circle: ");
            double a = int.Parse(Console.ReadLine());
            Circle circle = new Circle(a);
            Console.WriteLine("Circle:");
            circle.CalculateArea();
            Console.WriteLine();

            Console.Write("Enter Width of a Rectangle: ");
            double b = int.Parse(Console.ReadLine());
            Console.Write("Enter Height of a Rectangle: ");
            double c = int.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(b, c);
            Console.WriteLine("Rectangle:");
            rect.CalculateArea();
            rect.CalculatePerimeter();
            Console.WriteLine();

            Console.Write("Enter Width of a Rhombus: ");
            double d = int.Parse(Console.ReadLine());
            Console.Write("Enter Height of a Rhombus: ");
            double e = int.Parse(Console.ReadLine());
            Rhombus rhombus = new Rhombus(d, e);
            Console.WriteLine("Rhombus:");
            rhombus.CalculateArea();
            rhombus.CalculatePerimeter();
            Console.WriteLine();
        }
    }
}
