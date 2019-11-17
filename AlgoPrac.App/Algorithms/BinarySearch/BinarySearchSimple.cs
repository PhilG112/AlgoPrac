using System;

namespace AlgoPrac.Algorithms.BinarySearch
{
    public static class BinarySearchSimple
    {
        // Average: O(log(n)) time | space O(1) where n = size of array
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

       
    }
}
