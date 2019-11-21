using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPrac.DataStructures.LinkedLists
{
    public class SinglyNode<T>
    {
        public T value;

        public SinglyNode<T> next;

        public SinglyNode(T value)
        {
            this.value = value;
        }
    }
}
