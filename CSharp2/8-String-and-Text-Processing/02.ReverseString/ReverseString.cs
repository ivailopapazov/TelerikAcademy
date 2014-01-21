using System;
using System.Collections.Generic;

class ReverseString
{
    static string Reverse(string word)
    {
        // Convert to char array
        char[] wordArr = word.ToCharArray();

        // Reverse array
        Array.Reverse(wordArr);

        // Return reversed string
        return new string(wordArr);
    }
    static void Main(string[] args)
    {
        // User input
        Console.Write("Enter a string: ");
        string sample = Console.ReadLine();

        // Reverse string
        string reversed = Reverse(sample);

        // Print result
        Console.WriteLine(reversed);
    }
}
