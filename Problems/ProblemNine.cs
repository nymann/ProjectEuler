using System;

namespace ProjectEuler.Problems
{
    public class ProblemNine
    {
        /*
         * https://projecteuler.net/problem=9
         * 
         * Special Pythagorean triplet
         * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
         * a² + b² = c²
         * 
         * For example, 3² + 4² = 9 + 16 = 25 = 5².
         * 
         * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
         * Find the product abc.
         */

        public ProblemNine(int sumOfTriplet)
        {
            for (var a = 1; a < sumOfTriplet/3; a++)
            {
                for (var b = a + 1; b < sumOfTriplet/2; b++)
                {
                    var c = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(a, 2));
                    if (c <= a || a >= b || c == b)
                    {
                        break;
                    }

                    if (b + a + c == sumOfTriplet)
                    {
                        Console.WriteLine($"a: {a}, b: {b}, c: {c}.");
                        Console.WriteLine(b * a * c);
                    }
                }
            }

        }
    }
}