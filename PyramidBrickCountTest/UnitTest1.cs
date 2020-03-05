using Microsoft.VisualStudio.TestTools.UnitTesting;
using PyramidBrickCount;

namespace PyramidBrickCountTest
{
    [TestClass]
    public class BrickCountTest
    {
        [TestMethod]
        public void BrickCountTest_1()
        {
            Assert.AreEqual(0, CountBricks.CountOfBricks(1, 1, 1.0));
        }
        [TestMethod]
        public void BrickCountTest_8824()
        {
            Assert.AreEqual(8824, CountBricks.CountOfBricks(100, 30, .17));
        }
    }
}
