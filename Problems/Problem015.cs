using System;
using System.Numerics;

namespace ProjectEuler.Problems
{
    public class Problem015
    {
        public Problem015(int n)
        {
            // using 2n!/n!²
            var nominator = Factorial(2 * n);
            var denominator = Factorial(n);
            denominator *= denominator;
            var numberOfLaticePaths = nominator / denominator;

            Console.WriteLine(numberOfLaticePaths);
        }

        private BigInteger Factorial(BigInteger n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}