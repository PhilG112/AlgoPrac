using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPrac.Algorithms.BubbleSort
{
    public static class BubbleSort
    {
        public static IList<int> BubbleSortAlgorithm(IList<int> a)
        {
            var sc = -1;
            while (sc != 0)
            {
                sc = 0;
                for (var i = 0; i < a.Count - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        var tmp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = tmp;
                        sc++;
                    }
                }
            }

            return a;
        }
    }
}
