using AlgoPrac.Problems;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AlgoPrac.Facts.ProblemTests
{
    public class LongestCommonPrefixTests
    {
        [Fact]
        public void LongestCommonPrefixTest()
        {
            var data = new List<string> { "flower", "flow", "flight" };
            var expected = "fl";

            var actual = LongestCommonPrefix.LongestCommonPrefixSolution(data.ToArray());

            Assert.Equal(expected, actual);
        }
    }
}
