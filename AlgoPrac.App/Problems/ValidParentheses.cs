using System.Collections.Generic;
using System.Linq;

namespace AlgoPrac.Problems
{
    public static class ValidParentheses
    {
        public static bool ValidParenthesesSolution(string s)
        {
            var map = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            var stack = new Stack<char>();

            for (var i = 0; i < s.Length; i++)
            {
                var current = s[i];
                if (map.ContainsKey(current))
                {
                    stack.Push(current);
                    continue;
                }

                var peek = stack.Count > 0 ? stack.Peek() : '#';
                var key = map.First(x => x.Value == current).Key;
                if (key == peek)
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
