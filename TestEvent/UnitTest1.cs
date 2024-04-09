using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Test
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void WordCount_EmptyString_ReturnsZero()
        {
            string input = "";

            int count = input.WordCount();

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void WordCount_SingleWord_ReturnsOne()
        {
            string input = "Hello";

            int count = input.WordCount();

            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void WordCount_MultipleWords_ReturnsCorrectCount()
        {
            string input = "This is a test string";

            int count = input.WordCount();

            Assert.AreEqual(5, count);
        }

        [TestMethod]
        public void WordCount_ExtraSpaces_ReturnsCorrectCount()
        {
            string input = "   There   are    extra  spaces   ";

            int count = input.WordCount();

            Assert.AreEqual(4, count);
        }
    }
}