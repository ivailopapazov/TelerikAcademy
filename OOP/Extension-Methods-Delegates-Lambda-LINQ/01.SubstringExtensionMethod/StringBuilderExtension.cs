using System;
using System.Text;

namespace SubstringExtensionMethod
{
    public static class StringBuilderExtension
    {
        /// <summary>
        /// Retrieves a substring from this instance. The substring starts at a specified character position and has a specified length.
        /// </summary>
        /// <param name="item">Current StringBuilder instance.</param>
        /// <param name="index">The zero-based starting character position of a substring in this instance.</param>
        /// <param name="length">The number of characters in the substring.</param>
        /// <returns>A stringbuilder that is equivalent to the substring of length length that begins at index in this instance</returns>
        public static StringBuilder Substring(this StringBuilder item, int index, int length)
        {
            // Validate index
            if (index < 0 || index >= item.Length)
            {
                throw new ArgumentOutOfRangeException("Index out of range.");
            }

            // Validate length
            if (length < 0 || index + length > item.Length)
            {
                throw new ArgumentOutOfRangeException("Invalid length.");
            }

            // Container for the substring
            StringBuilder subStringBuilder = new StringBuilder();

            // Iterate characters from index 
            for (int i = index; i < index + length; i++)
            {
                subStringBuilder.Append(item[i]);
            }

            // Return substring
            return subStringBuilder;
        }
    }
}
