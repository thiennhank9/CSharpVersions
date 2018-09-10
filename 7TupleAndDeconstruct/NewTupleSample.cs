using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7TupleAndDeconstruct
{
    class NewTupleSample
    {
        public static (int min, int max) FindMinMax(int[] array)
        {
            int max = array[0], min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                min = array[i] < min ? array[i] : min;
                max = array[i] > max ? array[i] : max;
            }
            return (min, max);
        }
    }
}
