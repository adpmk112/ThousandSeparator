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

        public string EnhancedSeparate(object word) 
        {
            char last, beforeLast, checkdot;
            string splittedVal;

            string stringWord = word.ToString();

            last = stringWord[stringWord.Length - 1];

            bool decimalNumber = stringWord.Contains(".");

            if (!decimalNumber)
            {
                return DefaultSeparate(Convert.ToDecimal(stringWord));
            }

            if (stringWord.Length >= 3)
            {
                beforeLast = stringWord[stringWord.Length - 2];
                checkdot = stringWord[stringWord.Length - 3];
            }

            else
            {
                splittedVal = stringWord;
                return DefaultSeparate(Convert.ToDecimal(splittedVal));
            }

            if (last == '0' && beforeLast == '0' && checkdot == '.')
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
