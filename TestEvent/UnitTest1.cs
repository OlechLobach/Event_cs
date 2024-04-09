using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;

namespace StringExtensions.Test
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void CountSentences_EmptyString_ReturnsZero()
        {
            string input = "";

            int count = input.CountSentences();

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void CountSentences_SingleSentence_ReturnsOne()
        {
            string input = "This is a test sentence.";

            int count = input.CountSentences();

            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void CountSentences_MultipleSentences_ReturnsCorrectCount()
        {
            string input = "This is a test sentence. Another sentence follows! And one more? Yes, one more.";

            int count = input.CountSentences();

            Assert.AreEqual(4, count);
        }
    }
}