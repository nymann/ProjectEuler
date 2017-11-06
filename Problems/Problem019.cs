using System;

namespace ProjectEuler.Problems
{
    public class Problem019
    {
        /* Counting Sundays
         * https://projecteuler.net/problem=19
         *
         */

        public Problem019(int startYear, int endYear)
        {
            // TFW you find out you could've just said int ans = (12*100)/7. Smh.
            var sundays = 0;
            for (int year = startYear; year <= endYear; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    var dayOfTheWeek = new DateTime(year, month, 1).DayOfWeek;
                    if (dayOfTheWeek == DayOfWeek.Sunday)
                    {
                        sundays++;
                    }
                }
            }
            
            Console.WriteLine(sundays);
        }

    }
}