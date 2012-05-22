using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumeralsTest
{
    public interface IRomanNumerals
    {
        /// <summary>
        ///   Convert a positive integer to modern Roman numerals
        /// </summary>
        /// <param name="value">Positive integer to convert</param>
        /// <returns>The representation of the input number in modern Roman numerals</returns>
        string ToRomanNumerals(int value);
    }
}
