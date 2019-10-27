using AlgoPrac.Algorithms.BinarySearch;
using System.Diagnostics;
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

            var sw = new Stopwatch(); sw.Start();
            var actual = BinarySearchSimple.BinarySearch(given, target);
            sw.Stop();
            var e = sw.Elapsed;
            Assert.Equal(target, actual);
        }
    }
}
