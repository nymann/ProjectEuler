using System;
using System.Linq;
using System.Numerics;

namespace ProjectEuler.Problems
{
    public class Problem016
    {
        /*
         * Power digit sum
         * https://projecteuler.net/problem=16
         */

        public Problem016(int power)
        {
            var number = BigInteger.Pow(2, power);
            var sum = Sum(number.ToString());
            Console.WriteLine($"2^({power}) is: {number}.\n" +
                              $"And the sum is: {sum}.");
        }

        private int Sum(string numbers)
        {
            var sum = 0;

            foreach (var number in numbers)
            {
                sum += Convert.ToInt32(number.ToString());
            }

            return sum;
        }
    }
}