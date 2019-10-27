using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlgoPrac.DataStructures.LinkedLists
{
    public class MyLinkedList<T>
    {
        public Node<T> Head;

        public Node<T> Last;

        public int Count { get; private set; }

        public MyLinkedList(Node<T> head)
        {
            Head = head;
            Count++;
        }

        public void AddToEnd(Node<T> node)
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

        public void AddMultipleToEnd(IList<Node<T>> nodes)
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
