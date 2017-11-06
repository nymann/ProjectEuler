using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem022
    {
        readonly Dictionary<char, int> _alphabet = new Dictionary<char, int>()
        {
            {'a', 1},
            {'b', 2},
            {'c', 3},
            {'d', 4},
            {'e', 5},
            {'f', 6},
            {'g', 7},
            {'h', 8},
            {'i', 9},
            {'j', 10},
            {'k', 11},
            {'l', 12},
            {'m', 13},
            {'n', 14},
            {'o', 15},
            {'p', 16},
            {'q', 17},
            {'r', 18},
            {'s', 19},
            {'t', 20},
            {'u', 21},
            {'v', 22},
            {'w', 23},
            {'x', 24},
            {'y', 25},
            {'z', 26}
        };

        public Problem022()
        {
            var names = ReadFile("C://p022_names.txt");
            var line = 1;
            long score = 0;
            foreach (var name in names)
            {
                score += AlphabeticScore(name) * line;
                line++;
            }

            Console.WriteLine(score);
        }

        private List<string> ReadFile(string path)
        {
            var s = File.ReadAllText(path);
            s = s.Replace("\"", "");
            s = s.ToLower();
            var r = s.Split(',').ToList();
            r.Sort();
            return r;
        }

        private int AlphabeticScore(string name)
        {
            return name.Sum(c => _alphabet[c]);
        }
    }
}