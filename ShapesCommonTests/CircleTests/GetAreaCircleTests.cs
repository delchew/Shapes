using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesCommon.Shapes;

namespace ShapesCommonTests.CircleTests
{
    [TestClass]
    public class GetAreaCircleTests
    {
        [TestMethod]
        public void GetArea_RadiusEquals4_ResultEquals50point264()
        {
            var radius = 4;
            var expectedArea = 50.264;

            var circle = new Circle(radius);
            var actualArea = circle.GetArea();

            Assert.AreEqual(expectedArea, actualArea, 0.002);
        }

        [TestMethod]
        public void GetArea_RadiusEquals1_ResultEqualsPi()
        {
            var radius = 1;
            var expectedArea = Math.PI;

            var circle = new Circle(radius);
            var actualArea = circle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}
