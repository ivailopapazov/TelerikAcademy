namespace SimpleDataStructures
{
    using System;
    using System.Linq;

    internal class Node<T>
    {
        private Node<T> next;
        private T value;

        public Node(T item)
        {
            this.Next = null;
            this.Value = item;
        }

        public T Value
        {
            get
            {
                return this.value;
            }
            private set
            {
                this.value = value;
            }
        }

        public Node<T> Next
        {
            get
            {
                return this.next;
            }
            set
            {
                this.next = value;
            }
        }
    }
}
