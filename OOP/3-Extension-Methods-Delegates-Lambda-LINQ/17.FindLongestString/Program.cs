using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLongestString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 17.Write a program to return the string with maximum length
             * from an array of strings. Use LINQ.
             */

            // Create string array
            string[] words = new string[] 
            {
                "lksadjkasd",
                "a2df",
                "adfgfhg,.lkj",
                "adsddf",
                "lksadjrggsxcvxkasd",
                "cxzcxzvcxgrsg",
                "asdz",
                "zz",
                "LongestLongestLongestLongestLongestLongest",
                "asdasd",
            };

            // Order words by length than take the first element
            string longestString =
                (from word in words
                 orderby word.Length descending
                 select word).First();

            // Print first element
            Console.WriteLine(longestString);
        }
    }
}
