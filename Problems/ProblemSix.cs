using System;

namespace ProjectEuler.Problems
{
    public class ProblemSix
    {
        /*
         * https://projecteuler.net/problem=6
         * Sum square difference
         * 
         * The sum of the squares of the first ten natural numbers is,
         * 1² + 2² + ... + 10² = 385
         * The square of the sum of the first ten natural numbers is,
         * (1 + 2 + ... + 10)² = 55² = 3025
         * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
         * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
         */

        public ProblemSix(int max)
        {
            double sumOfNumbers = 0;
            double sumOfSquaredNumbers = 0;

            for (double i = 1; i <= max; i++)
            {
                sumOfNumbers += Math.Pow(i, 2);
                sumOfSquaredNumbers += i;
            }

            sumOfSquaredNumbers = Math.Pow(sumOfSquaredNumbers, 2);
            double difference = sumOfSquaredNumbers - sumOfNumbers;
            Console.WriteLine(difference);
        }
    }
}