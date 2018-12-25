using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.WaitAll(ExAsync());
            //Task.WaitAll(AsyncMethod1(), AsyncMethod2());
        }

        static async Task AsyncMethod1()
        {
            await LoopFor("Method 1", 400);
            Console.WriteLine("Method 1 done!");
        }

        static async Task AsyncMethod2()
        {
            await LoopFor("Method 2", 600);
            Console.WriteLine("Method 2 done!");
        }

        static async Task LoopFor(string s, int ms)
        {
            int time = 0;
            for (int i = 0; i < 5; i++)
            {
                time += ms;
                await Task.Delay(ms);
                Console.WriteLine($"{s} at {time} ms");
            }
        }

        static async Task ExAsync()
        {
            HttpClient client = new HttpClient();

            Task<string> getStringTask = client.GetStringAsync("http://msdn.microsoft.com");

            PrintWaiting();

            string urlContents = await getStringTask;

            Console.WriteLine(urlContents);
            Console.WriteLine("Done");

        }

        static void PrintWaiting()
        {
            Console.WriteLine("Waiting");
        }
    }
}
