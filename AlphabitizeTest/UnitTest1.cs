using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlphabitizeTest
{
    [TestClass]
    public class AlphaTest
    {
        [TestMethod]
        public void TestMethod_MSSA_CAD()
        {
            Assert.AreEqual("acdms",Alphabetize.Alpha.AlphabetizedString("MSSA CAD")) ;
        }
        [TestMethod]
        public void TestMethod_blankString()
        {
            Assert.AreEqual("", Alphabetize.Alpha.AlphabetizedString(""));
        }
        [TestMethod]
        public void TestMethod_aaa()
        {
            Assert.AreEqual("a", Alphabetize.Alpha.AlphabetizedString("aaaaaa  aaaa"));
        }
        [TestMethod]
        public void TestMethod_withPunct()
        {
            Assert.AreEqual("ceklnot", Alphabetize.Alpha.AlphabetizedString("ten-o'clock"));
        }

    }
}
