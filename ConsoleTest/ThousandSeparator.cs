using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTest
{
    class ThousandSeparator
    {
        public string DefaultSeparate(decimal word)
        {
            string separatedValue = String.Format("{0:#,##0}", word);
            return separatedValue;
        }

        public string SeparateWithDecimal(decimal word) //seperated with decimal
        {
            string separatedValue = String.Format("{0:#,##0.00}", word);
            return separatedValue;
        }

        public string SeperateWithOneDecimalPlace(decimal word)
        {
            string separatedValue = String.Format("{0:#,##0.0}", word);
            return separatedValue;
        }

        public string EnhancedSeparate(object word) 
        {
            char last; 
            char beforeLast = '1' , checkdot = '1';
            string splittedVal;

            string stringWord = word.ToString();

            last = stringWord[stringWord.Length - 1];

            bool decimalNumber = stringWord.Contains(".");

            if (!decimalNumber) // 1 --> 1 not to get 1.00
            {
                return DefaultSeparate(Convert.ToDecimal(stringWord));
            }

            if (stringWord.Length == 3 && last == '0') //1.0 --> 1
            {
                return DefaultSeparate(Convert.ToDecimal(stringWord));
            }

            if (stringWord.Length == 3 && last != '0') //1.2 --> 1.2 not to get 1.20
            {
                return SeperateWithOneDecimalPlace(Convert.ToDecimal(stringWord));
            }

            if (stringWord.Length >= 3)
            {
                beforeLast = stringWord[stringWord.Length - 2];
                checkdot = stringWord[stringWord.Length - 3];
            }

            if (last == '0' && beforeLast == '0' && checkdot == '.') //1.00 --> 1 
            {
                char[] delimiterChars = { '.' };
                string[] words = stringWord.Split(delimiterChars, 2);

                splittedVal = words[0];
                return DefaultSeparate(Convert.ToDecimal(splittedVal));
            }

            else
            {
                splittedVal = stringWord;
                return SeparateWithDecimal(Convert.ToDecimal(splittedVal));
            }
        }
    }
}
