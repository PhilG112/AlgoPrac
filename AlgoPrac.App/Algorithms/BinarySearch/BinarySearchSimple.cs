using System;

namespace AlgoPrac.Algorithms.BinarySearch
{
    public static class BinarySearchSimple
    {
        // Average: O(log(n)) time | space O(1) where n = size of array
        // THIS IS SUCEPTIBLE TO OVERFLOW START+END COULD OVERFLOW
        public static int BinarySearch(int[] a, int target)
        {
            var start = 0;
            var end = a.Length - 1;

            while (start <= end)
            {
                var midIndex = (start + end) / 2;
                var midValue = a[midIndex];

                if (midValue == target) return midIndex;

                if (target > midValue)
                {
                    start = midIndex + 1;
                }

                if (target < midValue)
                {
                    end = midIndex - 1;
                }
            }

            return -1;
        }

        // Average: O(log(n)) time | space O(log(n)) where n = size of array
        // THIS IS SUCEPTIBLE TO OVERFLOW 
        public static int BinarySearchRecursive(int[] a, int target)
        {
            return BinarySearchHelper(a, target, 0, a.Length - 1);

            static int BinarySearchHelper(int[] a, int target, int left, int right)
            {
                if (left > right) return -1;

                var midIndex = (left + right) / 2;
                var midValue = a[midIndex];

                if (target == midValue)
                {
                    return midIndex;
                }
                else if (target < midValue)
                {
                    return BinarySearchHelper(a, target, left, midIndex - 1);
                }
                else
                {
                    return BinarySearchHelper(a, target, midIndex + 1, right);
                }
            }
        }

        // Average: O(log(n)) time | space O(log(n)) where n = size of array
        public static int BinarySearchNonOverflow(int[] a, int target)
        {
            var left = 0;
            var right = a.Length - 1;

            while (left <= right)
            {
                var m = left + ((right - left) / 2);

                if (a[m] == target) return m;

                if (a[m] < target)
                {
                    left = m + 1;
                }
                else
                {
                    right = m - 1;
                }
            }

            return -1;
        }

        // Average: O(log(n)) time | space O(log(n)) where n = size of array
        public static int BinarySearchLowerBound(int[] a, int target)
        {
            // Condition: Find first value that is >= target
            var left = 0;
            var right = a.Length - 1;
            var answer = -1;

            while (left <= right)
            {
                var m = left + ((right - left) / 2);
                var val = a[m];

                if (val >= target)
                {
                    answer = m;
                    right = m - 1;
                }
                else
                {
                    left = m + 1;
                }
            }

            return answer;
        }
    }
}
