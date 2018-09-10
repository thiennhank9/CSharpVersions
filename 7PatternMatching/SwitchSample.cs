using static System.Console;

namespace _7PatternMatching
{
    class SwitchSample
    {
        public static void CheckType(object o)
        {
            switch (o)
            {
                case null:
                    WriteLine("o is null"); break;
                case int i:
                    WriteLine($"o is int, o = {i}"); break;
                case string s:
                    WriteLine($"o is string, o = \"{s}\""); break;
                default:
                    WriteLine("unknown type"); break;
            }
        }
    }
}
