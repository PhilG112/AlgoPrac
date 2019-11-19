using AlgoPrac.Problems;
using Xunit;

namespace AlgoPrac.Facts.ProblemTests
{
    public class IsPalindromeTests
    {
        [Fact]
        public void IsPalindromeV1Tests()
        {
            var result = PalindromeString.IsPalindrome("racecar");
            Assert.True(result);
        }

        [Fact]
        public void IsPalindromeV2Tests()
        {
            var result = PalindromeString.IsPalindromeV2("racecar");
            Assert.True(result);
        }

        [Fact]
        public void IsPalindromeRecursiveTests()
        {
            var data = "racecar";
            var result = PalindromeString.IsPalindromeRecursive(data);
            Assert.True(result);
        }
    }
}
