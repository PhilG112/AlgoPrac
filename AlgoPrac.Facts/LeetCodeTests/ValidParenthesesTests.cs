using AlgoPrac.LeetCode;
using Xunit;

namespace AlgoPrac.Facts.LeetCodeTests
{
    public class ValidParenthesesTests
    {
        [Fact]
        public void ValidParenthesesTest()
        {
            var data = "((";
            var expected = true;

            var actual = ValidParentheses.ValidParenthesesSolution(data);

            Assert.Equal(expected, actual);
        }
    }
}
