using System;

namespace StringExtensions
{
    public static class StringExtensions
    {
        public static int CountSentences(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;

            int count = 0;
            foreach (char c in str)
            {
                if (c == '.' || c == '!' || c == '?')
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
            string input = "This is a test sentence. Another sentence follows! And one more? Yes, one more.";
            int count = input.CountSentences();
            Console.WriteLine($"Number of sentences: {count}");
        }
    }
}