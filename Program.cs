using System;
using ProjectEuler.Problems;

namespace ProjectEuler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var result = ProblemOne.SumOfMultiples(3, 1000, 3, 5);
            var result = ProblemTwo.SumOfEvenValuedFibonacciSequenceTerms(4000000);
            Console.WriteLine(result);
            Console.ReadKey(); // So the window doesn't close immidiately.
        }
    }
}
