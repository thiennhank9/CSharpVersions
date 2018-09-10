using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate T NumberChanger<T>(T n);
namespace _2GenericDelegate
{
    class Program
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Generic Delegate trong C#");
            Console.WriteLine("--------------------------------");

            //tao cac doi tuong delegate
            NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);

            //goi hai phuong thuc boi su dung doi tuong delegate
            nc1(25);
            Console.WriteLine("1 - Gia tri cua num la: {0}", getNum());
            nc2(5);
            Console.WriteLine("2 - Gia tri cua num la: {0}", getNum());
            Console.ReadKey();
        }
    }
}
