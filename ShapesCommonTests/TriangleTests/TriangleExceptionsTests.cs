using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesCommon.Shapes;

namespace ShapesCommonTests.TriangleTests
{
    [TestClass]
    public class TriangleExceptionsTests
    {
        [TestMethod]
        public void Side1Equals0_ThrowsArgumentException()
        {
            var side1 = 0;
            var side2 = 1;
            var side3 = 2;
            void action() => new Triangle(side1, side2, side3);

            Assert.ThrowsException<ArgumentException>(action);
        }

        [TestMethod]
        public void Side2Equals0_ThrowsArgumentException()
        {
            var side1 = 1;
            var side2 = 0;
            var side3 = 2;
            void action() => new Triangle(side1, side2, side3);

            Assert.ThrowsException<ArgumentException>(action);
        }

        [TestMethod]
        public void Side3Equals0_ThrowsArgumentException()
        {
            var side1 = 1;
            var side2 = 2;
            var side3 = 0;
            void action() => new Triangle(side1, side2, side3);

            Assert.ThrowsException<ArgumentException>(action);
        }

        [TestMethod]
        public void Side1LessThan0_ThrowsArgumentException()
        {
            var side1 = -1;
            var side2 = 1;
            var side3 = 2;
            void action() => new Triangle(side1, side2, side3);

            Assert.ThrowsException<ArgumentException>(action);
        }

        [TestMethod]
        public void Side2LessThan0_ThrowsArgumentException()
        {
            var side1 = 1;
            var side2 = -1;
            var side3 = 2;
            void action() => new Triangle(side1, side2, side3);

            Assert.ThrowsException<ArgumentException>(action);
        }

        [TestMethod]
        public void Side3LessThan0_ThrowsArgumentException()
        {
            var side1 = 1;
            var side2 = 2;
            var side3 = -1;
            void action() => new Triangle(side1, side2, side3);

            Assert.ThrowsException<ArgumentException>(action);
        }

        [TestMethod]
        public void SumSide1Side2LessThanSide3_ThrowsArgumentException()
        {
            var side1 = 7;
            var side2 = 3;
            var side3 = 3;
            void action() => new Triangle(side1, side2, side3);

            Assert.ThrowsException<ArgumentException>(action);
        }

        [TestMethod]
        public void SumSide1Side3LessThanSide2_ThrowsArgumentException()
        {
            var side1 = 1;
            var side2 = 4;
            var side3 = 6;
            void action() => new Triangle(side1, side2, side3);

            Assert.ThrowsException<ArgumentException>(action);
        }

        [TestMethod]
        public void SumSide2Side3LessThanSide1_ThrowsArgumentException()
        {
            var side1 = 2;
            var side2 = 1;
            var side3 = 4;
            void action() => new Triangle(side1, side2, side3);

            Assert.ThrowsException<ArgumentException>(action);
        }
    }
}
