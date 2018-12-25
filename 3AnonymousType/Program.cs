using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new { name = "BMW i8", manufactory = "BMW" };

            Console.WriteLine("the manufactory {0} factory {1} ", car.manufactory, car.name);
            Console.ReadKey();
        }
    }
}
