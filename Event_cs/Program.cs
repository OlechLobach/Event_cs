using System;

public static class IntExtensions
{
    public static bool IsFibonacci(this int number)
    {
        return IsPerfectSquare(5 * number * number + 4) ||
               IsPerfectSquare(5 * number * number - 4);
    }

    private static bool IsPerfectSquare(int number)
    {
        int sqrt = (int)Math.Sqrt(number);
        return sqrt * sqrt == number;
    }
}

class Program
{
    static void Main()
    {
        int number = 5;
        if (number.IsFibonacci())
        {
            Console.WriteLine($"{number} is a Fibonacci number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a Fibonacci number.");
        }
    }
}