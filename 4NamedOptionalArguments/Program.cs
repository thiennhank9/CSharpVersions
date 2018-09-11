using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4NamedOptionalArguments
{
    class Program
    {
        public static void printText(string text1, string text2)
        {
            Console.WriteLine(text1);
            Console.WriteLine(text2);
        }

        static void Main(string[] args)
        {
            printText(text2: "nhan", text1: "hello");
        }
    }
}
