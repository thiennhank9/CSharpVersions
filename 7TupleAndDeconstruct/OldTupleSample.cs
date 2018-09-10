using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7TupleAndDeconstruct
{
    class OldTupleSample
    {
        public static Tuple<int, int> FindMinMax(int[] array)
        {
            int max = array[0], min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                min = array[i] < min ? array[i] : min;
                max = array[i] > max ? array[i] : max;
            }
            return new Tuple<int, int>(min, max);
        }
    }
}
