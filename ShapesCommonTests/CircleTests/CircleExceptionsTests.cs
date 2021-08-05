using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesCommon.Shapes;

namespace ShapesCommonTests.CircleTests
{
    [TestClass]
    public class CircleExceptionsTests
    {
        [TestMethod]
        public void GetArea_RadiusEquals0_ThrowsArgumentException()
        {
            var radius = 0;
            void action() => new Circle(radius);

            Assert.ThrowsException<ArgumentException>(action);
        }

        [TestMethod]
        public void GetArea_RadiusLessThan0_ThrowsArgumentException()
        {
            var radius = -1;
            void action() => new Circle(radius);

            Assert.ThrowsException<ArgumentException>(action);
        }
    }
}
