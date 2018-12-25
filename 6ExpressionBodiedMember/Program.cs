using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ExpressionBodiedMember
{
    public class Money
    {
        public string Currency => "VND";
        public string Value() => "1000 " + Currency;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money();

            Console.WriteLine(money.Value());
            Console.ReadKey();
        }
    }
}
