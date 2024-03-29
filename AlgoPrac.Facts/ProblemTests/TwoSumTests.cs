using System.Collections.Generic;
using AlgoPrac.Algorithms.Problems;
using Xunit;

namespace AlgoPrac.Facts.ProblemTests
{
    public class TwoSumTests
    {
        [Fact]
        public void TwoSumTest()
        {
            var given = new List<int> { 3, 2, 4 };
            var target = 6;
            var expectedIndex1 = 1;
            var expectedIndex2 = 2;

            var actual = TwoSum.TwoSumSolution(given, target);

            Assert.Equal(expectedIndex1, actual[0]);
            Assert.Equal(expectedIndex2, actual[1]);
        }
    }
}