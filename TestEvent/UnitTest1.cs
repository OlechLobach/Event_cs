using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntegerExtensions;

namespace IntegerExtensions.Test
{
    [TestClass]
    public class IntegerExtensionTests
    {
        [TestMethod]
        public void IsOdd_WhenNumberIsOdd_ReturnsTrue()
        {
            int number = 5;

            bool result = number.IsOdd();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsOdd_WhenNumberIsEven_ReturnsFalse()
        {
            int number = 6;

            bool result = number.IsOdd();

            Assert.IsFalse(result);
        }
    }
}