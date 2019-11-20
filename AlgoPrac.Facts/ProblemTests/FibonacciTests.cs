using AlgoPrac.Problems;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xunit;

namespace AlgoPrac.Facts.ProblemTests
{
    public class FibonacciTests
    {
        [Fact]
        public void FibonacciTestV1()
        {
            var result = Fibonacci.GetNthFibonacciV1(90);

            Assert.Equal(2880067194370816120, result);
        }

        [Fact]
        public void FibonacciTestV2()
        {
            var result = Fibonacci.GetNthFibonacciV2(1);

            Assert.Equal(2880067194370816120, result);
        }

        [Fact]
        public void FibonacciRecursiveV1Test()
        {
            var result = Fibonacci.GetNthFibonacciRecursiveV1(18);
        }

        [Fact]
        public void FibonacciRecursiveV2Test()
        {
            var result = Fibonacci.GetNthFibonacciRecursiveV2(18);
        }
    }
}
