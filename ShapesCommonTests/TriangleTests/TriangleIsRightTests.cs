using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesCommon.Shapes;

namespace ShapesCommonTests.TriangleTests
{
    [TestClass]
    public class TriangleIsRightTests
    {
        [TestMethod]
        public void Triangle_Sides3_4_5_ResultEqualsTrue()
        {
            var side1 = 3;
            var side2 = 4;
            var side3 = 5;

            var triangle = new Triangle(side1, side2, side3);
            var triangleIsRight = triangle.IsRight();

            Assert.IsTrue(triangleIsRight);
        }

        [TestMethod]
        public void Triangle_Sides6_7_8_ResultEqualsFalse()
        {
            var side1 = 6;
            var side2 = 7;
            var side3 = 8;

            var triangle = new Triangle(side1, side2, side3);
            var triangleIsRight = triangle.IsRight();

            Assert.IsFalse(triangleIsRight);
        }
    }
}
