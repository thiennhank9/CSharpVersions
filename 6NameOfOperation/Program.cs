using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6NameOfOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello";
            DoWork(str);
            DoWork(null);
        }
        public static void DoWork(string name)
        {
            Console.WriteLine(nameof(name));
            if (name == null)
                throw new ArgumentNullException(nameof(name));
        }

    }
}
