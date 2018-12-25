using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6AwaitInCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2 };
            Task.WaitAll(Print2ndEle(a));
        }

        public static async Task Print2ndEle(int[] a)
        {
            try
            {
                Console.WriteLine(a[2]);

            }
            catch (Exception e)
            {
                Console.WriteLine("Doi sau 3s co exception");
                await Task.Delay(3000);
                Console.WriteLine(e.ToString());
            }
        }
    }
}
