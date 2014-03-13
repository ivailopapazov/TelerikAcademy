namespace SimpleDataStructures
{
    using System;
    using System.Linq;

    public class Stack<T> : IStack<T>
    {
        private T[] internalArray;
        private int count;
        private int capacity;

        public Stack() : this(2)
        {

        }

        public Stack(int capacity)
        {
            this.internalArray = new T[capacity];
            this.count = 0;
            this.Capacity = capacity;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                this.Resize(capacity);
                this.capacity = value;
            }
        }

        public void Push(T item)
        {
            if (this.IsFull())
            {
                this.Resize(capacity * 2);
            }

            this.internalArray[this.count] = item;
            this.count++;
        }

        public T Pop()
        {
            if (this.IsEmpty())
            {
                throw new ArgumentNullException("Stack is empty!");
            }

            var lastElement = this.internalArray[this.count];
            this.internalArray[this.count] = default(T);
            this.count--;

            return lastElement;
        }

        public T Peak()
        {
            if (this.IsEmpty())
            {
                throw new ArgumentNullException("Stack is empty!");
            }

            return this.internalArray[this.count];
        }

        public void Clear()
        {
            if (this.IsEmpty())
            {
                return;
            }

            Array.Clear(this.internalArray, 0, this.count);
            this.count = 0;
        }

        public bool IsEmpty()
        {
            if (this.count == 0)
            {
                return true;
            }

            return false;
        }

        private bool IsFull()
        {
            if (this.count == this.capacity)
            {
                return true;
            }

            return false;
        }

        private void Resize(int capacity)
        {
            if (capacity < this.count)
            {
                throw new IndexOutOfRangeException("Array capacity cannot be less than element count.");
            }

            var newArray = new T[capacity];

            // NOTE: Array.Copy() maybe is faster
            for (int i = 0; i < this.count; i++)
            {
                newArray[i] = this.internalArray[i];
            }

            this.internalArray = newArray;
        }
    }
}
