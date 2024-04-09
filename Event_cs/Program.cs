using System;

namespace StringExtensions
{
    public static class StringExtensions
    {
        public static int CountConsonants(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;

            int consonantCount = 0;
            foreach (char c in str.ToLower())
            {
                if (char.IsLetter(c) && !"aeiou".Contains(c))
                {
                    consonantCount++;
                }
            }

            return consonantCount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello, World!";
            int consonantCount = input.CountConsonants();
            Console.WriteLine($"Number of consonants in '{input}': {consonantCount}");
        }
    }
}