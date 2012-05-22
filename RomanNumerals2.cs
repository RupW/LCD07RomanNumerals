using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumeralsTest
{
    /// <summary>
    ///   Compute Modern Roman Numerals for a given integer, generating one digit at a time.
    /// </summary>
    /// <remarks>
    ///   Iteraion two solution, pairing with Matt.
    /// </remarks>
    public class RomanNumerals2 : IRomanNumerals
    {
        public string ToRomanNumerals(int value)
        {
            var output = new StringBuilder();

            for (int thousands = (value / 1000); thousands > 0; --thousands)
            {
                output.Append('M');
            }
            AppendDigit(output, 'C', 'D', 'M', (value / 100) % 10);
            AppendDigit(output, 'X', 'L', 'C', (value / 10) % 10);
            AppendDigit(output, 'I', 'V', 'X', value % 10);

            return output.ToString();
        }

        /// <summary>
        ///   Generate Roman numerals for a single digit 0-9; use configurable
        ///   numeral symbols to allow this to be applied to all of ones, tens and hundreds.
        /// 
        ///   This is the refactored-down form - see the original switch below!
        /// </summary>
        /// <param name="output">StringBuilder for output</param>
        /// <param name="one">Symbol to use for ones, e.g. I</param>
        /// <param name="five">Symbol to use for fives, e.g. V</param>
        /// <param name="ten">Symbol to use for tens, e.g. X</param>
        /// <param name="value">Digit 0-9 to encode</param>
        private static void AppendDigit(StringBuilder output, char one, char five, char ten, int value)
        {
            int numberOfOnes = value % 5;
            bool isOverFive = value >= 5;

            if (numberOfOnes == 4)
            {
                output.Append(one);
                output.Append(isOverFive ? ten : five);
            }
            else
            {
                if (isOverFive) output.Append(five);
                output.Append(one, numberOfOnes);
            }
        }

        /// <summary>
        ///   Generate Roman numerals for a single digit 0-9; use configurable
        ///   numeral symbols to allow this to be applied to all of ones, tens and hundreds.
        /// 
        ///   Original nine-entry switch statement.
        /// </summary>
        /// <param name="output">StringBuilder for output</param>
        /// <param name="one">Symbol to use for ones, e.g. I</param>
        /// <param name="five">Symbol to use for fives, e.g. V</param>
        /// <param name="ten">Symbol to use for tens, e.g. X</param>
        /// <param name="value">Digit 0-9 to encode</param>
        private static void AppendDigitSwitch(StringBuilder output, char one, char five, char ten, int value)
        {
            switch (value % 10)
            {
                case 1:
                    output.Append(one);
                    break;
                case 2:
                    output.Append(one, 2);
                    break;
                case 3:
                    output.Append(one, 3);
                    break;
                case 4:
                    output.Append(one);
                    output.Append(five);
                    break;
                case 5:
                    output.Append(five);
                    break;
                case 6:
                    output.Append(five);
                    output.Append(one);
                    break;
                case 7:
                    output.Append(five);
                    output.Append(one, 2);
                    break;
                case 8:
                    output.Append(five);
                    output.Append(one, 3);
                    break;
                case 9:
                    output.Append(one);
                    output.Append(ten);
                    break;
            }
        }
    }
}
