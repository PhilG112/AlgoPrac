using AlgoPrac.LeetCode;
using Xunit;

namespace AlgoPrac.Facts.LeetCodeTests
{
    public class RomanToIntTests
    {
        [Fact]
        public void RomanToIntTest()
        {
            var given = "MCMXCIVI";
            var expected = 1995;

            var actual = RomanToInt.RomanToIntSolution(given);
            Assert.Equal(expected, actual);
        }
    }
}
