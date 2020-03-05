using Microsoft.VisualStudio.TestTools.UnitTesting;
using DistinctArrayElements;

namespace DistinctArrayElementsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] X = { 5, 3, 5, 7, 11, 5 };
            Assert.AreEqual(4, ArrayElements.CountDistinctElements(X));
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] X = { 10, 10, 10, 11, 12, 10 };
            Assert.AreEqual(3, ArrayElements.CountDistinctElements(X));
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] X = { 10, 10, 10, 10, 10, 10, 10 };
            Assert.AreEqual(1, ArrayElements.CountDistinctElements(X));
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] X = { -55, -42, 5, 9, 4, -13, 0, 0, 7 };
            Assert.AreEqual(8, ArrayElements.CountDistinctElements(X));
        }
        [TestMethod]
        public void TestMethod5()
        {
            int[] X = { 1 };
            Assert.AreEqual(1, ArrayElements.CountDistinctElements(X));
        }
        [TestMethod]
        public void TestMethod6()
        {
            int[] X = { };
            Assert.AreEqual(0, ArrayElements.CountDistinctElements(X));
        }
        [TestMethod]
        public void TestMethod7()
        {
            int[] X = { 1, 2, 3, 1, 2, 3 };
            Assert.AreEqual(3, ArrayElements.CountDistinctElements(X));
        }
        [TestMethod]
        public void TestEachMethod2()
        {
            int[] X = { 10, 10, 10, 11, 12, 10 };
            Assert.AreEqual(3, ArrayElements.CountEachDistinctElements(X));
        }
        [TestMethod]
        public void TestEachMethod3()
        {
            int[] X = { 10, 10, 10, 10, 10, 10, 10 };
            Assert.AreEqual(1, ArrayElements.CountEachDistinctElements(X));
        }
    }
}
