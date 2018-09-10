using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Partial
{
    public partial class CoOrds
    {
        private int x;
        private int y;

        public CoOrds(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public partial class CoOrds
    {
        public void PrintCoOrds()
        {
            Console.WriteLine("{0},{1}", x, y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CoOrds testPartial = new CoOrds(10, 15);
            testPartial.PrintCoOrds();

        }
    }
}
