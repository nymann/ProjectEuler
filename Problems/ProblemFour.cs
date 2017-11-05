using System;

namespace ProjectEuler.Problems
{
    public class ProblemFour
    {
        /*
         * https://projecteuler.net/problem=4
         * Largest palindrome product
         * 
         * A palindromic number reads the same both ways.
         * The largest palindrome made from the product of two 2-digit numbers
         * is 9009 = 91 × 99.
         * 
         * Find the largest palindrome made from the product of two 3-digit numbers.
         */

        public ProblemFour()
        {
            // double for loop both from 100 to 999
            // multiply the two numbers, and check if palindrone.
            //

            var largestPalindroneNumber = 0;
            for (var i = 999; i >= 100; i--)
            {
                for (var j = 999; j >= 100; j--)
                {
                    var number = i * j;
                    if (number < largestPalindroneNumber)
                    {
                        break;
                    }

                    if (IsPalindrone(number))
                    {
                        largestPalindroneNumber = number;
                    }
                }
            }

            Console.WriteLine(largestPalindroneNumber);
        }

        private bool IsPalindrone(long number)
        {
            var numberAsString = Convert.ToString(number);
            var i = numberAsString.Length - 1;
            var j = 0;

            while (i >= j)
            {
                if (!numberAsString[i].Equals(numberAsString[j]))
                {
                    return false;
                }

                j++;
                i--;
            }

            return true;
        }
    }
}