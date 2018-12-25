using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ExtensionMethod
{
    class ExtensionMethod
    {
    }

    public static class IntExtensions
    {
        public static bool isGreateThan(this int i, int value)
        {
            return i > value;
        }
    }
}
