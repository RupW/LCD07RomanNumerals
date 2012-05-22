using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumeralsTest
{
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

        private void AppendDigit(StringBuilder output, char one, char five, char ten, int value)
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

        private void AppendDigitOld(StringBuilder output, char one, char five, char ten, int value)
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
