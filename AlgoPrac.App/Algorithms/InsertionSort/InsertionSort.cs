using System.Collections.Generic;

namespace AlgoPrac.App.Algorithms.InsertionSort
{
    public static class InsertionSort
    {
        public static IList<int> InsertionSortAlgorithm(IList<int> a)
        {
            for (var j = 2; j < a.Count; j++)
            {
                var key = a[j];
                var i = j -1;

                while(i > 0 && a[i] > key)
                {
                    a[i + 1] = a[i];
                    i = i - 1;
                }

                a[i + 1] = key;
            }

            return a;
        }
    }
}