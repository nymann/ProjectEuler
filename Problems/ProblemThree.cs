using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class ProblemThree
    {
        /*
         * https://projecteuler.net/problem=3
         * Largest prime factor
         * The prime factors of 13195 are 5, 7, 13 and 29.
         * What is the largest prime factor of the number 600851475143 ?
         */

        private const int NUMBER_OF_PRIMES_TO_CALCULATE = 10000;
        private readonly List<int> _primes = new List<int>();

        public ProblemThree(long number)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            for (var i = 0; i < NUMBER_OF_PRIMES_TO_CALCULATE; i++)
            {
                if (IsPrime(i))
                {
                    _primes.Add(i);
                }
            }
            Console.WriteLine(
                $"There are {_primes.Count} between 0 and {NUMBER_OF_PRIMES_TO_CALCULATE} (Computed in {stopWatch.ElapsedMilliseconds} msec.)\n");

            var factors = PrimeFactorizeNumber(number);
            Console.WriteLine($"The largest prime factor of the number {number}, is {ReturnLargestNumber(factors)}!");
        }

        public ProblemThree()
        {
        }

        private static bool IsPrime(long number)
        {
            if (number <= 1)
            {
                return false;
            }

            if (number <= 3)
            {
                return true;
            }

            if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }

            for (var i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private List<int> PrimeFactorizeNumber(long n)
        {
            var factors = new List<int>();
            var number = n;

            for (var i = 0; i < _primes.Count; i++)
            {
                if (number % _primes[i] == 0)
                {
                    factors.Add(_primes[i]);
                    number = number / _primes[i];
                    i = 0;
                }

                if (number == 1)
                {
                    break;
                }
            }
            

            return factors;
        }

        private int ReturnLargestNumber(List<int> numbers)
        {
            return numbers.Max();
        }
    }
}