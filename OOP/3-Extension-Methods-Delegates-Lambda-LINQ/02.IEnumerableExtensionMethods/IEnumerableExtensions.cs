using System;
using System.Collections.Generic;

namespace IEnumerableExtensionMethods
{
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Returns the sum of the elements in the collection
        /// </summary>
        /// <param name="collection">Instance of the collection.</param>
        /// <returns>The sum of the elements in the collection.</returns>
        public static T Sum<T>(this IEnumerable<T> collection) where T : struct, IComparable, IFormattable, IConvertible
        {
            // Use dynamic type to hold the sum of the collection elements
            dynamic sum = 0;

            // Iterate collection and calculate the sum
            foreach (T element in collection)
            {
                sum += element;
            }

            // Return the sum
            return (T)sum;
        }

        public static T Product<T>(this IEnumerable<T> collection) where T : struct, IComparable, IFormattable, IConvertible
        {
            // Use dynamic type to hold the product of the collection elements
            dynamic product = 1;

            // Iterate collection and calculate the product
            foreach (T element in collection)
            {
                product *= element;
            }

            // Return the product
            return (T)product;
        }

        /// <summary>
        /// Returns the minimum element in the collection.
        /// </summary>
        /// <returns>Min element.</returns>
        public static T Min<T>(this IEnumerable<T> collection) where T : struct, IComparable, IFormattable, IConvertible
        {
            // minValue container
            T minValue;

            // Get enumerator of the collection.
            IEnumerator<T> iterator = collection.GetEnumerator();

            // Move to the first element of the collection
            if (iterator.MoveNext())
            {
                minValue = iterator.Current;
            }
            else
            {
                // If first element is the end of the collection.
                throw new InvalidOperationException("The collection is empty.");
            }

            // Iterate collection
            while (iterator.MoveNext())
            {
                // If current element is less than minValue
                if (minValue.CompareTo(iterator.Current) == 1)
                {
                    // Get value of the current element
                    minValue = iterator.Current;
                }
            }

            // Return min value
            return minValue;
        }

        /// <summary>
        /// Returns the maximum element in the collection.
        /// </summary>
        /// <returns>Max element.</returns>
        public static T Max<T>(this IEnumerable<T> collection) where T : struct, IComparable, IFormattable, IConvertible
        {
            // minValue container
            T maxValue;

            // Get enumerator of the collection.
            IEnumerator<T> iterator = collection.GetEnumerator();

            // Move to the first element of the collection
            if (iterator.MoveNext())
            {
                maxValue = iterator.Current;
            }
            else
            {
                // If first element is the end of the collection.
                throw new InvalidOperationException("The collection is empty.");
            }

            // Iterate collection
            while (iterator.MoveNext())
            {
                // If current element is greater than maxValue
                if (maxValue.CompareTo(iterator.Current) == -1)
                {
                    // Get value of the current element
                    maxValue = iterator.Current;
                }
            }

            // Return max value
            return maxValue;
        }

        /// <summary>
        /// Calculates the average of the elements in the collection.
        /// </summary>
        /// <returns>Average value.</returns>
        public static T Average<T>(this IEnumerable<T> collection)  where T : struct, IComparable, IFormattable, IConvertible 
        {
            // Use dynamic type to hold the sum of the collection elements
            dynamic sum = 0;
            int count = 0;

            // Iterate collection, calculate the sum and count the elements
            foreach (T element in collection)
            {
                sum += element;
                count++;
            }

            // Check for empty collection.
            if (count == 0)
            {
                 throw new InvalidOperationException("The collection is empty.");
            }

            // Return the average
            return sum / count;
        }
    }
}
