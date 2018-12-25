using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2oNullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num = null;

            // Is the HasValue property true?
            if (num.HasValue)
            {
                Console.WriteLine("has num = " + num.Value);
            }
            else
            {
                Console.WriteLine("num = Null");
            }

            Console.WriteLine("Add to nullable " + (num + 1));

            // y is set to zero
            int y = num.GetValueOrDefault();

            // num.Value throws an InvalidOperationException if num.HasValue is false
            try
            {
                y = num.Value;
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
