using AlgoPrac.Algorithms.SelectionSort;
using System;
using System.Linq;
using Xunit;

namespace AlgoPrac.Facts
{
    public class SelectionSortTests
    {
        [Fact]
        public void SelectionSortV1Test()
        {
            var data = new int[] { 3, 1, 2 };
            var expected = new int[] { 1, 2, 3 }.ToList();

            var actual = SelectionSort.SelectionSortAlgorithmV1(data);

            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void SelectionSortV2Test()
        {
            var data = new int[] { 3, 1, 2 };
            var expected = new int[] { 1, 2, 3 }.ToList();

            var actual = SelectionSort.SelectionSortAlgorithmV2(data);

            Assert.True(expected.SequenceEqual(actual));
        }
    }
}
