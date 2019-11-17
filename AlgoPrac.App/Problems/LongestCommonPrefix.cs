using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPrac.Problems
{
    public static class LongestCommonPrefix
    {
        public static string LongestCommonPrefixSolution(string[] strs)
        {
            if (strs.Length == 0) return string.Empty;

            var prefix = strs[0];
            for (var i = 0; i < strs.Length; i++)
            {
                var current = strs[i];
                var index = current.IndexOf(prefix);
                while (current.IndexOf(prefix) != 0)
                {
                    var k = prefix.Substring(0, prefix.Length - 1);
                    prefix = k;
                    if (prefix.Length == 0) return string.Empty;
                }
            }

            return prefix;
        }
    }
}
