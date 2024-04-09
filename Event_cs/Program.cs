using System;
using System.Linq;

namespace ArrayExtensions
{
    public static class ArrayExtensions
    {
        public static int[] Filter(this int[] array, Func<int, bool> predicate)
        {
            return array.Where(predicate).ToArray();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] evenNumbers = numbers.Filter(x => x % 2 == 0);
            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));

            int[] oddNumbers = numbers.Filter(x => x % 2 != 0);
            Console.WriteLine("Odd numbers: " + string.Join(", ", oddNumbers));
        }
    }
}