using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Point3DCalculator.Test
{
    [TestClass]
    public class Point3DTests
    {
        [TestMethod]
        public void TestDistanceTo_SamePoint_ReturnsZero()
        {
            var point = new Point3D { X = 1, Y = 2, Z = 3 };

            double distance = point.DistanceTo(point);

            Assert.AreEqual(0, distance);
        }

        [TestMethod]
        public void TestDistanceTo_DifferentPoints_ReturnsCorrectDistance()
        {
            var point1 = new Point3D { X = 0, Y = 0, Z = 0 };
            var point2 = new Point3D { X = 1, Y = 1, Z = 1 };

            double distance = point1.DistanceTo(point2);

            Assert.AreEqual(Math.Sqrt(3), distance);
        }
    }
}