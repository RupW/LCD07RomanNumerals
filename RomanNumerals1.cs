using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumeralsTest
{
    /// <summary>
    ///   Compute Modern Roman Numerals for a given integer using a sorted list of symbols
    /// </summary>
    /// <remarks>
    ///   Iteration one solution, pairing with Adnan.
    /// </remarks>
    public class RomanNumerals1 : IRomanNumerals
    {
        /// <summary>
        ///   The set of Roman numeral symbols in greatest-first order.
        ///   We include the permitted one-subtraction symbols in this list.
        /// </summary>
        /// <remarks>
        ///   Ideally we would start with the basic list and compute the subtraction rows too!
        /// </remarks>
        public static readonly SortedList<int, String> Symbols = new SortedList<int, string>(new ReverseIntegerComparer()) {
            { 1, "I" },
            { 4, "IV" },
            { 5, "V" },
            { 9, "IX" },
            { 10, "X" },
            { 40, "XL" },
            { 50, "L" },
            { 90, "XC" },
            { 100, "C" },
            { 400, "CD" },
            { 500, "D" },
            { 900, "CM" },
            { 1000, "M" }
        };

        public String ToRomanNumerals(int input)
        {
            var output = new StringBuilder();

            int remainder = input;
            foreach(var symbol in Symbols)
            {
                int count = remainder / symbol.Key;
                remainder %= symbol.Key;
                for (; count > 0; --count)
                {
                    output.Append(symbol.Value);
                }
            }

            return output.ToString();
        }

        private class ReverseIntegerComparer : Comparer<int>
        {
            public override int Compare(int x, int y)
            {
                return y.CompareTo(x);
            }
        }
    }
}
