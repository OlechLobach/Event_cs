using System;

namespace IntegerExtensions
{
    public static class IntegerExtensions
    {
        public static bool IsPrime(this int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int number = 17;

            if (number.IsPrime())
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }
    }
}