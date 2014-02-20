using System;
using System.Text;

namespace SubstringExtensionMethod
{
    class TestSubstringExtension
    {
        static void Main()
        {
            /*
             * 1.Implement an extension method Substring(int index, int length) 
             * for the class StringBuilder that returns new StringBuilder and 
             * has the same functionality as Substring in the class String.
             */

            // Create new stringbuilder instance
            StringBuilder testStringBuilder = new StringBuilder("SomeTestString");

            // Get substring
            StringBuilder subStringBuilder = testStringBuilder.Substring(4, 4);

            // Print substring
            Console.WriteLine(subStringBuilder);
        }
    }
}
