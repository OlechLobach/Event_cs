using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;

namespace StringExtensions.Test
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void CountConsonants_EmptyString_ReturnsZero()
        {
            string input = "";

            int count = input.CountConsonants();

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void CountConsonants_NoConsonants_ReturnsZero()
        {
            string input = "aeiou";

            int count = input.CountConsonants();

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void CountConsonants_MixedString_ReturnsCorrectCount()
        {
            string input = "Hello, World!";

            int count = input.CountConsonants();

            Assert.AreEqual(7, count);
        }

        [TestMethod]
        public void CountConsonants_NullString_ReturnsZero()
        {
            string input = null;

            int count = input.CountConsonants();

            Assert.AreEqual(0, count);
        }
    }
}