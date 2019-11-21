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
            var l = new MySinglyLinkedList<int>(new SinglyNode<int>(1));
            l.AddToEnd(new SinglyNode<int>(2));
            l.AddToEnd(new SinglyNode<int>(3));
            l.AddToEnd(new SinglyNode<int>(4));

            var ns = new List<SinglyNode<int>>
            {
                new SinglyNode<int>(5),
                new SinglyNode<int>(6),
                new SinglyNode<int>(7),
                new SinglyNode<int>(8),
                new SinglyNode<int>(9),
                new SinglyNode<int>(10)
            };

            l.AddMultipleToEnd(ns);

            Assert.Equal(1, l.Head.value);
            Assert.Equal(10, l.Last.value);
            Assert.Equal(10, l.Count);
        }
    }
}
