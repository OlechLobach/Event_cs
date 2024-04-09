using System;
using System.Collections.Generic;

namespace StringExtensions
{
    public static class StringExtensions
    {
        public static bool IsValidParentheses(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return true;

            var stack = new Stack<char>();
            var mappings = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            foreach (char c in str)
            {
                if (mappings.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else if (mappings.ContainsValue(c))
                {
                    if (stack.Count == 0 || mappings[stack.Pop()] != c)
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "{}[]";
            Console.WriteLine($"IsValidParentheses for '{input1}': {input1.IsValidParentheses()}");

            string input2 = "[}]";
            Console.WriteLine($"IsValidParentheses for '{input2}': {input2.IsValidParentheses()}");

            string input3 = "[[{]}]";
            Console.WriteLine($"IsValidParentheses for '{input3}': {input3.IsValidParentheses()}");
        }
    }
}
