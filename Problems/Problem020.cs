using System;
using System.Numerics;

namespace ProjectEuler.Problems
{
    public class Problem020
    {
        public Problem020(int n)
        {
            var factorial = Factorial(n);
            var solution = Sum(factorial.ToString());
            Console.WriteLine(solution);
            
        }

        private BigInteger Factorial(BigInteger n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }

        private int Sum(string number)
        {
            var sum = 0;

            foreach (var n in number)
            {
                sum += Convert.ToInt32(n.ToString());
            }

            return sum;
        }
    }
}