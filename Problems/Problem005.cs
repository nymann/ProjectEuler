using System;

namespace ProjectEuler.Problems
{
    public class Problem005
    {
        /*
         * https://projecteuler.net/problem=5
         * Smallest multiple
         * 
         * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
         * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
         */

        public Problem005()
        {
            
        }

        public Problem005(int max)
        {
            var number = 2520;
            var m = max;
            while (true)
            {
                
                if (number % m == 0)
                {
                    m--;
                }
                else
                {
                    number++;
                    m = max;
                }

                if (m == 1)
                {
                    break;
                }
                
            }

            Console.WriteLine(number);
        }
    }
}