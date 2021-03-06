using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoInterator.SomeNumbers());

           foreach (int value in SomeNumbers())
            {
                Console.Write(value.ToString() + " ");
            }
            // Output: 3 5 7 
            Console.ReadKey();
        }

        public static System.Collections.IEnumerable SomeNumbers()
        {
            yield return 3;
            yield return 5;
            yield return 7;
        }
    }

    public class DoInterator
    {
        public static System.Collections.IEnumerable SomeNumbers()
        {
            yield return 3;
            yield return 5;
            yield return 7;
        }
    }
}
