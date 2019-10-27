using AlgoPrac.Algorithms.BubbleSort;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xunit;

namespace AlgoPrac.Facts
{
    public class BubbleSortTests
    {
        [Fact]
        public void BubbleSortTest()
        {
            var given = new List<int> { 5, 4, 3, 2, 1 };
            var expected = new List<int> { 1, 2, 3, 4, 5 };

            var sw = new Stopwatch(); sw.Start();
            var actual = BubbleSort.BubbleSortAlgorithm(given);
            sw.Stop();
            var e = sw.Elapsed;

            Assert.True(expected.SequenceEqual(actual));
        }
    }
}
