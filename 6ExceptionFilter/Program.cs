using System;
using static System.Console;

namespace _6ExceptionFilter
{
    class Program
    {
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
        }
    }
}
