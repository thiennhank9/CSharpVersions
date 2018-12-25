using System;
using static System.Console;

namespace _6ExceptionFilter
{
    class Program
    {
        public string currency { get; } = "VND";

        public string getCurrency => "1000" + currency;

        static void Main(string[] args)
        {
            int b = 0, c = 0;
            try
            {
                WriteLine($"1 / ({b} * {c}) = {1 / (b * c)}");
            }
            catch (DivideByZeroException) when (b == 0 && c == 0)
            {
                WriteLine("Divide by b = 0 and c = 0");
            }
            catch (DivideByZeroException) when (b == 0)
            {
                WriteLine("Divide by b = 0");
            }
            catch (DivideByZeroException) when (c == 0)
            {
                WriteLine("Divide by c = 0");
            }

            try
            {
                Console.WriteLine("abc");
            }
            catch (DivideByZeroException ex) when (b == 0)
            {
                Console.WriteLine("b = 0");
            }
        }
    }
}
