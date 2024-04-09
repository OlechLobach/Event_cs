using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TemperatureAnalyzer.Test
{
    [TestClass]
    public class DaytimeTemperatureTests
    {
        [TestMethod]
        public void CalculateTemperatureDifference_ValidInput_ReturnsCorrectDifference()
        {
            var temperature = new DaytimeTemperature { HighestTemperature = 25, LowestTemperature = 10 };

            var difference = temperature.CalculateTemperatureDifference();

            Assert.AreEqual(15, difference);
        }
    }
}