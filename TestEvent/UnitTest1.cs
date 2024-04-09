
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Test
{
    [TestClass]
    public class StringExtensionTests
    {
        [TestMethod]
        public void LengthOfLastWord_EmptyString_ReturnsZero()
        {
            string input = "";

            int length = input.LengthOfLastWord();

            Assert.AreEqual(0, length);
        }

        [TestMethod]
        public void LengthOfLastWord_SingleWord_ReturnsLength()
        {
            string input = "Hello";

            int length = input.LengthOfLastWord();

            Assert.AreEqual(5, length);
        }

        [TestMethod]
        public void LengthOfLastWord_MultipleWords_ReturnsLengthOfLastWord()
        {
            string input = "This is a test sentence";

            int length = input.LengthOfLastWord();

            Assert.AreEqual(8, length);
        }

        [TestMethod]
        public void LengthOfLastWord_ExtraSpaces_ReturnsLengthOfLastWord()
        {
            string input = "   There   are    extra  spaces   ";

            int length = input.LengthOfLastWord();

            Assert.AreEqual(6, length);
        }

        [TestMethod]
        public void LengthOfLastWord_NullString_ReturnsZero()
        {
            string input = null;

            int length = input.LengthOfLastWord();

            Assert.AreEqual(0, length);
        }
    }
}