using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3LambdaExpression
{
    class Program
    {
        delegate int del(int i);

        static void Main(string[] args)
        {
            del myDelegate = x => x * x;
            int j = myDelegate(5);
            Console.WriteLine(j);
        }
    }
}
