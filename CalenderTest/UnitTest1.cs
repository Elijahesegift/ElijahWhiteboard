using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;

namespace CalendarTest
{
    [TestClass]
    public class DateTest
    {
        [TestMethod]
        public void TestJulian_Jan()
        {
            Assert.AreEqual(1, Dates.JulianDay(1, 1));
            Assert.AreEqual(25, Dates.JulianDay(1, 25));
            Assert.AreEqual(31, Dates.JulianDay(1, 31));
        }
        [TestMethod]
        public void TestJulian_Feb()
        {
            Assert.AreEqual(32, Dates.JulianDay(2, 1));
            Assert.AreEqual(36, Dates.JulianDay(2, 5));
            Assert.AreEqual(51, Dates.JulianDay(2, 20));
        }
        [TestMethod]
        public void TestJulian_Jun()
        {
            Assert.AreEqual(152, Dates.JulianDay(6, 1));
            Assert.AreEqual(156, Dates.JulianDay(6, 5));
            Assert.AreEqual(181, Dates.JulianDay(6, 30));
        }
        [TestMethod]
        public void TestJulian_Bounds()
        {
            // TODO: fix method code to support bounds checking 
            // then uncomment these lines.
            //Assert.AreEqual(0, Dates.JulianDay(6, 31));
            //Assert.AreEqual(0, Dates.JulianDay(0, 3));
            //Assert.AreEqual(0, Dates.JulianDay(2, 30));
            //Assert.AreEqual(0, Dates.JulianDay(2, 0));
        }

    }
}
