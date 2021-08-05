using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesCommon.Shapes;

namespace ShapesCommonTests.TriangleTests
{
    [TestClass]
    public class GetAreaTriangleTests
    {
        [TestMethod]
        public void GetArea_Sides3_4_5_ResultEquals2point5()
        {
            var side1 = 3;
            var side2 = 4;
            var side3 = 5;
            var expectedArea = 6;

            var triangle = new Triangle(side1, side2, side3);
            var actualArea = triangle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void GetArea_Sides6_7_8__ResultEquals20point333()
        {
            var side1 = 6;
            var side2 = 7;
            var side3 = 8;
            var expectedArea = 20.333;

            var triangle = new Triangle(side1, side2, side3);
            var actualArea = triangle.GetArea();

            Assert.AreEqual(expectedArea, actualArea, 0.002);
        }
    }
}
