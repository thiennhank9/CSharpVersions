using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void PrintString(string str);
namespace _2AnonymousMethod
{
    class Program
    {
        public static void InChu(string str)
        {
            Console.Write(str);
        }

        static void Main(string[] args)
        {
            PrintString dlg = new PrintString(InChu);

            dlg("hello");

            PrintString anonymousFunc = delegate (string str)
            {
                Console.Write(str);
            };

            anonymousFunc("bye bye");
        }
    }
}
