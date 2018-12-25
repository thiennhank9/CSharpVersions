using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3QueryExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data source.
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            // Query Expression.
            IEnumerable<int> scoreQuery = //query variable
                from score in scores //required
                where score > 80 // optional
                orderby score descending // optional
                select score; //must end with select or group

            // Execute the query to produce the results
            foreach (int testScore in scoreQuery)
            {
                Console.WriteLine(testScore);
            }

            // Query by method syntax with delegate and anonymous method
            IEnumerable<int> scoreQuery2 = scores.Where(delegate (int score) { return score > 80; })
                .OrderByDescending(delegate (int score) { return score; });

            foreach (int testScore in scoreQuery2)
            {
                Console.WriteLine(testScore);
            }

            // Query by method syntax with lambda expression
            IEnumerable<int> scoreQuery3 = scores.Where(score => score > 80).OrderByDescending(score => score);

            foreach (int testScore in scoreQuery3)
            {
                Console.WriteLine(testScore);
            }
        }
    }
}
