using System;

namespace ProjectEuler.Problems
{
    public class Problem018
    {
        private readonly int[,] _input = new[,]
        {
            {75, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00},
            {95, 64, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00},
            {17, 47, 82, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00},
            {18, 35, 87, 10, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00},
            {20, 04, 82, 47, 65, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00},
            {19, 01, 23, 75, 03, 34, 00, 00, 00, 00, 00, 00, 00, 00, 00},
            {88, 02, 77, 73, 07, 63, 67, 00, 00, 00, 00, 00, 00, 00, 00},
            {99, 65, 04, 28, 06, 16, 70, 92, 00, 00, 00, 00, 00, 00, 00},
            {41, 41, 26, 56, 83, 40, 80, 70, 33, 00, 00, 00, 00, 00, 00},
            {41, 48, 72, 33, 47, 32, 37, 16, 94, 29, 00, 00, 00, 00, 00},
            {53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14, 00, 00, 00, 00},
            {70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57, 00, 00, 00},
            {91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48, 00, 00},
            {63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31, 00},
            {04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23}
        };


        public Problem018()
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

            var maxSum = SolveAndReduceTriangle(_input);
            Console.WriteLine(maxSum);
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