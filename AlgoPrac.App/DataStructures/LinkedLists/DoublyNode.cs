namespace AlgoPrac.DataStructures.LinkedLists
{
    public class DoublyNode<T>
    {
        public T Value;
        public DoublyNode<T> Prev;
        public DoublyNode<T> Next;

        public DoublyNode(T value)
        {
            Value = value;
        }
    }
}
