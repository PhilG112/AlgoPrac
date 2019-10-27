namespace AlgoPrac.Algorithms.BinarySearch
{
    public static class BinarySearchSimple
    {
        public static int BinarySearch(int[] a, int target)
        {
            var start = 0;
            var end = a.Length - 1;

            while (start <= end)
            {
                var midIndex = (start + end) / 2;
                var midValue = a[midIndex];

                if (midValue == target) return midValue;

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
    }
}
