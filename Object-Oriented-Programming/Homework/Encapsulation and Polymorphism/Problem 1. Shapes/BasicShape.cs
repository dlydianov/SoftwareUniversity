using System;
using Problem_1.Shapes.Interfaces;

namespace Problem_1.Shapes
{
    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;
        protected BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("Width","Width cannot be negative.");
                }   
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height", "Height cannot be negative.");
                }
                this.height = value;
            }
        }

        public abstract void CalculateArea();

        public abstract void CalculatePerimeter();
    }
}