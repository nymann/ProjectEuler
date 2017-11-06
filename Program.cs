using System;
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
            //new Problem001(3, 1000, 3, 5);
            //new Problem002(4000000);
            //new Problem003(600851475143);
            //new Problem004();
            //new Problem005(20);
            //new Problem006(100);
            //new Problem007(10001);
            //new Problem008(13);
            //new Problem009(1000);
            //new Problem010(2000000);
            //new Problem011(20, 4);
            //new Problem012(500);
            //new Problem013(50);
            //new Problem014(1000000);
            //new Problem015(20);
            //new Problem016(1000);
            //new Problem017(1, 1000);
            new Problem018();

            stopWatch.Stop();
            Console.WriteLine($"\nSolved in {stopWatch.ElapsedMilliseconds} msec.");
            Console.ReadKey(); // So the window doesn't close immidiately.
        }
    }
}
