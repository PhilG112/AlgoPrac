using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using AlgoPrac.App.Algorithms.InsertionSort;
using Xunit;

namespace AlgoPrac.Facts
{
    public class InsertionSortTets
    {
        [Fact]
        public void InsertionSortNormalTest()
        {
            var testData = new List<int> { 8, 9, 1, 4, 7, 6, 5, 2, 3 };
            var expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var actual = InsertionSort.InsertionSortAlgorithm(testData);

            Assert.True(expected.SequenceEqual(actual));
        }
    }
}