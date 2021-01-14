using System;

namespace Solid.Helpers.Utils
{
    public static class Calculator
    {
        public static bool IsBetween(this int num, int lower, int upper, bool inclusive = false)
        {
            return inclusive
                ? lower <= num && num <= upper
                : lower < num && num < upper;
        }
        public static bool IsBetween(this double num, double lower, double upper, bool inclusive = false)
        {
            return inclusive
                ? lower <= num && num <= upper
                : lower < num && num < upper;
        }
        public static bool IsBetween(this decimal num, decimal lower, decimal upper, bool inclusive = false)
        {
            return inclusive
                ? lower <= num && num <= upper
                : lower < num && num < upper;
        }

        public static decimal Difference(this decimal value1, decimal value2)
        {
            return Math.Abs(value1 - value2);
        }

        public static decimal ApplyPercentage(this decimal value, double ratio)
        {
            return (value * Convert.ToDecimal(ratio));
        }
    }
}