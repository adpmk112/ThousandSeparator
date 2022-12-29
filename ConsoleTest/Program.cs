using System;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "1205.009";

            ThousandSeparator thousandSeparator = new ThousandSeparator();

            Console.WriteLine(thousandSeparator.EnhancedSeparate(text));
        }
    }
}
