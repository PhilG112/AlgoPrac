using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPrac.Algorithms.SelectionSort
{
    public static class SelectionSort
    {
        // V1 doesn't work, see V2
        public static int[] SelectionSortAlgorithmV1(int[] array)
        {
            var counter = 0;
            var isSorted = false;

            while (!isSorted)
            {
                isSorted = true;
                var smallestIndex = 0;
                for (var i = counter; i < array.Length; i++)
                {
                    isSorted = true;
                    for (var j = i + 1; j < array.Length; j++)
                    {
                        if (array[smallestIndex] > array[j])
                        {
                            smallestIndex = j;
                            isSorted = false;
                        }
                    }

                    if (isSorted) break;

                    var tmp = array[counter];
                    array[counter] = array[smallestIndex];
                    array[smallestIndex] = tmp;
                    counter++;
                }
            }

            return array;
        }

        // Working solution. O(n^2) time | O(1) space
        public static int[] SelectionSortAlgorithmV2(int[] array)
        {
            var currentIndex = 0;
            while (currentIndex < array.Length - 1)
            {
                var smallestIndex = currentIndex;
                for (var i = currentIndex + 1; i < array.Length; i++)
                {
                    if (array[smallestIndex] > array[i])
                    {
                        smallestIndex = i;
                    }
                }

                var tmp = array[currentIndex];
                array[currentIndex] = array[smallestIndex];
                array[smallestIndex] = tmp;
                currentIndex++;
            }

            return array;
        }
    }
}
