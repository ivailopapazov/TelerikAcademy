/* Write a program that prints from given array of integers all numbers
 * that are divisible by 7 and 3. Use the built-in extension methods and
 * lambda expressions. Rewrite the same with LINQ.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbersDivisibleBy7and3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create array with integers
            int[] numbers = GenerateIntArray(200);

            // Select numbers divisible by 7 and 3 using extension method FindAll and lambda expression
            int[] numbersDivisibleBy7and3 = Array.FindAll(numbers, num => num != 0 && num % 21 == 0);

            // Print result
            Console.WriteLine("Numbers divisible by 7 and 3. Extension method and lambda expression is used.");
            Array.ForEach(numbersDivisibleBy7and3, num => Console.WriteLine(num));
            Console.WriteLine(new string('-', 20));

            // Select numbers using LINQ query
            IEnumerable<int> numbersDivisibleBy7and3LINQ =
                from num in numbers
                where num % 21 == 0 && num != 0
                select num;

            // Print result
            Console.WriteLine("Numbers divisible by 7 and 3. Using LINQ query.");
            foreach (int num in numbersDivisibleBy7and3LINQ)
            {
                Console.WriteLine(num);
            }

        }

        /// <summary>
        /// Generates array with random integer numbers.
        /// </summary>
        /// <param name="size">Size of the array.</param>
        /// <returns>Generated int array with random integers.</returns>
        static int[] GenerateIntArray(int size)
        {
            // Declaration
            Random rand = new Random();
            int[] arr = new int[size];

            // Fill the array with random numbers
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, int.MaxValue);
            }

            // Return generated array
            return arr;
        }
    }
}
