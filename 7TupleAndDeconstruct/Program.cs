using static System.Console;

namespace _7TupleAndDeconstruct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 4, 3, 2, 1, 0 };

            // Out sample
            int min = OutSample.FindMinMax(array, out int max);
            WriteLine($"Out sample\nmin: {min}, max: {max}\n");

            // Class sample
            ClassSample classSample = ClassSample.FindMinMax(array);
            WriteLine($"Class sample\nmin: {classSample.Min}, max: {classSample.Max}\n");

            // Old tuple type sample
            var oldTuple = OldTupleSample.FindMinMax(array);
            WriteLine($"Old tuple type sample\nmin: {oldTuple.Item1}, max: {oldTuple.Item2}\n");

            // New tuple type sample
            var newTuple = NewTupleSample.FindMinMax(array);
            WriteLine($"New tuple type sample\nmin: {newTuple.min}, max: {newTuple.max}\n");

            // Deconstruct class sample
            var (val1, val2) = classSample;
            WriteLine($"Deconstruct class sample\nval1: {val1}, val2: {val2}\n");

            // Deconstruct tuple sample
            var (val3, val4) = newTuple;
            WriteLine($"Deconstruct tuple sample\nval3: {val3}, val4: {val4}\n");
        }
    }
}
