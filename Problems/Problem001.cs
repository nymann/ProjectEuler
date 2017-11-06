using System;

namespace ProjectEuler.Problems
{
    public class Problem001
    {
        /*
         * https://projecteuler.net/problem=1
         * Multiples of 3 and 5
         * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
         * Find the sum of all the multiples of 3 or 5 below 1000.
         */
        public Problem001(int min, int max, int a, int b)
        {
            var sum = SumOfMultiples(min, max, a, b);
            Console.WriteLine(sum);
        }


        /// <summary>
        /// Returns the sum of multiples of a or b, within the given range (min, max) 
        /// </summary>
        /// <param name="min">minimum</param>
        /// <param name="max">maximum</param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int SumOfMultiples(int min, int max, int a, int b)
        {
            var sum = 0;

            for (var i = min; i < max; i++)
            {
                if (i % a == 0 || i % b == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}