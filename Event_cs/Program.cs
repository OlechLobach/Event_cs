using System;

namespace IntegerExtensions
{
    public static class IntegerExtensions
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            bool isOdd = number.IsOdd();
            Console.WriteLine($"Is {number} odd? {isOdd}");
        }
    }
}
