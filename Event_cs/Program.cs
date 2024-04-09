using System;

namespace StringExtensions
{
    public static class StringExtensions
    {
        public static int LengthOfLastWord(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }

            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 0)
            {
                return 0;
            }

            return words[words.Length - 1].Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text = "This is a sample sentence";
            int length = text.LengthOfLastWord();
            Console.WriteLine($"Length of last word: {length}");
        }
    }
}