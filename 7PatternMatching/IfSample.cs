using static System.Console;

namespace _7PatternMatching
{
    class IfSample
    {
        public static void CheckType(object o)
        {
            if (o is null)
                WriteLine("o is null");
            else if (o is int i)
                WriteLine($"o is int, o = {i}");
            else if (o is string s)
                WriteLine($"o is string, o = \"{s}\"");
            else if (o is bool t)
                WriteLine($"o is bool, o = \"{t}\"");
            else
                WriteLine("unknown type");
        }
    }
}
