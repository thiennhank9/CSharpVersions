using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2PartialMethod
{
    partial class DefineMethod
    {
        private int x;
        private int y;

        DefineMethod(int firstValue, int lastValue)
        {
            x = firstValue;
            y = lastValue;
        }

        public Array getValue()
        {
            return new int[] { x, y };
        }

        partial void testPartial()
        {
            Console.WriteLine("--- test partial method");
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
