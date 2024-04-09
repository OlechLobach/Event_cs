using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionCalculator;

namespace FractionCalculator.Tests
{
    [TestClass]
    public class FractionTests
    {
        [TestMethod]
        public void TestMin_TwoFractions_ReturnsMinimumFraction()
        {
            var fraction1 = new Fraction(1, 2);
            var fraction2 = new Fraction(3, 4);

            var result = fraction1.Min(fraction2);

            Assert.AreEqual(1, result.Numerator);
            Assert.AreEqual(2, result.Denominator);
        }

        [TestMethod]
        public void TestMax_TwoFractions_ReturnsMaximumFraction()
        {
            var fraction1 = new Fraction(1, 2);
            var fraction2 = new Fraction(3, 4);

            var result = fraction1.Max(fraction2);

            Assert.AreEqual(3, result.Numerator);
            Assert.AreEqual(4, result.Denominator);
        }

        [TestMethod]
        public void TestToDouble_ConvertFractionToDouble_ReturnsCorrectValue()
        {
            var fraction = new Fraction(1, 2);

            var result = fraction.ToDouble();

            Assert.AreEqual(0.5, result);
        }
    }
}