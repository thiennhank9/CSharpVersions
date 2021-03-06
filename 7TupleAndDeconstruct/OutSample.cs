﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7TupleAndDeconstruct
{
    class OutSample
    {
        public static int FindMinMax(int[] array, out int m)
        {
            int max = array[0], min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                min = array[i] < min ? array[i] : min;
                max = array[i] > max ? array[i] : max;
            }
            m = max;
            return min;
        }
    }
}
