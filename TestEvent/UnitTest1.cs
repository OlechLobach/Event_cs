using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntegerExtensions;

namespace IntegerExtensions.Tests
{
    [TestClass]
    public class IntegerExtensionsTests
    {
        [TestMethod]
        public void IsPrime_PrimeNumber_ReturnsTrue()
        {
            int primeNumber = 17;

            bool isPrime = primeNumber.IsPrime();

            Assert.IsTrue(isPrime);
        }

        [TestMethod]
        public void IsPrime_NonPrimeNumber_ReturnsFalse()
        {
            int nonPrimeNumber = 20;

            bool isPrime = nonPrimeNumber.IsPrime();

            Assert.IsFalse(isPrime);
        }
    }
}