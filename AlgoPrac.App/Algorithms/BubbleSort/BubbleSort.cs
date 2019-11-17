using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPrac.Algorithms.BubbleSort
{
    public static class BubbleSort
    {
        // Average O(n^2) time | O(1) space
        public static IList<int> BubbleSortAlgorithm(IList<int> a)
        {
            var isSorted = false;
            var counter = 0;
            while (!isSorted)
            {
                isSorted = true;
                for (var i = 0; i < a.Count - 1 - counter; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        var tmp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = tmp;
                        isSorted = false;
                    }
                    counter++;
                }
            }

            return a;
        }
    }
}
