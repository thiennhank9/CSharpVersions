using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ExpandedExpressionBodiedMembers
{
    class Program
    {
        public class ExpressionMembersExample
        {
            private string label;
            // Expression-bodied constructor
            public ExpressionMembersExample(string label) => this.Label = label;
            // Expression-bodied finalizer
            ~ExpressionMembersExample() => Console.Error.WriteLine("Finalized!");
            // Expression-bodied get / set accessors.
            public string Label
            {
                get => label;
                set => this.label = value ?? "Default label";
            }

        }
        static void Main(string[] args)
        {
            ExpressionMembersExample ex = new ExpressionMembersExample("str1");
            Console.WriteLine(ex.Label);
        }
    }
}
