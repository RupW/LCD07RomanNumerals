using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumeralsTest
{
    public class RomanNumerals1
    {




        public SortedList<int, String> symbols = new SortedList<int, string> {
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

        public String BuildStringOfCharacters(int count, int value)
        {
            StringBuilder output = new StringBuilder();

            String numeral = symbols[value];
            for (int i = 0; i < count; ++i)
            {
                output.Append(numeral);
            }

            return output.ToString();
        }

        public KeyValuePair<int, string> HighestDivisor(int input)
        {
            return symbols.Where(kv => kv.Key <= input).LastOrDefault();
        }

        public String BuildStringDivide(int input)
        {
            int remaining = input;
            StringBuilder output = new StringBuilder();
            while (remaining > 0)
            {
                var nextCharacter = HighestDivisor(remaining);
                int count = remaining / nextCharacter.Key;
                remaining = remaining % nextCharacter.Key;
                output.Append(BuildStringOfCharacters(count, nextCharacter.Key));
            }
            return output.ToString();
        }

        public String ToRomanNumerals(int input)
        {
            return BuildStringDivide(input);
        }

        #region Numeral class code


        public Numeral HighestDivisorNumeral(int input)
        {
            return numerals.Where(kv => kv.Key <= input).Select(kv => kv.Value).LastOrDefault();
        }

        public class Numeral
        {
            public Numeral(int value, String symbol, int? maxAllowed)
            {
                Value = value;
                Symbol = symbol;
                MaxAllowed = maxAllowed; // qq can compute
            }

            public int Value { get; set; }
            public String Symbol { get; set; }
            public int? MaxAllowed { get; set; }
        }

        public SortedList<int, Numeral> numerals = new SortedList<int, Numeral> {
            { 1, new Numeral(1, "I", 3) },
            { 5, new Numeral(5, "V", 1) },
            { 10, new Numeral(10, "X", 3) },
            { 50, new Numeral(50, "L", 1) },
            { 100, new Numeral(100, "C", 3) },
            { 500, new Numeral(500, "D", 1) },
            { 1000, new Numeral(1000, "M", null) } };

        public String BuildStringOfCharacters(int count, Numeral numeral)
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < count; ++i)
            {
                output.Append(numeral.Symbol);
            }

            return output.ToString();
        }
        public String BuildStringDivideNumeral(int input)
        {
            int remaining = input;
            StringBuilder output = new StringBuilder();
            while (remaining > 0)
            {
                var nextCharacter = HighestDivisorNumeral(remaining);
                int count = remaining / nextCharacter.Value;
                remaining = remaining % nextCharacter.Value;
                output.Append(BuildStringOfCharacters(count, nextCharacter));
            }
            return output.ToString();
        }

        #endregion

        #region Other old code


        public String MatchSingleSymbol(int input)
        {
            switch (input)
            {
                case 1: return "I";
                case 5: return "V";
                case 10: return "X";
                case 50: return "L";
                case 100: return "C";
                case 500: return "D";
                case 1000: return "M";
            }
            return null;
        }


        public String BuildStringAdd(int input)
        {
            int count = input;
            StringBuilder output = new StringBuilder();
            while (count > 0)
            {
                var nextCharacter = HighestDivisor(count);
                count -= nextCharacter.Key;
                output.Append(nextCharacter.Value);
            }
            return output.ToString();
        }

        #endregion
    }
}