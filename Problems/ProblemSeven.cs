using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class ProblemSeven
    {
        private readonly List<int> _primes = new List<int>();

        public ProblemSeven(int nthPrime)
        {
            var n = 2;
            while (_primes.Count < nthPrime)
            {
                if (IsPrime(n))
                {
                    _primes.Add(n);
                }
                n++;
            }

            Console.WriteLine(_primes.Last());
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
    }
}