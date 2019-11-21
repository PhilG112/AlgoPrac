using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AlgoPrac.DataStructures.LinkedLists
{
    public class MyDoublyLinkedList<T> : EqualityComparer<T>
    {
        public int Count { get; private set; }
        public DoublyNode<T> Head;
        public DoublyNode<T> Tail;

        // Average O(1) | O(1) space
        public void SetHead(DoublyNode<T> node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            InsertBefore(Head, node);
        }

        // Average O(1) | O(1) space
        public void SetTail(DoublyNode<T> node)
        {
            if (Head == null)
            {
                SetHead(node);
                return;
            }

            InsertAfter(Tail, node);
        }

        // Average O(1) | O(1) space
        public void InsertBefore(DoublyNode<T> node, DoublyNode<T> nodeToInsert)
        {
            if (nodeToInsert == Head && nodeToInsert == Tail) return;
            Remove(nodeToInsert);

            nodeToInsert.Prev = node.Prev;
            nodeToInsert.Next = node;

            if (node.Prev == null)
            {
                Head = nodeToInsert;
            }
            else
            {
                node.Prev.Next = nodeToInsert;
            }

            node.Prev = nodeToInsert;
            Count++;
        }

        // Average O(1) | O(1) space
        public void InsertAfter(DoublyNode<T> node, DoublyNode<T> nodeToInsert)
        {
            if (nodeToInsert == Head && nodeToInsert == Tail) return;
            Remove(nodeToInsert);

            nodeToInsert.Next = node.Next;
            nodeToInsert.Prev = node;

            if (node.Next == null)
            {
                Tail = nodeToInsert;
            }
            else
            {
                node.Next.Prev = nodeToInsert;
            }

            node.Next = nodeToInsert;
            Count++;
        }

        // Average O(p) | O(1) space where p = position
        public void InsertAtPosition(int position, DoublyNode<T> nodeToInsert)
        {
            if (position == 1)
            {
                SetHead(nodeToInsert);
            }

            var current = Head;
            var currentPosition = 1;
            while (current != null && currentPosition != position)
            {
                current = current.Next;
                currentPosition++;
            }

            if (current != null)
            {
                InsertBefore(current, nodeToInsert);
            }
            else
            {
                SetTail(nodeToInsert);
            }

            Count++;
        }

        // Average O(n) | O(1) space
        public void RemoveNodesWithValue(T value)
        {
            var current = Head;
            var eq = EqualityComparer<T>.Default;
            while (current != null)
            {
                var nodeToRemove = current;
                current = current.Next;
                if (eq.Equals(nodeToRemove.Value, value))
                {
                    Remove(nodeToRemove);
                }

                current = current.Next;
            }
        }

        // Average O(1) | O(1) space
        public void Remove(DoublyNode<T> node)
        {
            if (node == Head)
                Head = Head.Next;

            if (node == Tail)
                Tail = Tail.Prev;

            RemoveNodeBindings(node);

            Count--;
        }

        // Average O(n) | O(1) space
        public bool ContainsNodeWithValue(T value)
        {
            var node = Head;
            var eq = EqualityComparer<T>.Default;
            while (node != null && !eq.Equals(Head.Value, value))
            {
                node = node.Next;
            }

            return node != null;
        }

        public override bool Equals([AllowNull] T x, [AllowNull] T y)
        {
            return Default.Equals(x, y);
        }

        public override int GetHashCode([DisallowNull] T obj)
        {
            throw new NotImplementedException();
        }

        private void RemoveNodeBindings(DoublyNode<T> node)
        {
            if (node.Prev != null)
                node.Prev.Next = node.Next;

            if (node.Next != null)
                node.Next.Prev = node.Prev;

            node.Next = null;
            node.Prev = null;
        }
    }
}
