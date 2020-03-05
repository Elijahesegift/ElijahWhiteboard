using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeNumbersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PrimeTest_SmallPrimes()
        {
            Assert.IsTrue(PrimeNumbers.Prime.IsPrime(2));
            Assert.IsTrue(PrimeNumbers.Prime.IsPrime(3));
            Assert.IsTrue(PrimeNumbers.Prime.IsPrime(5));
            Assert.IsTrue(PrimeNumbers.Prime.IsPrime(7));
            Assert.IsTrue(PrimeNumbers.Prime.IsPrime(11));
            Assert.IsTrue(PrimeNumbers.Prime.IsPrime(13));
            Assert.IsTrue(PrimeNumbers.Prime.IsPrime(17));

        }
        [TestMethod]
        public void PrimeTest_SmallNonPrimes()
        {
            Assert.IsFalse(PrimeNumbers.Prime.IsPrime(8));
            Assert.IsFalse(PrimeNumbers.Prime.IsPrime(-4));
            Assert.IsFalse(PrimeNumbers.Prime.IsPrime(4));
            Assert.IsFalse(PrimeNumbers.Prime.IsPrime(0));
            Assert.IsFalse(PrimeNumbers.Prime.IsPrime(255));

        }
        [TestMethod]
        public void PrimeTest_BigNumber()
        {
            Assert.IsTrue(PrimeNumbers.Prime.IsPrime(223051));
        }
        [TestMethod]
        public void PrimeTest_Zero()
        {
            Assert.IsFalse(PrimeNumbers.Prime.IsPrime(0));
        }
        [TestMethod]
        public void PrimeTest_One()
        {
            Assert.IsFalse(PrimeNumbers.Prime.IsPrime(1));
        }
        [TestMethod]
        public void PrimeTest_Negative()
        {
            Assert.IsFalse(PrimeNumbers.Prime.IsPrime(-7));
            Assert.IsFalse(PrimeNumbers.Prime.IsPrime(-1));
        }
        [TestMethod]
        public void PrimeTest_Sums()
        {
            Assert.AreEqual(10, PrimeNumbers.Prime.PrimeSum(3));
            Assert.AreEqual(28, PrimeNumbers.Prime.PrimeSum(5));
            Assert.AreEqual(2, PrimeNumbers.Prime.PrimeSum(1));
        }
    }
}
