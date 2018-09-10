using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            TestGenericClass<int> intGeneric = new TestGenericClass<int>(3);

            for (int i = 0; i < 3; i++)
            {
                intGeneric.setItem(i, i);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write(intGeneric.getItem(i) + " ");
            }

            TestGenericClass<bool> boolGeneric = new TestGenericClass<bool>(3);

            for (int i = 0; i < 3; i++)
            {
                boolGeneric.setItem(i, true);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write(boolGeneric.getItem(i) + " ");
            }
        }
    }

    class TestGenericClass<T>
    {
        private T[] array;

        public TestGenericClass(int size)
        {
            array = new T[size + 1];
        }

        public T getItem(int index)
        {
            return array[index];
        }

        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }
}
