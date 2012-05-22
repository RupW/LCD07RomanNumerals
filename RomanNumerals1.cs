using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumeralsTest
{
    public class RomanNumerals1 : IRomanNumerals
    {
        public SortedList<int, String> Symbols = new SortedList<int, string> {
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

        public KeyValuePair<int, string> HighestDivisor(int input)
        {
            return Symbols.LastOrDefault(kv => kv.Key <= input);
        }

        public void BuildStringDivide(StringBuilder output, int input)
        {
            int remaining = input;
            while (remaining > 0)
            {
                var nextCharacter = HighestDivisor(remaining);
                int count = remaining / nextCharacter.Key;
                remaining = remaining % nextCharacter.Key;
                for (; count > 0; --count)
                {
                    output.Append(nextCharacter.Value);
                }
            }
        }

        public String ToRomanNumerals(int input)
        {
            var output = new StringBuilder();
            BuildStringDivide(output, input);
            return output.ToString();
        }
    }
}