using static System.Console;

namespace _7LocalFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 0, 7, 2, 5, 4, 3, 6, 1, 8 };
            Sort(numbers);
            PrintArray(numbers);
        }

        static void Sort(int[] numbers)
        {
            #region SORTING ALGORITHM
            int min;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                min = i;
                for (int j = numbers.Length - 1; j > i; j--)
                {
                    if (numbers[j] < numbers[min])
                        min = j;
                }
                Swap(ref numbers[i], ref numbers[min]);
            }
            #endregion

            void Swap(ref int a, ref int b)
            {
                int c = a;
                a = b;
                b = c;
            }
        }

        static void PrintArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Write($"{numbers[i]} ");
            }
            WriteLine();
        }
    }
}
