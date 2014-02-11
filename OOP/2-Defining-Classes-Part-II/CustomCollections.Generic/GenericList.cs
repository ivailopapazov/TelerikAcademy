using System;
using System.Collections.Generic;
using System.Text;

namespace CustomCollections.Generic
{
    /// <summary>
    /// Represents generic type collection.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericList<T> : IList<T>, IEnumerable<T> where T: IEquatable<T>, IComparable
    {
        #region Fields

        private int count;
        private T[] holder;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes new instance of GenericList collection.
        /// </summary>
        public GenericList() : this(2)
        {
        }

        /// <summary>
        /// Initializes new instance of GenericList collection.
        /// </summary>
        /// <param name="capacity">Initial GenericList capacity.</param>
        public GenericList(int capacity)
        {
            // Initialize class fields
            this.count = 0;
            this.holder = new T[capacity];
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the capacity of the GenericList.
        /// </summary>
        public int Capacity 
        {
            get
            {
                return this.holder.Length;
            }
            set
            {
                // Validation
                if (value < count)
                {
                    throw new ArgumentOutOfRangeException("Invalid capacity!");
                }
                // Skip resizing if capacity equals array length
                if (value != holder.Length)
                {
                    // Resize with given value.
                    this.Resize(value);
                }

            }
        }

        /// <summary>
        /// Gets element count contained in the GenericList instance.
        /// </summary>
        public int Count 
        {
            get
            {
                return this.count;
            }
        }

        /// <summary>
        /// Gets readonly state of the GenericList collection.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                // Generic list can be modified.
                return false;
            }
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets GenericList element by it's index.
        /// </summary>
        /// <param name="index">Index of GenericList element.</param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                // Validate index
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException("Specified index is out of range.");
                }

