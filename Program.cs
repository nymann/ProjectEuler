﻿using System;
using System.Diagnostics;
using ProjectEuler.Problems;

namespace ProjectEuler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            //var result = ProblemOne.SumOfMultiples(3, 1000, 3, 5);
            //var result = ProblemTwo.SumOfEvenValuedFibonacciSequenceTerms(4000000);
            //new ProblemThree(600851475143);
            //new ProblemFour();
            //new ProblemFive(20);
            //new ProblemSix(100);
            //new ProblemSeven(10001);
            new ProblemEight(13);

            stopWatch.Stop();
            Console.WriteLine($"\nSolved in {stopWatch.ElapsedMilliseconds} msec.");
            Console.ReadKey(); // So the window doesn't close immidiately.
        }
    }
}
