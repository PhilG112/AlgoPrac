using AlgoPrac.DataStructures.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace AlgoPrac.Facts.DataStructureTests
{
    public class LinkedListsTests
    {
        [Fact]
        public void LinkedListsTest()
        {
            var l = new MyLinkedList<int>(new Node<int>(1));
            l.AddToEnd(new Node<int>(2));
            l.AddToEnd(new Node<int>(3));
            l.AddToEnd(new Node<int>(4));

            var ns = new List<Node<int>>
            {
                new Node<int>(5),
                new Node<int>(6),
                new Node<int>(7),
                new Node<int>(8),
                new Node<int>(9),
                new Node<int>(10)
            };

            l.AddMultipleToEnd(ns);

            Assert.Equal(1, l.Head.value);
            Assert.Equal(10, l.Last.value);
            Assert.Equal(10, l.Count);
        }
    }
}