                // Return value at index position.
                return this.holder[index];
            }
            set
            {
                // Validate index
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException("Specified index is out of range.");
                }

                // Set value at index position.
                this.holder[index] = value;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds element to GenericList.
        /// </summary>
        /// <param name="item">The object to be added to the end of the GenericList collection.</param>
        public void Add(T item)
        {
            // Check if there is available position in the array
            if (count >= holder.Length)
            {
                // Double the size of the internal array
                this.Resize(holder.Length * 2);
            }

            // Add element to array
            this.holder[count] = item;

            // Increase count
            this.count++;
        }

        /// <summary>
        /// Removes element from GenericList by index.
        /// </summary>
        /// <param name="index">Index of the element to be deleted from GenericList.</param>
        public void RemoveAt(int index)
        {
            // Validate index
            if (index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException();
            }

            // Shift all elements after index to left if not the last element
            for (int i = index; i < holder.Length - 1; i++)
            {
                holder[i] = holder[i + 1];
            }

            // Remove last element
            holder[holder.Length - 1] = default(T);

            // Decrease count
            this.count--;
        }

        /// <summary>
        /// Returns the index of the first occurance of the element provided.
        /// </summary>
        /// <param name="item">Object to search for in the collection.</param>
        /// <returns></returns>
        public int IndexOf(T item)
        {
            // Return index of the element in the holder array
           return Array.IndexOf(holder, item);
        }

        /// <summary>
        /// Inserts object at a specific index in the GenericList.
        /// </summary>
        /// <param name="index">The position at which item should be inserted.</param>
        /// <param name="item">Obeject to be inserted.</param>
        public void Insert(int index, T item)
        {
            // Validate index
            if (index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException();
            }

            // Temp variables
            T newValue = item;
            T storeValue = default(T);

            // Reorder array
            for (int i = index; i < count; i++)
            {
                // Store current value
                storeValue = holder[i];

                // Set current index to new value
                holder[i] = newValue;

                // Make stored value to new value
                newValue = storeValue;
            }

            // Add last new value to the end of the array
            this.Add(newValue);
        }

        /// <summary>
        /// Clears the instance of GenericList collection.
        /// </summary>
        public void Clear()
        {
            // Clear if there are elements in the array
            if (count > 0)
            {
                // Clear the array
                Array.Clear(holder, 0, holder.Length);

                // Set count to zero
                this.count = 0;
            }
        }

        /// <summary>
        /// Determines whether an element is in the collection.
        /// </summary>
        /// <param name="item">The object to locate in the collection.</param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            // Iterate collection
            for (int i = 0; i < count; i++)
            {
                // Return true if there is an equal object 
                if (item.Equals(holder[i]))
                {
                    return true;
                }
            }

            // Return false if no equal object is found.
            return false;
        }

        /// <summary>
        /// Copies the entire GenericList<T> to a compatible one-dimensional array, starting at the specified index of the target array.
        /// </summary>
        /// <param name="array">The destination array for the elements to be copied into.</param>
        /// <param name="arrayIndex">Start index for copied elements.</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            // Copy internal array into array provided.
            Array.Copy(holder, 0, array, arrayIndex, this.count);
        }

        /// <summary>
        /// Removes firs occurance of a specific object from the GenericList<T>.
        /// </summary>
        /// <param name="item">The object to be removed from GenericList<T>.</param>
        /// <returns></returns>
        public bool Remove(T item)
        {
            // Get index of the object.
            int index = this.IndexOf(item);

            // Return false if there is no occurance of the specified object.
            if (index < 0)
            {
                return false;
            }

            // Remove the specified object.
            this.RemoveAt(index);

            // Return true.
            return true;
        }

        /// <summary>
        /// Returns the enumerator that iterates through the GenericList<T>.
        /// </summary>
        /// <returns>IEnumerator for the GenericList<T>.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            // Return next iteration of the loop.
            for (int i = 0; i < count; i++)
            {
                yield return holder[i];
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        /// Finds the max value in the GenericList<T> collection.
        /// </summary>
        /// <returns>Returns the max value.</returns>
        public T Max()
        {
            // Check if list is empty
            if (count == 0)
            {
                throw new InvalidOperationException("Cannot return max value when GenericList is empty.");
            }

            // Set first element to be the maxValue
            T maxValue = this.holder[0];

            // Iterate next elements from the array
            for (int i = 1; i < this.count; i++)
            {
                // Compare the elements to the max value
                if (this.holder[i].CompareTo(maxValue) == 1)
                {
                    // Set max value if greater value is found
                    maxValue = this.holder[i];
                }
            }

            // Return max value
            return maxValue;
        }

        /// <summary>
        /// Finds the min value in the GenericList<T> collection.
        /// </summary>
        /// <returns>Returns the min value.</returns>
        public T Min()
        {
            // Check if list is empty
            if (count == 0)
            {
                throw new InvalidOperationException("Cannot return min value when GenericList is empty.");
            }

            // Set first element to bi the minValue
            T minValue = this.holder[0];

            // Iterate next elements from the array
            for (int i = 1; i < this.count; i++)
            {
                // Compare the elements to the min value
                if (this.holder[i].CompareTo(minValue) == -1)
                {
                    // Set min value if lesser value is found
                    minValue = this.holder[i];
                }
            }

            // Return min value
            return minValue;
        }

        /// <summary>
        /// Converts GenericList<T> into string.
        /// </summary>
        /// <returns>String representation of GenericList<T></returns>
        public override string ToString()
        {
            // Check if list is empty
            if (count == 0)
            {
                return string.Empty;
            }

            // Use stringbuilder
            StringBuilder result = new StringBuilder();

            // Append elements to the string builder
            for (int i = 0; i < this.count - 1; i++)
            {
                result.AppendFormat("{0}, ", this.holder[i]);
            }

            // Append last element
            result.Append(this.holder[count - 1]);

            // Return string
            return result.ToString();
        }

        /// <summary>
        /// Set new size to the internal array.
        /// </summary>
        /// <param name="newSize">New size of the array.</param>
        private void Resize(int newSize)
        {
            Array.Resize(ref holder, newSize);
        }
        #endregion
    }
}
