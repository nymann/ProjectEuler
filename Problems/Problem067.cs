using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem067
    {
        public Problem067()
        {
            /* Idea: Dynamic Programming
             * Fx, the following tree:
             *     1
             *    2 3
             *   4 5 6
             *  7 8 9 10
             *  
             *  Becomes:
             *      01
             *    2    3
             * 12   14   16
             *  
             *  
             *  Becomes:
             *     1
             *   26 29
             *  
             *  Becomes:
             *     30
             */

            var input = ReadFile("C://p067_triangle.txt");
            var triangle = FromStringListToIntArray(input);

            var maxSum = SolveAndReduceTriangle(triangle);
            Console.WriteLine(maxSum);
        }

        private List<string> ReadFile(string path)
        {
            return File.ReadLines(path).ToList();
        }


        private int[,] FromStringListToIntArray(List<string> input)
        {
            var length = input.Count;
            var triangle = new int[length, length];
            for (var i = 0; i < input.Count; i++)
            {
                var line = input[i];
                var arr = line.Split(' ').ToList();

                for (var j = 0; j < arr.Count; j++)
                {
                    var s = arr[j];
                    triangle[i, j] = Convert.ToInt32(s);
                }
            }

            return triangle;
        }

        private static int SolveAndReduceTriangle(int[,] triangle)
        {
            var cols = triangle.GetLength(0);
            var rows = triangle.GetLength(1);

            var newTriangle = new int[cols - 1, rows - 1];

            // Fill the new triangle with the old ones values apart from last row.
            for (var i = 0; i < cols - 1; i++)
            {
                for (var j = 0; j < rows - 1; j++)
                {
                    newTriangle[i, j] = triangle[i, j];
                }
            }

            // Look through last row, and calculate the sums.
            for (var n = 0; n < rows - 1; n++)
            {
                // Look at the n and n+1
                var a = triangle[cols - 1, n];
                var b = triangle[cols - 1, n + 1];

                // Add the largest number to the above number.
                if (a > b)
                {
                    newTriangle[cols - 2, n] += a;
                }
                else
                {
                    newTriangle[cols - 2, n] += b;
                }
            }

            var l = newTriangle.GetLength(0);

            if (l > 1)
            {
                return SolveAndReduceTriangle(newTriangle);
            }

            return newTriangle[0, 0];
        }
    }
}