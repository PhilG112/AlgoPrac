using System.Collections.Generic;

namespace AlgoPrac.App.Algorithms.InsertionSort
{
    public static class InsertionSort
    {
        public static IList<int> InsertionSortAlgorithm(IList<int> array)
        {
            for (var i = 1; i < array.Count; i++)
            {
                // Get the current element from the array to compare
                var key = array[i];

                // Set j to one behind index i to compare
                var j = i - 1;

                while(
                    // Check if j is greater than or equal to 0
                    j >= 0 &&
                    // Check if element at index j is greater than the key at index i
                    array[j] > key)
                {
                    // Set array element at index j + 1 to be the higher element
                    // E.g if array[j + 1] is 3 and array[j] is 8, we set array[j + 1] to be 8
                    // Which will look like this [ 8, 8 ]
                    array[j + 1] = array[j];

                    // Set j to be the previous element index
                    j = j - 1;
                }

                // Increment index j by one and set it to the key which is the lower element
                // Which will look like this [ 3, 8 ]
                array[j + 1] = key;
            }

            return array;
        }
    }
}