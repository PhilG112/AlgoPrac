using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPrac.LeetCode
{
    public static class RomanToInt
    {
        private static IDictionary<string, int> _map = new Dictionary<string, int>
        {
            { "I", 1 },
            { "IV", 4 },
            { "V", 5 },
            { "IX", 9 },
            { "X", 10 },
            { "XL", 40 },
            { "L", 50 },
            { "XC", 90 },
            { "C", 100 },
            { "CD", 400 },
            { "D", 500 },
            { "CM", 900 },
            { "M", 1000 }
        };

        public static int RomanToIntSolution(string s)
        {
            var total = 0;

            for (var i = 0; i < s.Length; i++)
            {
                var first = s[i];

                if (i == s.Length - 1)
                {
                    total += _map[first.ToString()];
                    break;
                }

                var second = s[i + 1];
                var k = $"{first}{second}";
                if (_map.ContainsKey(k))
                {
                    total += _map[k];
                    i++;
                }
                else
                {
                    total += _map[first.ToString()];
                }
            }

            return total;
        }
    }
}
