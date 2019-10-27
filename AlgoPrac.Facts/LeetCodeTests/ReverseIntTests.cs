using AlgoPrac.LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgoPrac.Facts.LeetCodeTests
{
    public class ReverseIntTests
    {
        [Fact]
        public void ReverseIntTest()
        {
            var given = 100;
            var expected = 1;

            var actual = ReverseInt.ReverseIntSolution(given);

            Assert.Equal(expected, actual);
        }
    }
}
