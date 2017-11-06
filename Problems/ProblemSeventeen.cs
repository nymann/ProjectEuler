using System;

namespace ProjectEuler.Problems
{
    public class ProblemSeventeen
    {
        public ProblemSeventeen(int min, int max)
        {
            long sum = 0;

            for (var i = min; i <= max; i++)
            {
                var words = NumberToWords(i);
                sum += LetterCounter(words);
                
            }

            Console.WriteLine(sum);
        }

        private static string NumberToWords(int number)
        {
            if (number < 0)
            {
                return $"minus {NumberToWords(number * -1)}";
            }

            if (number == 0)
            {
                return "zero";
            }

            var words = "";

            if (number >= 1000000)
            {
                words += $"{NumberToWords(number / 1000000)} million";
                number %= 1000000;
            }

            if (number >= 1000)
            {
                words += $"{NumberToWords(number / 1000)} thousand";
                number %= 1000;
            }

            if (number >= 100)
            {
                words += $"{NumberToWords(number / 100)} hundred";
                number %= 100;
            }

            if (number <= 0)
            {
                return words;
            }

            if (!words.Equals(""))
            {
                words += "and";
            }

            var tens = new[] { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            if (number >= 20)
            {
                words += $"{tens[number/10]}";
                number %= 10;
            }

            var numbersUnderTwenty = new[]
            {
                "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
                "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
            };

            if (number > 0)
            {
                words += numbersUnderTwenty[number];
            }

            return words;
        }

        private static int LetterCounter(string words)
        {
            return words.Replace(" ", "").Length;
        }
    }
}