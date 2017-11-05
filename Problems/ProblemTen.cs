using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class ProblemTen
    {
        public ProblemTen(int number)
        {
            long sum = 0;
            for (int i = 0; i < number; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
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