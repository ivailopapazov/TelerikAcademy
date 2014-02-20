using System;
using System.Collections.Generic;

namespace IEnumerableExtensionMethods
{
    class IEnumerableExtensionsTest
    {
        static void Main()
        {
            /*
             * Implement a set of extension methods for IEnumerable<T> 
             * that implement the following group functions: sum, product, min, max, average.
             */

            // Testing collection
            List<double> testCollection = new List<double>() { 5, 10, -5, 20, -13, -1};

            // Sum of the colleciton
            Console.WriteLine("Sum of the collection is equal to {0}", testCollection.Sum());

            // Product of the collection
            Console.WriteLine("Product of the collection is equal to {0}", testCollection.Product());

            // Min element in the collection
            Console.WriteLine("Min element in the collection is equal to {0}", testCollection.Min());

            // Max element in the collection
            Console.WriteLine("Max element in the collection is equal to {0}", testCollection.Max());

            // Average of the collection
            Console.WriteLine("Average of the elements in the collection is equal to {0}", testCollection.Average());
        }
    }
}
