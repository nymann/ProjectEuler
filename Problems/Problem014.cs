using System;

namespace ProjectEuler.Problems
{
    public class Problem014
    {
        public Problem014(int max)
        {
            long number = 0;
            long highScore = 0;
            for (long i = max/2; i < max; i++)
            {
                var terms = CollatzSequenceNumberOfTerms(i);
                if (terms > highScore)
                {
                    highScore = terms;
                    number = i;
                }
            }

            Console.WriteLine($"{number} with {highScore} terms.");
        }

        private int CollatzSequenceNumberOfTerms(long n)
        {
            int terms = 0;
            while (n != 1)
            {
                terms++;
                if (n % 2 == 0)
                {
                    // n is even.
                    n = n / 2;
                }
                else
                {
                    // n is odd.
                    n = 3 * n + 1;
                }
                
            }

            return terms;
        }
    }
}