using System;

namespace StringExtensions
{
    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }

            string[] words = str.Split(new char[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = "This is a test string";
            int count = input.WordCount();
            Console.WriteLine($"Word count: {count}");
        }
    }
}