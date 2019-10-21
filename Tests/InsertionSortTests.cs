using System.Collections.Generic;
using System.Linq;
using AlgoPrac.Algorithms.InsertionSort;
using Xunit;

namespace AlgoPrac.Tests
{
    public class InsertionSortTets
    {
        [Fact]
        public void Test()
        {
            var testData = new List<int> { 8, 3, 1, 4, 7, 6, 5, 2 };
            var expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };


            var actual = InsertionSort.InsertionSortAlgorithm(testData);

            Assert.True(expected.SequenceEqual(actual));
        }
    }
}