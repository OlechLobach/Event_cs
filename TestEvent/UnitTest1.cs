using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;

namespace StringExtensions.Test
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void CountVowels_EmptyString_ReturnsZero()
        {
            string input = "";

            int count = input.CountVowels();

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void CountVowels_NoVowels_ReturnsZero()
        {
            string input = "12345";

            int count = input.CountVowels();

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void CountVowels_SingleVowel_ReturnsOne()
        {
            string input = "a";

            int count = input.CountVowels();

            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void CountVowels_MultipleVowels_ReturnsCorrectCount()
        {
            string input = "Hello, World!";

            int count = input.CountVowels();

            Assert.AreEqual(3, count);
        }
    }
}