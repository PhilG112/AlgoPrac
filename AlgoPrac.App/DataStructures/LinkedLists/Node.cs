using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPrac.DataStructures.LinkedLists
{
    public class Node<T>
    {
        public T value;

        public Node<T> next;

        public Node(T value)
        {
            this.value = value;
        }
    }
}
