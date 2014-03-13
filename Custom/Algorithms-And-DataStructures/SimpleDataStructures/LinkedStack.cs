namespace SimpleDataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LinkedStack<T>
    {
        private Node<T> first;

        public LinkedStack()
        {
            this.first = null;
        }

        public void Push(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Cannot push a null value to a stack!");
            }

            // Save current first
            var oldFirst = this.first;

            // Make new first
            this.first = new Node<T>(item);

            // Link new first to old first
            this.first.Next = oldFirst;
        }

        public T Pop()
        {
            if (this.IsEmpty())
            {
                throw new ArgumentNullException("Stack is empty!");
            }

            // Save current first
            Node<T> currentFirst = this.first;

            // Remove the reference to first
            this.first = null;

            // Make next to be first 
            if (currentFirst.Next != null)
            {
                this.first = currentFirst.Next;
            }

            return currentFirst.Value;
        }

        public T Peak()
        {
            if (this.IsEmpty())
            {
                throw new ArgumentNullException("Stack is empty!");
            }

            return this.first.Value;
        }

        public bool IsEmpty()
        {
            if (this.first == null)
            {
                return true;
            }

            return false;
        }
    }
}
