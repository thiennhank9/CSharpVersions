using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void PrintString(string str);
delegate string getString(string str);

namespace _2AnonymousMethod
{
    public class DoAnonymousMethod
    {
        public static string doAnonymousMethod(string textDemo)
        {
            getString anonymousFunc = delegate (string str)
            {
                return str;
            };

            return anonymousFunc(textDemo);
        }
    }

    public class Program
    {
        public static void InChu(string str)
        {
            Console.Write(str);
        }

        public static string doAnonymousMethod()
        {
            getString anonymousFunc = delegate (string str)
            {
                return str;
            };

            return anonymousFunc("bye bye");
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
