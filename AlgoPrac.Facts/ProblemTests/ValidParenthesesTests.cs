using AlgoPrac.Problems;
using Xunit;

namespace AlgoPrac.Facts.ProblemTests
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
