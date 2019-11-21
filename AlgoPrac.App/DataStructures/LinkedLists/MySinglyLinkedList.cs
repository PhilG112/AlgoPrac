using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlgoPrac.DataStructures.LinkedLists
{
    public class MySinglyLinkedList<T>
    {
        public SinglyNode<T> Head;

        public SinglyNode<T> Last;

        public int Count { get; private set; }

        public MySinglyLinkedList(SinglyNode<T> head)
        {
            Head = head;
            Count++;
        }

        public void AddToEnd(SinglyNode<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            if (Last == null)
            {
                Head.next = node;
                Last = node;
                Count++;
                return;
            }

            Last.next = node;
            Last = node;
            Count++;
        }

        public void AddMultipleToEnd(IList<SinglyNode<T>> nodes)
        {
            if (nodes == null)
            {
                throw new ArgumentException(nameof(nodes));
            }

            foreach (var node in nodes)
            {
                Last.next = node;
                Last = node;
                Count++;
            }
        }
    }
}
