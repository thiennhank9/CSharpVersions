using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7TupleAndDeconstruct
{
    class ClassSample
    {
        public int Min { get; set; }
        public int Max { get; set; }

        public static ClassSample FindMinMax(int[] array)
        {
            int max = array[0], min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                min = array[i] < min ? array[i] : min;
                max = array[i] > max ? array[i] : max;
            }
            ClassSample data = new ClassSample
            {
                Min = min,
                Max = max
            };
            return data;
        }

        public void Deconstruct(out int min, out int max)
        {
            min = Min;
            max = Max;
        }
    }
}
