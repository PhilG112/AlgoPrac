using AlgoPrac.Algorithms.BinarySearch;
using System.Linq;
using Xunit;

namespace AlgoPrac.Facts.Algorithms
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

        [Fact]
        public void BinarySearchNonOverFlowTest()
        {
            var given = Enumerable.Range(0, 10).ToArray();
            var target = 3;
            var expected = given.ToList().IndexOf(target);

            var actual = BinarySearchSimple.BinarySearchNonOverflow(given, target);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BinarySearchLowerBoundTest()
        {
            var given = new int[] { 2, 3, 5, 6, 8, 10, 12 };
            var target = 4;
            var expected = 5;

            var actual = BinarySearchSimple.BinarySearchLowerBound(given, target);
            Assert.Equal(expected, actual);
        }
    }
}
