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
        public string Currency { get; } = "VND"; // read only
        public int Price => 1000; // read only
        public string GetMoney() => string.Format("{0} {1}", Price, Currency);
    }
}
