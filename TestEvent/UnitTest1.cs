using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayExtensions;
using System;

namespace ArrayExtensions.Test
{
    [TestClass]
    public class ArrayExtensionsTests
    {
        [TestMethod]
        public void Filter_ReturnsEvenNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] result = numbers.Filter(x => x % 2 == 0);

            CollectionAssert.AreEqual(new[] { 2, 4, 6, 8, 10 }, result);
        }

        [TestMethod]
        public void Filter_ReturnsOddNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] result = numbers.Filter(x => x % 2 != 0);

            CollectionAssert.AreEqual(new[] { 1, 3, 5, 7, 9 }, result);
        }
    }
}