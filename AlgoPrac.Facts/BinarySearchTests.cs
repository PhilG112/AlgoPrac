using AlgoPrac.Algorithms.BinarySearch;
using System.Linq;
using Xunit;

namespace AlgoPrac.Facts
{
    public class BinarySearchTests
    {
        [Fact]
        public void BinarySearchTest()
        {
            var given = Enumerable.Range(0, 100000000).ToArray();
            var target = 23474777;
            var expected = given.ToList().IndexOf(target);

            var actual = BinarySearchSimple.BinarySearch(given, target);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BinarySearchRecursiveTest()
        {
            var given = Enumerable.Range(0, 10).ToArray();
            var target = 3;
            var expected = given.ToList().IndexOf(target);

            var actual = BinarySearchSimple.BinarySearchRecursive(given, target);
            Assert.Equal(expected, actual);
        }
    }
}
