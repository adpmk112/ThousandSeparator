using System;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Program program = new Program();

            Console.WriteLine(program.ThousandSeparator(1000.25));
        }

        public string DefaultThousandSeparator(decimal word)
        {
            string separatedValue = String.Format("{0:#,##0}", word);
            return separatedValue;
        }

        public string DecimalThousandSeparator(decimal word) //seperated with decimal
        {
            string separatedValue = String.Format("{0:#,##0.00}", word);
            return separatedValue;
        }

        public string ThousandSeparator(object word) //this separator aim for decimal input
        {
            char last, beforeLast, checkdot;
            string splittedVal;

            string stringWord = word.ToString();

            last = stringWord[stringWord.Length - 1];

            if (stringWord.Length >= 3)
            {
                beforeLast = stringWord[stringWord.Length - 2];
                checkdot = stringWord[stringWord.Length - 3];
            }

            else
            {
                splittedVal = stringWord;
                return DefaultThousandSeparator(Convert.ToDecimal(splittedVal));
            }

            if (last == '0' && beforeLast == '0' && checkdot == '.')
            {
                char[] delimiterChars = { '.' };
                string[] words = stringWord.Split(delimiterChars, 2);

                splittedVal = words[0];
                return DefaultThousandSeparator(Convert.ToDecimal(splittedVal));
            }

            else
            {
                splittedVal = stringWord;
                return DecimalThousandSeparator(Convert.ToDecimal(splittedVal));
            }
        }
    }
}
