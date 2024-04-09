
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntegerExtensions;

namespace IntegerExtensions.Test
{
    [TestClass]
    public class IntegerExtensionsTests
    {
        [TestMethod]
        public void IsEven_EvenNumber_ReturnsTrue()
        {
            int number = 10;

            bool result = number.IsEven();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsEven_OddNumber_ReturnsFalse()
        {
            int number = 7;

            bool result = number.IsEven();

            Assert.IsFalse(result);
        }
    }
}