﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class ProblemEleven
    {
        private readonly int[] _input =
        {
            -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
            -1, 08, 02, 22, 97, 38, 15, 00, 40, 00, 75, 04, 05, 07, 78, 52, 12, 50, 77, 91, 08, -1,
            -1, 49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 04, 56, 62, 00, -1,
            -1, 81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 03, 49, 13, 36, 65, -1,
            -1, 52, 70, 95, 23, 04, 60, 11, 42, 69, 24, 68, 56, 01, 32, 56, 71, 37, 02, 36, 91, -1,
            -1, 22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80, -1,
            -1, 24, 47, 32, 60, 99, 03, 45, 02, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50, -1,
            -1, 32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70, -1,
            -1, 67, 26, 20, 68, 02, 62, 12, 20, 95, 63, 94, 39, 63, 08, 40, 91, 66, 49, 94, 21, -1,
            -1, 24, 55, 58, 05, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72, -1,
            -1, 21, 36, 23, 09, 75, 00, 76, 44, 20, 45, 35, 14, 00, 61, 33, 97, 34, 31, 33, 95, -1,
            -1, 78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 03, 80, 04, 62, 16, 14, 09, 53, 56, 92, -1,
            -1, 16, 39, 05, 42, 96, 35, 31, 47, 55, 58, 88, 24, 00, 17, 54, 24, 36, 29, 85, 57, -1,
            -1, 86, 56, 00, 48, 35, 71, 89, 07, 05, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58, -1,
            -1, 19, 80, 81, 68, 05, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 04, 89, 55, 40, -1,
            -1, 04, 52, 08, 83, 97, 35, 99, 16, 07, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66, -1,
            -1, 88, 36, 68, 87, 57, 62, 20, 72, 03, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69, -1,
            -1, 04, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 08, 46, 29, 32, 40, 62, 76, 36, -1,
            -1, 20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 04, 36, 16, -1,
            -1, 20, 73, 35, 29, 78, 31, 90, 01, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 05, 54, -1,
            -1, 01, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 01, 89, 19, 67, 48, -1,
            -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sideLengthOfGrid">Fx. 20x20 grid, then sideLenghtOfGrid would be 20</param>
        /// <param name="amountOfAdjacentNumbers"></param>
        public ProblemEleven(int sideLengthOfGrid, int amountOfAdjacentNumbers)
        {
            var max = TraverseGrid(sideLengthOfGrid, amountOfAdjacentNumbers);
            Console.WriteLine(max);
            //Console.WriteLine(_input[46]);
        }

        private int TraverseGrid(int sideLengthOfGrid, int amountOfAdjacentNumbers)
        {
            var currentHighest = 0;  

            for (var i = 24; i < _input.Length; i += amountOfAdjacentNumbers)
            {
                var listOfProducts = new List<int> { 1, 1, 1, 1 };
                for (var j = 0; j < amountOfAdjacentNumbers; j++)
                {
                    // Horizontally.
                    listOfProducts[0] *= ReturnIndex(i + j);

                    // Vertically.
                    listOfProducts[1] *= ReturnIndex(i + j * (sideLengthOfGrid + 2));

                    // Diagonally left to right.
                    listOfProducts[2] *= ReturnIndex(i + j * (sideLengthOfGrid + 3));

                    // Diagonally right to left.
                    listOfProducts[3] *= ReturnIndex(i - j * (sideLengthOfGrid + 1));
                }

                currentHighest = ReturnHighest(listOfProducts, currentHighest);

            }

            return currentHighest;
        }

        private int ReturnIndex(int index)
        {
            if (index >= _input.Length || index < 0)
            {
                return -1;
            }

            if (_input[index] == -1)
            {
                return -1;
            }

            return _input[index];
        }

        private static int ReturnHighest(IEnumerable<int> products, int currentHighest)
        {
            var temp = products.Max();
            return temp > currentHighest ? temp : currentHighest;
        }
    }
}