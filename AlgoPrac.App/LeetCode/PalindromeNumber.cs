using System;
using System.Linq;

namespace AlgoPrac.LeetCode
{
    public static class PalindromeNumber
    {
        public static bool IsPalindromeNumber(int x)
        {
            if (x < 0) return false;

            var str = string.Join("", x.ToString().Reverse());
            return str == x.ToString() ? true : false;
        }
    }
}
