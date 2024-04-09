using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Test
{
    [TestClass]
    public class StringExtensionTests
    {
        [TestMethod]
        public void IsValidParentheses_EmptyString_ReturnsTrue()
        {
            string input = "";

            bool isValid = input.IsValidParentheses();

            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void IsValidParentheses_ValidString_ReturnsTrue()
        {
            string input = "{}[]";

            bool isValid = input.IsValidParentheses();

            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void IsValidParentheses_ValidNestedString_ReturnsTrue()
        {
            string input = "[{}]";

            bool isValid = input.IsValidParentheses();

            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void IsValidParentheses_InvalidString_ReturnsFalse()
        {
            string input = "[}";

            bool isValid = input.IsValidParentheses();

            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsValidParentheses_InvalidNestedString_ReturnsFalse()
        {
            string input = "[[{]}]";

            bool isValid = input.IsValidParentheses();

            Assert.IsFalse(isValid);
        }
    }
}