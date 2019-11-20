using System.Collections.Generic;

namespace AlgoPrac.Problems
{
    public static class Fibonacci
    {
        // Average: O(n) time | O(1) space
        // Breaks at super high numbers
        public static long GetNthFibonacciV1(long n)
        {
            if (n == 1) return 0;
            if (n == 2) return 1;

            var a = 0;
            var b = 1;
            var result = 0;

            for (var i = 2; i <= n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }

            return result;
        }

        // Average: O(n) time | O(1) space
        public static long GetNthFibonacciV2(long n)
        {
            var a = new long[] { 0, 1 };
            var c = 3;
            while (c <= n)
            {
                var next = a[0] + a[1];
                a[0] = a[1];
                a[1] = next;
                c++;
            }

            return n > 1 ? a[1] : a[0];
        }

        // Average: O(n) time | O(1) space
        // This doesn't work but you get the idea, memoize
        private static IDictionary<int, int> mem = new Dictionary<int, int> { { 1, 0 }, { 2, 1 } };
        public static int GetNthFibonacciRecursiveV1(int n)
        {
            if (mem.ContainsKey(n))
            {
                return mem[n];
            }
            else
            {
                mem[n] = GetNthFibonacciRecursiveV1(n - 1) + GetNthFibonacciRecursiveV1(n - 2);
                return mem[n];
            }
        }

        // Average: O(2^n) time | O(n) space
        public static long GetNthFibonacciRecursiveV2(long n)
        {
            if (n == 2) return 1;
            if (n == 1) return 0;

            return GetNthFibonacciRecursiveV2(n - 1) + GetNthFibonacciRecursiveV2(n - 2);
        }
    }
}
