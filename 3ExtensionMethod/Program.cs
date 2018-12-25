using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ExtensionMethod
{
    public static class StringExtension
    {
        public static void PrintHello(this string str)
        {
            Console.WriteLine(str + " Hello");            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            String str = "Nhan";
            str.PrintHello();
            // "Nhan Hello"
        }
    }
}
