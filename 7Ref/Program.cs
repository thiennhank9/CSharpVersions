using System;
using static System.Console;

namespace _7Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 15, -39, 0, 7, 14, -12 };
            ref int place = ref Find(7, array);
            place = 9;
            PrintArray(array);
        }

        static ref int Find(int number, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return ref numbers[i];
                }
            }
            throw new IndexOutOfRangeException();
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Write($"{array[i]} ");
            }
            WriteLine();
        }
    }
}
