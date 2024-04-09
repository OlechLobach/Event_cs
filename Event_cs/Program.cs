using System;

namespace IntegerExtensions
{
    public static class IntegerExtensions
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            Console.WriteLine($"Is {number} even? {number.IsEven()}");

            number = 7;
            Console.WriteLine($"Is {number} even? {number.IsEven()}");
        }
    }
}