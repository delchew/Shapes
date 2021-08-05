using System;
namespace ShapesCommon.Shapes
{
    public class Circle : IAreaCalculate
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Circle radius can't be less or equals 0!");
            }
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
