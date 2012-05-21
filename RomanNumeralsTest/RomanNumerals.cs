using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumeralsTest
{
    public class RomanNumerals
    {
        public string ToRomanNumerals(int value)
        {
            return new string('M', value / 1000)
                + MakeDigit('C', 'D', 'M', (value / 100) % 10)
                + MakeDigit('X', 'L', 'C', (value / 10) % 10)
                + MakeDigit('I', 'V', 'X', value % 10);
        }

        private string MakeDigit(char one, char five, char ten, int value)
        {
            int numberOfOnes = value % 5;
            bool isOverFive = value >= 5;

            if (numberOfOnes == 4) {
                return one.ToString() + (isOverFive ? ten : five);
            } else {
                return (isOverFive ? five.ToString() : "") + new string(one, numberOfOnes);
            }
        }

        /* Switch 0-9
        private string MakeDigitOld(char one, char five, char ten, int value)
        {
            switch (value % 10)
            {
                case 1:
                    return one.ToString();
                case 2:
                    return new string(one, 2);
                case 3:
                    return new string(one, 3);
                case 4:
                    return one.ToString() + five;
                case 5:
                    return five.ToString();
                case 6:
                    return five.ToString() + one;
                case 7:
                    return five.ToString() + new string(one, 2);
                case 8:
                    return five.ToString() + new string(one, 3); ;
                case 9:
                    return one.ToString() + ten;
                default:
                    return "";
            }
        }
        */
    }
}
