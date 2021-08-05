using System;
namespace ShapesCommon.Shapes
{
    public class Triangle : IAreaCalculate
    {
        private readonly double[] _sides;

        public double Side1 { get; }

        public double Side2 { get; }

        public double Side3 { get; }

        public Triangle(double side1, double side2, double side3)
        {
            if(side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Triangle side can't be less or equals 0!");
            }

            if(side1 + side2 < side3 || side1 + side3 < side2 || side2 + side3 < side1)
            {
                throw new ArgumentException("Triangle with these sides does'nt exist (triangle inequility not executed)!");
            }
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;

            _sides = new[] { side1, side2, side3 };
            Array.Sort(_sides);
        }

        public double GetArea()
        {
            if (IsRight())
            {
                return (_sides[0] * _sides[1]) / 2;
            }
            //Gerons formula
            var p = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        public bool IsRight()
        {
            return Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2) == Math.Pow(_sides[2], 2);
        }

    }
}
