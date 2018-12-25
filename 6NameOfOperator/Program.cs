using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6NameOfOperator
{
    public class C
    {
        public static int Method1(string x, int y) { return y; }
        public static string Method1(string x, string y) { return y; }
        string f<T>() => nameof(T);
    }


    class Program
    {

        static void Main(string[] args)
        {
            var c = new C();

            Console.WriteLine(nameof(C)); // -> "C"  
            Console.WriteLine(nameof(C.Method1)); // -> "Method1"   
            Console.WriteLine(nameof(c.Method1)); // -> "Method1"   
        }
    }
}
