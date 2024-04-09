using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class IntExtensionsTest
{
    [TestMethod]
    public void IsFibonacci_WhenNumberIsFibonacci_ReturnsTrue()
    {
        int fibonacciNumber = 5;

        bool result = fibonacciNumber.IsFibonacci();

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsFibonacci_WhenNumberIsNotFibonacci_ReturnsFalse()
    {
        int nonFibonacciNumber = 10;

        bool result = nonFibonacciNumber.IsFibonacci();

        Assert.IsFalse(result);
    }
}