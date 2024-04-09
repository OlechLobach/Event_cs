using System;

namespace StringExtensions
{
    public static class StringExtensions
    {
        public static int CountVowels(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int count = 0;
            foreach (char c in str.ToLower())
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    count++;
                }
            }

            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello, World!";
            int vowelCount = input.CountVowels();
            Console.WriteLine($"Number of vowels in the string: {vowelCount}");
        }
    }
}