using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace ProjectEuler.Problems
{
    public class ProblemTwelve
    {
        public ProblemTwelve(int numberOfDivisors)
        {
            for (long i = 1; i <= 99999999999; i++)
            {
                var triangularNumber = i * (i + 1) / 2;
                if (FactorizeNumber(triangularNumber, numberOfDivisors))
                {
                    Console.WriteLine(
                        $"{triangularNumber} is the first triangle number to have over {numberOfDivisors} divisors.");
                    //PrintFactors(triangularNumber);
                    break;
                }
            }
        }

        private bool FactorizeNumber(long number, int divisors)
        {
            long temp = 0;
            for (var i = 1; i*i <= number; i++)
            {
                if (number % i == 0)
                {
                    temp++;
                    if (i != number/i)
                    {
                        temp++;
                    }
                }

            }

            return divisors < temp;
        }

        /*private static void PrintFactors(long number)
        {
            for (var i = 1; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write($"{i} ");
                    if (i != number / i)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
        }*/
    }
}