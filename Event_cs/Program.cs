using System;

namespace FractionCalculator
{
    public class Fraction
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }

            Numerator = numerator;
            Denominator = denominator;
        }

        public double ToDouble()
        {
            return (double)Numerator / Denominator;
        }
    }

    public static class FractionExtensions
    {
        public static Fraction Min(this Fraction first, Fraction second)
        {
            return first.ToDouble() < second.ToDouble() ? first : second;
        }

        public static Fraction Max(this Fraction first, Fraction second)
        {
            return first.ToDouble() > second.ToDouble() ? first : second;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var fraction1 = new Fraction(1, 2);
            var fraction2 = new Fraction(3, 4);

            var minFraction = fraction1.Min(fraction2);
            var maxFraction = fraction1.Max(fraction2);

            Console.WriteLine($"Minimum fraction: {minFraction.Numerator}/{minFraction.Denominator}");
            Console.WriteLine($"Maximum fraction: {maxFraction.Numerator}/{maxFraction.Denominator}");
        }
    }
}