using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2GenericMethod
{
    class Program
    {
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Generic trong C#");
            Console.WriteLine("-------- Vi du trao doi gia tri ------");

            int a, b;
            char c, d;
            a = 10;
            b = 20;
            c = 'I';
            d = 'V';

            // Hien thi cac gia tri truoc khi trao doi:
            Console.WriteLine("Cac gia tri int truoc khi goi ham swap: ");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Cac gia tri char truoc khi goi ham swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);

            //goi ham swap de trao doi gia tri
            Swap<int>(ref a, ref b);
            Swap<char>(ref c, ref d);

            // Hien thi cac gia tri sau khi trao doi:
            Console.WriteLine("Cac gia tri int sau khi goi ham swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Cac gia tri char sau khi goi ham swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);

            Console.ReadKey();
        }
    }
}
