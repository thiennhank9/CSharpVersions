using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 1;
            b = 2;
            c = 3;

            // Before
            //Console.WriteLine(string.Format("{0} + {1} = {2}", a, b, a + b));
            //Console.WriteLine(string.Format(a + " + " + b + " = " + (a + b)));

            // In C# 6
            Console.WriteLine($"{a} + {b} = {c}");

            Console.ReadKey();

        }
    }
}
