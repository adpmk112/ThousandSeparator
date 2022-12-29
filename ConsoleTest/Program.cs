using System;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int text = 1;

            ThousandSeparator thousandSeparator = new ThousandSeparator();

            Console.WriteLine(thousandSeparator.EnhancedSeparate(text));
        }
    }
}
