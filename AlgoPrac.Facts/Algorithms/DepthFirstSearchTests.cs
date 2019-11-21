using AlgoPrac.Algorithms.DepthFirstSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace AlgoPrac.Facts.Algorithms
{
    public class DepthFirstSearchTests
    {
        [Fact]
        public void DFSTest2()
        {
            var test3 = new DFS("A");
            test3.AddChild("B");
            test3.children[0].AddChild("C");
            test3.children[0].children[0].AddChild("D").AddChild("E");
            test3.children[0].children[0].children[0].AddChild("F");

            string[] expected = { "A", "B", "C", "D", "F", "E" };
            var inputArray = new List<string>();

            var actual = test3.DepthFirstSearchV2(inputArray);

            Assert.True(expected.SequenceEqual(actual));
        }
    }
}
