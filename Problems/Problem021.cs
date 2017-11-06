using System;

namespace ProjectEuler.Problems
{
    public class Problem021
    {
        public Problem021(int upper)
        {
            var sum = 0;
            for (int i = 1; i < upper; i++)
            {
                if (IsAmicable(i))
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }

        private long SumOfAllDivisorsOfNLessThanN(long number)
        {
            long sum = 0;
            for (var i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }

            }
            return sum;
        }

        private bool IsAmicable(long a)
        {
            var b = SumOfAllDivisorsOfNLessThanN(a);
            var temp = SumOfAllDivisorsOfNLessThanN(b);
            if (temp == a && a != b)
            {
                return true;
            }
            return false;
        }
    }
}