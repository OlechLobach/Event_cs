using System;
using System.Linq;

namespace TemperatureAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            DaytimeTemperature[] temperatures = new DaytimeTemperature[]
            {
                new DaytimeTemperature { Day = 1, HighestTemperature = 25, LowestTemperature = 10 },
                new DaytimeTemperature { Day = 2, HighestTemperature = 30, LowestTemperature = 15 },
                new DaytimeTemperature { Day = 3, HighestTemperature = 20, LowestTemperature = 5 },
                new DaytimeTemperature { Day = 4, HighestTemperature = 28, LowestTemperature = 12 },
                new DaytimeTemperature { Day = 5, HighestTemperature = 22, LowestTemperature = 8 }
            };

            int maxDifference = temperatures.Max(t => t.HighestTemperature - t.LowestTemperature);
            var daysWithMaxDifference = temperatures.Where(t => t.HighestTemperature - t.LowestTemperature == maxDifference);

            Console.WriteLine($"Days with maximum difference ({maxDifference}°C):");
            foreach (var day in daysWithMaxDifference)
            {
                Console.WriteLine($"Day {day.Day}");
            }
        }
    }

    public class DaytimeTemperature
    {
        public int Day { get; set; }
        public int HighestTemperature { get; set; }
        public int LowestTemperature { get; set; }

        public int CalculateTemperatureDifference()
        {
            return HighestTemperature - LowestTemperature;
        }
    }
}