using static System.Console;

namespace _6PropertyInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money();
            //money.Currency = "USD";
            //money.Price = 1;
            WriteLine(money.GetMoney());
        }
    }

    public class Money
    {
        public string Currency { get; } = "VND";
        public int Price => 1000;
        public string GetMoney() => string.Format("{0} {1}", Price, Currency);
    }
}
