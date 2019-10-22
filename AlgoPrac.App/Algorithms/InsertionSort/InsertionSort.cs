using System.Collections.Generic;

namespace AlgoPrac.App.Algorithms.InsertionSort
{
    public static class InsertionSort
    {
        public static IList<int> InsertionSortAlgorithm(IList<int> a)
        {
            for (var i = 1; i < a.Count; i++)
            {
                var key = a[i];
                var j = i - 1;

                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j = j - 1;
                }

                a[j + 1] = key;
            }

            return a;
        }
    }
}